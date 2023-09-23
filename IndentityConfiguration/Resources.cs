using IdentityServer4.Models;

namespace SureProfit.IndentityProvider.IndentityConfiguration;

public class Resources
{
    public static IEnumerable<ApiResource> GetApiResources()
    {
        return new[]
        {
            new ApiResource
            {
                Name = "sureProfitApi",
                DisplayName = "SureProfit Api",
                Description = "Allow the application to access SureProfit Api on your behalf",
                Scopes = new List<string> { "sureProfitApi.read", "sureProfitApi.write"},
                ApiSecrets = new List<Secret> {new("SureProfitApi".Sha256())},
                UserClaims = new List<string> {"role"}
            }
        };
    }
}