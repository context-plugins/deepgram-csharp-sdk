using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListAgentConfigurationsV1Response
{
    /// <summary>
    /// A list of agent configurations for the project
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agents")]
    public IReadOnlyList<AgentConfigurationV1>? Agents { get; init; }
}
