using System.Collections.Generic;
using Deepgram.Core.Configuration;
using Deepgram.Core.Hooks;
using Deepgram.Servers;

namespace Deepgram;

public class DeepgramClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
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
