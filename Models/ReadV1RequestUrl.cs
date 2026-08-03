using System.Text.Json.Serialization;
using RestApi.Core.Validation;
using RestApi.Core.Validation.Attributes;

namespace RestApi.Models;

public record ReadV1RequestUrl
{
    /// <summary>
    /// A URL pointing to the text source
    /// </summary>
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }
}
