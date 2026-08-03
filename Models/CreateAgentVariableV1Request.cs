using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Request body for creating an agent variable
/// </summary>
public record CreateAgentVariableV1Request
{
    /// <summary>
    /// The variable name, following the DG_&lt;VARIABLE_NAME&gt; format
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// The value to substitute. Can be any valid JSON type (string, number, boolean, object, or array)
    /// </summary>
    [JsonPropertyName("value")]
    public required object Value { get; init; }

    /// <summary>
    /// API version. Defaults to 1
    /// </summary>
    [JsonPropertyName("api_version")]
    public int? ApiVersion { get; init; } = 1;
}
