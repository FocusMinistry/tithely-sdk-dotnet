using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tithely.Api.Model {
    public class Address {
        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("postal")]
        public string Postal { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }

}
