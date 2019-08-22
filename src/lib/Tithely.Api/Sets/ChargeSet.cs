using Tithely.Api.Model;
using Tithely.Api.Extensions;

namespace Tithely.Api.Sets {
    public class ChargeSet : BaseApiSet<ChargeResponse> {
        private const string _createUrl = "/api/v1/accounts";
        private const string _getUrl = "/api/v1/accounts/{0}";
        private const string _listUrl = "/api/v1/accounts-list-all";

        public ChargeSet(TithelyOptions options) : base(options) {

        }

        protected override string GetUrl => _getUrl;

        protected override string ListUrl => _listUrl;

        protected override string EditUrl => _getUrl;

        protected override string CreateUrl => _createUrl;

        public ITithelyRestResponse<ChargeResponse> QuickCharge(string email, string firstName, string lastName, string token, string organizationID, int amount, string givingType) {
            AddParameter("email", email);
            AddParameter("first_name", firstName);
            AddParameter("last_name", lastName);
            AddParameter("token", token);
            AddParameter("organization_id", organizationID);
            AddParameter("amount", amount.ToString());
            AddParameter("giving_type", givingType);

            return base.Create("/api/v1/charge-once");
        }

        public ITithelyRestResponse<ChargeResponse> Refund(string chargeID) {
            var response = base.Post($"/api/v1/refunds/{chargeID}");
            return response.ToTithelyResponse();
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