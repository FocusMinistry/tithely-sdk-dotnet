using Tithely.Api.Model;


namespace Tithely.Api.Sets {
    public class OrganizationSet : BaseApiSet<OrganizationResponse> {
        private const string _getUrl = "/api/v1/organizations/{0}";
        private const string _listUrl = "/api/v1/organizations-list";

        public OrganizationSet(TithelyOptions options) : base(options) {

        }

        protected override string GetUrl => _getUrl;

        protected override string ListUrl => _listUrl;

        protected override string CreateUrl => _listUrl;
    }
}
