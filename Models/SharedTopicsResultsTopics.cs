using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedTopicsResultsTopics
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segments")]
    public IReadOnlyList<SharedTopicsResultsTopicsSegmentsItems>? Segments { get; init; }
}
