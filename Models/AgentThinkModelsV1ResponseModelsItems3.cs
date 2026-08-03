using System.Text.Json.Serialization;
using RestApi.Models.Enums;

namespace RestApi.Models;

/// <summary>
/// Groq models
/// </summary>
public record AgentThinkModelsV1ResponseModelsItems3
{
    /// <summary>
    /// The unique identifier of the Groq model
    /// </summary>
    [JsonPropertyName("id")]
    public required AgentThinkModelsV1ResponseModelsItemsOneOf3Id Id { get; init; }

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
