using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListenV1ResponseResultsSummary
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public string? Result { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short")]
    public string? Short { get; init; }
}
