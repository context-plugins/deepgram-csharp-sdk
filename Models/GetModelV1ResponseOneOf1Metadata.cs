using System.Collections.Generic;
using System.Text.Json.Serialization;
using RestApi.Core.Validation;
using RestApi.Core.Validation.Attributes;

namespace RestApi.Models;

public record GetModelV1ResponseOneOf1Metadata
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accent")]
    public string? Accent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("age")]
    public string? Age { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public string? Color { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image")]
    [Format(FormatKind.Uri)]
    public string? Image { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sample")]
    [Format(FormatKind.Uri)]
    public string? Sample { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string>? Tags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("use_cases")]
    public IReadOnlyList<string>? UseCases { get; init; }
}
