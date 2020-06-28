using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Mvc;
using Okta.Sdk;
using Okta.Sdk.Configuration;

namespace AccessAnalytics.Web.Controllers
{
    public class AuthController : Controller
    {
        public async Task AuthenticateUser()
        {
            var client = new OktaClient(new OktaClientConfiguration
            {
                OktaDomain = "https://dev-916703-admin.okta.com/",
                AuthorizationMode = AuthorizationMode.PrivateKey,
                ClientId = "0oahpd9vrANUKJGko4x6",
                Scopes = new List<string> { "okta.users.read", "okta.apps.read", "okta.groups.read" },
                PrivateKey =  new JsonWebKeyConfiguration("jsonString")
            });

            var user = await client.Users.GetUserAsync("jslowik@gmail.com");
        }

        [HttpPost("[action]")]
        public async Task AuthCallback()
        {
            var auth = User.IsAuthenticated();
            var user = User;
        }
    }
}