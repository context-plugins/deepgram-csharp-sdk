using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

/// <summary>
/// Accepted response for asynchronous transcription requests
/// </summary>
public record ListenV1AcceptedResponse
{
    /// <summary>
    /// Unique identifier for tracking the asynchronous request
    /// </summary>
    [JsonPropertyName("request_id")]
    public required Guid RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
