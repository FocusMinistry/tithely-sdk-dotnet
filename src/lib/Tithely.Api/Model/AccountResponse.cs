using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tithely.Api.Model {
    public class AccountResponse : TithelyResponse<Account> {
        [JsonProperty("account_id")]
        public string AccountID { get; set; }

        [JsonProperty("existing_account")]
        public bool ExistingAccount { get; set; }
    }
}
