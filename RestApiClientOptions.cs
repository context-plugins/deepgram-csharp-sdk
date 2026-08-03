using RestApi.Core.Configuration;
using RestApi.Servers;

namespace RestApi;

public class RestApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Use <c>Authorization: Token &lt;API_KEY&gt;</c>
    /// Example: <c>Authorization: Token 12345abcdef</c>
    /// </summary>
    public string? ApiKeyAuth { get; set; }
    /// <summary>
    /// Use <c>Authorization: Bearer &lt;JWT&gt;</c>
    /// Example: <c>Authorization: Bearer eyJhbGciOiJ...</c>
    /// </summary>
    public string? JwtAuth { get; set; }
}
