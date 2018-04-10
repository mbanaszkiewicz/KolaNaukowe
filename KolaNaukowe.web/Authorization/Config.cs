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
               ClientId = "rg",
               ClientName = "StudentResearchGroupsClient",
               AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
               AllowAccessTokensViaBrowser = true,
               RequireConsent = false,
               ClientSecrets =
               {
                   new Secret("secret".Sha256())
               },
               RedirectUris =
               {
                   "http://localhost:50000/signin-oidc"
               },
               PostLogoutRedirectUris = {"http://localhost:50000/signout-callback-oidc.html"},
               AllowedScopes = {"openid", "profile", "email", "api"},
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
            new ApiResource("api", "my api")
        };
    }
}
