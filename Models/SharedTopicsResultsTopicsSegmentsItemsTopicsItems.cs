using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedTopicsResultsTopicsSegmentsItemsTopicsItems
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topic")]
    public string? Topic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence_score")]
    public double? ConfidenceScore { get; init; }
}
