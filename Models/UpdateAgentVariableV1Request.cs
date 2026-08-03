using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Request body for updating an agent variable
/// </summary>
public record UpdateAgentVariableV1Request
{
    /// <summary>
    /// The new value to substitute
    /// </summary>
    [JsonPropertyName("value")]
    public required object Value { get; init; }
}
