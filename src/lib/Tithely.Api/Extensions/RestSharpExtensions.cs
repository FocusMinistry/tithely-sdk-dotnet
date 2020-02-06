using Tithely.Api.Model;
using RestSharp;
using System;
using System.Dynamic;
using System.Collections.Generic;

namespace Tithely.Api.Extensions {
    public static class RestSharpExtensions {
        public static ITithelyRestResponse<S> ToTithelyResponse<S>(this IRestResponse<S> restResponse) where S : new() {
            var response = new TithelyRestResponse<S>();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if ((int)restResponse.StatusCode >= 300) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }
            else {
                if (restResponse.Content.Contains("status")) {
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(restResponse.Content);
                    var status = data.status.ToString();

                    if (status == "fail") {
                        response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    }
                }

                response.Result = restResponse.Data;
            }
            return response;
        }

        public static ITithelyRestResponse<S> ToTithelyResponse<S>(this IRestResponse<S> restResponse, string requestInput) where S : new() {
            var response = restResponse.ToTithelyResponse();
            response.RequestValue = requestInput;
            return response;
        }

        private static string GetPropertyValue(dynamic obj, string name) {
            Type objType = obj.GetType();

            if (objType == typeof(ExpandoObject) && ((IDictionary<string, object>)obj).ContainsKey(name)) {
                return ((IDictionary<string, object>)obj)[name].ToString();
            }

            if (objType.GetProperty(name) != null) {
               return objType.GetProperty(name).GetValue(objType).ToString();
            }
            return null;
        }
    }
}
