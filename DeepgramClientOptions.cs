using System;
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
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
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
