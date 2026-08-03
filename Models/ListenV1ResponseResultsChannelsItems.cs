using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListenV1ResponseResultsChannelsItems
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("search")]
    public IReadOnlyList<ListenV1ResponseResultsChannelsItemsSearchItems>? Search { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alternatives")]
    public IReadOnlyList<ListenV1ResponseResultsChannelsItemsAlternativesItems>? Alternatives { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detected_language")]
    public string? DetectedLanguage { get; init; }
}
