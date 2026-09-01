using System.Text.Json.Serialization;
using Deepgram.Core.Models;
using Deepgram.Core.Validation;
using Deepgram.Core.Validation.Attributes;

namespace Deepgram.Models;

/// <summary>
/// Audio file URL to transcribe
/// </summary>
public record ListenV1RequestUrl
{
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
