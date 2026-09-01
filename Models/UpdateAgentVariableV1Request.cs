using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
