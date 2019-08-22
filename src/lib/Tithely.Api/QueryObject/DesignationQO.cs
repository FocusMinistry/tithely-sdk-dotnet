using Tithely.Api.Attributes;
using Tithely.Api.Enum;

namespace Tithely.Api.QueryObject {
    public class DesignationQO : BaseQO {
        [QO("QueryTerm")]
        public string QueryTerm { get; set; }
    }
}
