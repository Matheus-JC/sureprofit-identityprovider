using IdentityServer4.Models;

namespace SureProfit.IndentityProvider.IndentityConfiguration;

public class Clients
{
    public static IEnumerable<Client> Get()
    {
        return new List<Client>
        {
            new() {
                ClientId = "sureProfitApi",
                ClientName = "SureProfit API",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> {new("SureProfit".Sha256())},
                AllowedScopes = new List<string> {"sureProfitApi.read","sureProfitApi.write"}
            }
        };
    }
}