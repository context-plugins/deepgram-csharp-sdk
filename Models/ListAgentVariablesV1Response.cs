using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListAgentVariablesV1Response
{
    /// <summary>
    /// A list of agent variables for the project
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variables")]
    public IReadOnlyList<AgentVariableV1>? Variables { get; init; }
}
