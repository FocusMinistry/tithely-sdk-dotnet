using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tithely.Api.Model {
    public class TithelyResponse<T> : TithelyResponseData<T> where T : new() {
        public string Status { get; set; }

        public string Type { get; set; }

        public string Reason { get; set; }

        public bool IsSuccessful {
            get {
                return Status == "success";
            }
        }
    }
}
