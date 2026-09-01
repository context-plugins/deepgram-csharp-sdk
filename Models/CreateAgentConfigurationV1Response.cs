using System.Collections.Generic;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record CreateAgentConfigurationV1Response
{
    /// <summary>
    /// The unique identifier of the newly created agent configuration
    /// </summary>
    [JsonPropertyName("agent_id")]
    public required string AgentId { get; init; }

    /// <summary>
    /// The parsed agent configuration object
    /// </summary>
    [JsonPropertyName("config")]
    public required object Config { get; init; }

    /// <summary>
    /// Metadata associated with the agent configuration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
