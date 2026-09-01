using System.Text.Json.Serialization;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models;

/// <summary>
/// OpenAI models
/// </summary>
public record AgentThinkModelsV1ResponseModelsItems0
{
    /// <summary>
    /// The unique identifier of the OpenAI model
    /// </summary>
    [JsonPropertyName("id")]
    public required AgentThinkModelsV1ResponseModelsItemsOneOf0Id Id { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
