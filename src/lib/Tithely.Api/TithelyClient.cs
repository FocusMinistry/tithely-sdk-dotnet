using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Tithely.Api.Extensions;
using Tithely.Api.Model;
using Tithely.Api.Sets;

namespace Tithely.Api {
    public class TithelyClient {
        private readonly OrganizationSet _organizationSet;
        private readonly AccountSet _accountSet;
        private readonly ChargeSet _chargeSet;

        public TithelyClient(TithelyOptions options) {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11;

            _organizationSet = new OrganizationSet(options);
            _accountSet = new AccountSet(options);
            _chargeSet = new ChargeSet(options);
        }

        public OrganizationSet Organizations => _organizationSet;

        public AccountSet Accounts => _accountSet;

        public ChargeSet Charges => _chargeSet;
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}