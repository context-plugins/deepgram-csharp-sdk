using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Request body for updating agent configuration metadata
/// </summary>
public record UpdateAgentMetadataV1Request
{
    /// <summary>
    /// A map of string key-value pairs to associate with this agent configuration
    /// </summary>
    [JsonPropertyName("metadata")]
    public required IReadOnlyDictionary<string, string> Metadata { get; init; }
}
