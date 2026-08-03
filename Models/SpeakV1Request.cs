using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Request body for text-to-speech conversion
/// </summary>
public record SpeakV1Request
{
    /// <summary>
    /// The text content to be converted to speech
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }
}
