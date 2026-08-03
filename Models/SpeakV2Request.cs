using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Request body for Flux TTS batch (REST) text-to-speech conversion. The full block of text is synthesized in a single request and returned as one audio response.
/// </summary>
public record SpeakV2Request
{
    /// <summary>
    /// The text content to be converted to speech. The server normalizes and preprocesses the text (e.g. stripping inline controls) before synthesis.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }
}
