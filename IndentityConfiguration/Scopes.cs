using IdentityServer4.Models;

namespace SureProfit.IndentityProvider.IndentityConfiguration;

public class Scopes
{
    public static IEnumerable<ApiScope> GetApiScopes()
    {
        return new[]
        {
            new ApiScope("sureProfitApi.read", "Read Access to SureProfit API"),
            new ApiScope("sureProfitApi.write", "Write Access to SureProfit API"),
        };
    }
}
