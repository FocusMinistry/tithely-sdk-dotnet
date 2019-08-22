using Tithely.Api.Model;

namespace Tithely.Api.Sets {
    public class PaymentMethodSet : BaseApiSet<PaymentMethodResponse> {
        private const string _createUrl = "/api/v1/payment-methods";
        private const string _getUrl = "/api/v1/payment-methods/{0}";
        private const string _listUrl = "/api/v1/payment-methods-list";

        public PaymentMethodSet(TithelyOptions options) : base(options) {

        }

        protected override string GetUrl => _getUrl;

        protected override string ListUrl => _listUrl;

        protected override string EditUrl => _getUrl;

        protected override string CreateUrl => _createUrl;

        public ITithelyRestResponse<PaymentMethodResponse> Create(string accountID, string token, string url = "") {
            AddParameter("account_id", accountID);
            AddParameter("token", token);
            return base.Create(url);
        }
    }
}