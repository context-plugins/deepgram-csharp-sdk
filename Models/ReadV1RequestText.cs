using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record ReadV1RequestText
{
    /// <summary>
    /// The plain text to analyze
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
