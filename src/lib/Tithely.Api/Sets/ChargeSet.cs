﻿using Tithely.Api.Model;
using Tithely.Api.Extensions;

namespace Tithely.Api.Sets {
    public class ChargeSet : BaseApiSet<ChargeResponse> {
        private readonly TithelyOptions _options;
        private const string _createUrl = "/api/v1/charges";
        private const string _getUrl = "/api/v1/charges/{0}";
        private const string _listUrl = "/api/v1/charges-list";

        public ChargeSet(TithelyOptions options) : base(options) {
            _options = options;
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

            return base.Create(_options.ApiUrl + "/api/v1/charge-once");
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