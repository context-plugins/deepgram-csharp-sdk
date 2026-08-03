using System.Text.Json.Serialization;
using RestApi.Models.Enums;

namespace RestApi.Models;

/// <summary>
/// Google models
/// </summary>
public record AgentThinkModelsV1ResponseModelsItems2
{
    /// <summary>
    /// The unique identifier of the Google model
    /// </summary>
    [JsonPropertyName("id")]
    public required AgentThinkModelsV1ResponseModelsItemsOneOf2Id Id { get; init; }

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
