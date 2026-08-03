using Microsoft.Extensions.Logging;

namespace RestApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
