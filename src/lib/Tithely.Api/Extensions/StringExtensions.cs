﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tithely.Api.Extensions {
    public static class StringExtension {
        /// <summary>
        /// Serialize an object into XML
        /// </summary>
        /// <param name="serializableObject">Object that can be serialized</param>
        /// <returns>Serial XML representation</returns>
        public static string ToXml(this object serializableObject) {
            string ret = "";

            Type serializableObjectType = serializableObject.GetType();

            using (System.IO.StringWriter output = new System.IO.StringWriter(new System.Text.StringBuilder())) {
                System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(serializableObjectType);
                System.Xml.Serialization.XmlSerializerNamespaces xsn = new System.Xml.Serialization.XmlSerializerNamespaces();
                xsn.Add("", "");


                // get a list of the xml type attributes so that we can clean up the xml. In other words. remove extra namespace text.
                object[] attributes = serializableObjectType.GetCustomAttributes(typeof(System.Xml.Serialization.XmlTypeAttribute), false);
                if (attributes != null) {
                    System.Xml.Serialization.XmlTypeAttribute xta;
                    for (int i = 0; i < attributes.Length; i++) {
                        xta = (System.Xml.Serialization.XmlTypeAttribute)attributes[i];
                        //xsn.Add("ns" + 1, xta.Namespace);
                    }
                }

                s.Serialize(output, serializableObject, xsn);
                ret = output.ToString().Replace("utf-16", "utf-8").Trim();
            }

            return ret;
        }

        public static T FromJson<T>(this string item) {
            if (String.IsNullOrEmpty(item))
                return default(T);

            var jsonString = JToken.Parse(item).ToString();

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public static object FromJson(this string item, Type type) {
            if (String.IsNullOrEmpty(item))
                return null;

            return JsonConvert.DeserializeObject(item, type);
        }

    }
}