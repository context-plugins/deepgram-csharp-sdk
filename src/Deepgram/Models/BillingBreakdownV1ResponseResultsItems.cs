using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record BillingBreakdownV1ResponseResultsItems
{
    /// <summary>
    /// USD cost of the billing for this grouping
    /// </summary>
    [JsonPropertyName("dollars")]
    public required double Dollars { get; init; }

    [JsonPropertyName("grouping")]
    public required BillingBreakdownV1ResponseResultsItemsGrouping Grouping { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
