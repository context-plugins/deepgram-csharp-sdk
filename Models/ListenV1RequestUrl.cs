using System.Text.Json.Serialization;
using RestApi.Core.Validation;
using RestApi.Core.Validation.Attributes;

namespace RestApi.Models;

/// <summary>
/// Audio file URL to transcribe
/// </summary>
public record ListenV1RequestUrl
{
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }
}
