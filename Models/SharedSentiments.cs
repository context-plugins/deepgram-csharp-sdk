using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Output whenever <c>sentiment=true</c> is used
/// </summary>
public record SharedSentiments
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segments")]
    public IReadOnlyList<SharedSentimentsSegmentsItems>? Segments { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("average")]
    public SharedSentimentsAverage? Average { get; init; }
}
