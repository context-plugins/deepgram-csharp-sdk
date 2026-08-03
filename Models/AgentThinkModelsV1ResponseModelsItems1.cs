using System.Text.Json.Serialization;
using RestApi.Models.Enums;

namespace RestApi.Models;

/// <summary>
/// Anthropic models
/// </summary>
public record AgentThinkModelsV1ResponseModelsItems1
{
    /// <summary>
    /// The unique identifier of the Anthropic model
    /// </summary>
    [JsonPropertyName("id")]
    public required AgentThinkModelsV1ResponseModelsItemsOneOf1Id Id { get; init; }

    /// <summary>
    /// The display name of the model
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The provider of the model
    /// </summary>
    [JsonPropertyName("provider")]
    public required object Provider { get; init; }
}
