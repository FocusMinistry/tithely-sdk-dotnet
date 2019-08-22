using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tithely.Api.Model {
    public class OrganizationResponse : TithelyResponse<Organization> {
        [JsonProperty("organization_id")]
        public string OrganizationID { get; set; }
    }
}
