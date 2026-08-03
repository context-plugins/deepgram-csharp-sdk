using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedIntentsResultsIntents
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segments")]
    public IReadOnlyList<SharedIntentsResultsIntentsSegmentsItems>? Segments { get; init; }
}
