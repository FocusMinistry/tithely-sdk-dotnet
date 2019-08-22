using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tithely.Api.Model {
    public class Organization {
        [JsonProperty("organization_id")]
        public string ID { get; set; }

        [JsonProperty("widget_id")]
        public string WidgetID { get; set; }

        [JsonProperty("account_id")]
        public string AccountID { get; set; }

        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("giving_types")]
        public List<string> GivingTypes { get; set; }
    }
}
