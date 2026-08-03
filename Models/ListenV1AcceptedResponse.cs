using System;
using System.Text.Json.Serialization;

namespace RestApi.Models;

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
}
