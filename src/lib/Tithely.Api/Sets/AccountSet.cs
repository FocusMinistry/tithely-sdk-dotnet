using Tithely.Api.Model;

namespace Tithely.Api.Sets {
    public class AccountSet : BaseApiSet<AccountResponse> {
        private const string _createUrl = "/api/v1/accounts";
        private const string _getUrl = "/api/v1/accounts/{0}";
        private const string _listUrl = "/api/v1/accounts-list-all";

        public AccountSet(TithelyOptions options) : base(options) {

        }

        protected override string GetUrl => _getUrl;

        protected override string ListUrl => _listUrl;

        protected override string EditUrl => _getUrl;

        protected override string CreateUrl => _createUrl;

        public ITithelyRestResponse<AccountResponse> Create(Account entity, string url = "") {
            PopulateParameters(entity);
            return base.Create(url);
        }

        private void PopulateParameters(Account entity) {
            AddParameter("email", entity.Email);
            AddParameter("password", entity.Password);
            AddParameter("pin", entity.Pin);
            AddParameter("first_name", entity.FirstName);
            AddParameter("last_name", entity.LastName);
        }
    }
}