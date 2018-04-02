using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OAuth.Configurations
{
    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[]
            {
                new ApiResource("researchgroups", "Research Groups")
            };
        }

        public static IEnumerable<Client> Clients()
        {
            return new[]
            {
                new Client()
                {
                    ClientId = "researchgroups",
                    ClientSecrets = new [] {new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new[] {"researchgroups"}
                }
            };
        }

        public static IEnumerable<TestUser> Users()
        {
            return new[]
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "testuser@testmail.com",
                    Password = "pass"
                }
            };
        }
    }
}
