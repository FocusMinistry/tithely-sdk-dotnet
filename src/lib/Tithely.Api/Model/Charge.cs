using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tithely.Api.Model {
    public class Charge {
        [JsonProperty("charge_status")]
        public string ChargeStatus { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("net_amount")]
        public int NetAmount { get; set; }

        [JsonProperty("fees")]
        public int Fees { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("giving_type")]
        public string GivingType { get; set; }

        [JsonProperty("charge_date")]
        public DateTime ChargeDate { get; set; }

        [JsonProperty("deposit_date")]
        public DateTime? DepositDate { get; set; }

        [JsonProperty("recurring_transaction")]
        public bool RecurringTransaction { get; set; }

        [JsonProperty("fees_covered")]
        public bool FeesCovered { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }

        [JsonProperty("donor_account")]
        public Account DonorAccount { get; set; }
    }
}
