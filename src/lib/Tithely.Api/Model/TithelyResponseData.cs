using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tithely.Api.Model {
    public class TithelyResponseData<T> where T : new() {
        public List<T> Data { get; set; }

        public T Object { get; set; }
    }
}
