using Deepgram.Core.Authentication;
using Deepgram.Core.Authentication.ApiKey;
using Deepgram.Core.Authentication.Bearer;

namespace Deepgram;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKeyAuth { get; }
    public IAuthScheme JwtAuth { get; }

    public AuthSchemes(DeepgramClientOptions options)
    {
        ApiKeyAuth = ApiKeyHeaderScheme.Create("Authorization", options.ApiKeyAuth);
        JwtAuth = BearerAuthScheme.Create(options.JwtAuth);
    }
}
