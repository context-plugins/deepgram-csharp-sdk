using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Deepgram.Core.Hooks;

namespace Deepgram.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
