using System.Collections.Generic;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

/// <summary>
/// Request body for creating an agent configuration
/// </summary>
public record CreateAgentConfigurationV1Request
{
    /// <summary>
    /// A valid JSON string representing the agent block of a Settings message
    /// </summary>
    [JsonPropertyName("config")]
    public required string Config { get; init; }

    /// <summary>
    /// A map of arbitrary key-value pairs for labeling or organizing the agent configuration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// API version. Defaults to 1
    /// </summary>
    [JsonPropertyName("api_version")]
    public int? ApiVersion { get; init; } = 1;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
