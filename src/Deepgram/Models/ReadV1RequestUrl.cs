using System.Text.Json.Serialization;
using Deepgram.Core.Models;
using Deepgram.Core.Validation;
using Deepgram.Core.Validation.Attributes;

namespace Deepgram.Models;

public record ReadV1RequestUrl
{
    /// <summary>
    /// A URL pointing to the text source
    /// </summary>
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
