using System;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record UsageV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public DateTimeOffset? Start { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end")]
    public DateTimeOffset? End { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resolution")]
    public UsageV1ResponseResolution? Resolution { get; init; }
}
