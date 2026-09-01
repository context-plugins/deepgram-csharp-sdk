using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

/// <summary>
/// Groq models
/// </summary>
public record AgentThinkModelsV1ResponseModelsItems3
{
    /// <summary>
    /// The unique identifier of the Groq model
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; } = "openai/gpt-oss-20b";

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
