using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

/// <summary>
/// Accepted response returned when a callback URL is supplied; the audio is delivered asynchronously to that URL.
/// </summary>
public record SpeakV2AcceptedResponse
{
    /// <summary>
    /// Unique identifier for tracking the asynchronous request
    /// </summary>
    [JsonPropertyName("request_id")]
    public required Guid RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
