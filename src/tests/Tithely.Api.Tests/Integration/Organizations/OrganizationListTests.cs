using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Tithely.Api.Tests.Integration.Organizations {
    public class OrganizationListTests : BaseTests {
        [Test]
        public void integration_get_organization_list() {
            var organizations = TithelyClient.Organizations.List();
            organizations.Result.Data.Count.ShouldBeGreaterThan(0);
        }
    }
}
