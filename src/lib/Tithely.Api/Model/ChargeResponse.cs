﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tithely.Api.Model {
    public class ChargeResponse : TithelyResponse<Charge> {
        [JsonProperty("charge_id")]
        public string ChargeID { get; set; }

    }
}
