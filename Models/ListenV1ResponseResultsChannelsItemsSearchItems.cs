using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListenV1ResponseResultsChannelsItemsSearchItems
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public string? Query { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hits")]
    public IReadOnlyList<ListenV1ResponseResultsChannelsItemsSearchItemsHitsItems>? Hits { get; init; }
}
