using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;
using Tithely.Api.Model;

namespace Tithely.Api.Tests.Integration {
    public class AccountsTests : BaseTests {
        [Test]
        public void integration_accounts_list_all_accounts() {
            var accountResult = TithelyClient.Accounts.List();
            accountResult.Result.Data.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_accounts_create_new_account_with_plus() {
            var account = new Account {
                FirstName = "Bob",
                LastName = "Smith",
                Email = "52projectsapptesting+bob@gmail.com",
                PhoneNumber = "1231231234",
            };

            var accountResult = TithelyClient.Accounts.Create(account);
            accountResult.IsSuccessful.ShouldBe(true);
        }

        [Test]
        public void integration_accounts_retrieve_account() {
            var account = new Account {
                FirstName = "Bob",
                LastName = "Smith",
                Email = "52projectsapptesting@gmail.com",
                PhoneNumber = "1231231234",
                Password = "Pa$$w0rd",
                Pin = "1234"
            };

            var accountCreateResult = TithelyClient.Accounts.Create(account);
            var accountGetResult = TithelyClient.Accounts.Get(accountCreateResult.Result.AccountID);
            accountGetResult.IsSuccessful.ShouldBe(true);
        }
    }
}
