using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transcript")]
    public string? Transcript { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paragraphs")]
    public IReadOnlyList<ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems>? Paragraphs { get; init; }
}
