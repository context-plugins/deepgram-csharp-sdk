using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedIntentsResultsIntentsSegmentsItems
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_word")]
    public double? StartWord { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_word")]
    public double? EndWord { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intents")]
    public IReadOnlyList<SharedIntentsResultsIntentsSegmentsItemsIntentsItems>? Intents { get; init; }
}
