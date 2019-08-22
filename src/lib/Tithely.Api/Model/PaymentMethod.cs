using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tithely.Api.Model {
    public class PaymentMethod {
        [JsonProperty("last_4_digits")]
        public string Last4Digits { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("pm_type")]
        public string PmType { get; set; }

        [JsonProperty("account_id")]
        public string AccountID { get; set; }
    }
}
