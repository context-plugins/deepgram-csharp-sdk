using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record UsageBreakdownV1Response
{
    /// <summary>
    /// Start date of the usage period
    /// </summary>
    [JsonPropertyName("start")]
    public required DateTimeOffset Start { get; init; }

    /// <summary>
    /// End date of the usage period
    /// </summary>
    [JsonPropertyName("end")]
    public required DateTimeOffset End { get; init; }

    [JsonPropertyName("resolution")]
    public required UsageBreakdownV1ResponseResolution Resolution { get; init; }

    [JsonPropertyName("results")]
    public required IReadOnlyList<UsageBreakdownV1ResponseResultsItems> Results { get; init; }
}
