using RestApi.Core.Authentication;
using RestApi.Core.Authentication.ApiKey;
using RestApi.Core.Authentication.Bearer;

namespace RestApi;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKeyAuth { get; }
    public IAuthScheme JwtAuth { get; }

    public AuthSchemes(RestApiClientOptions options)
    {
        ApiKeyAuth = ApiKeyHeaderScheme.Create("Authorization", options.ApiKeyAuth);
        JwtAuth = BearerAuthScheme.Create(options.JwtAuth);
    }
}
