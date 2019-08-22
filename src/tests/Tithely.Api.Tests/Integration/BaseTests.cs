using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using Shouldly;
using NUnit.Framework;
using Tithely.Api;

namespace Tithely.Api.Tests.Integration {
    public class BaseTests {
        internal TithelyClient TithelyClient;

        public BaseTests() {
            TithelyClient = new TithelyClient(new TithelyOptions { ApiUrl = "https://tithelydev.com", PublicKey = "pub_5c9a91523358a", PrivateKey = "pri_5c9a915233631" });
        }
    }
}
