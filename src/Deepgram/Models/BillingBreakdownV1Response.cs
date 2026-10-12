using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record BillingBreakdownV1Response
{
    /// <summary>
    /// Start date of the billing summmary period
    /// </summary>
    [JsonPropertyName("start")]
    public required DateTimeOffset Start { get; init; }

    /// <summary>
    /// End date of the billing summary period
    /// </summary>
    [JsonPropertyName("end")]
    public required DateTimeOffset End { get; init; }

    [JsonPropertyName("resolution")]
    public required BillingBreakdownV1ResponseResolution Resolution { get; init; }

    [JsonPropertyName("results")]
    public required IReadOnlyList<BillingBreakdownV1ResponseResultsItems> Results { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
