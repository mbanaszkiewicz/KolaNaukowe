using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Authorization
{
    public class Config
    {
        public static IEnumerable<Client> Clients = new List<Client>
       {
           new Client
           {
               ClientId = "StudentResearchGroupsClient",
               ClientName = "StudentResearchGroupsClient",
               AllowedGrantTypes = GrantTypes.ClientCredentials,
               AllowAccessTokensViaBrowser = true,
               RequireConsent = false,
              RedirectUris = {
                    "http://localhost:50000/callback.html",
                    "http://localhost:50000/popup.html",
                    "http://localhost:50000/silent.html"
                },
                PostLogoutRedirectUris = { "http://localhost:50000/index.html" },
               AllowedScopes = {"openid", "profile", "email", "api"},
               AllowOfflineAccess = true,
            },
        };

        public static IEnumerable<IdentityResource> identityResources = new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
        };

        public static IEnumerable<ApiResource> Apis = new List<ApiResource>
        {
            new ApiResource("StudentResearchGroupAPI", "StudentResearchGroupAPI")
        };
    }
}
