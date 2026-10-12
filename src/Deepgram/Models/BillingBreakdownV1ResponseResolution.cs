using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record BillingBreakdownV1ResponseResolution
{
    /// <summary>
    /// Time unit for the resolution
    /// </summary>
    [JsonPropertyName("units")]
    public required string Units { get; init; }

    /// <summary>
    /// Amount of units
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
