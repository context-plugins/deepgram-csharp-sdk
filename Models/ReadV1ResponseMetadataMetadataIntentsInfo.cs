using System;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ReadV1ResponseMetadataMetadataIntentsInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_uuid")]
    public Guid? ModelUuid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("input_tokens")]
    public int? InputTokens { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output_tokens")]
    public int? OutputTokens { get; init; }
}
