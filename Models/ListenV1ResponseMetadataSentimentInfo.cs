using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListenV1ResponseMetadataSentimentInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_uuid")]
    public string? ModelUuid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("input_tokens")]
    public int? InputTokens { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output_tokens")]
    public int? OutputTokens { get; init; }
}
