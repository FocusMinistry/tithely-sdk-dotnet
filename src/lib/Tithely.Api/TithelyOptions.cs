using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tithely.Api {
    public class TithelyOptions {
        public TithelyOptions() {
        }

        public string ApiUrl { get; set; }

        public string PublicKey { get; set; }

        public string PrivateKey { get; set; }
    }
}
