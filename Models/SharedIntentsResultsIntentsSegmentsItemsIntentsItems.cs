using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedIntentsResultsIntentsSegmentsItemsIntentsItems
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intent")]
    public string? Intent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence_score")]
    public double? ConfidenceScore { get; init; }
}
