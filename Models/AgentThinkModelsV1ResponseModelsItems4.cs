using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// AWS Bedrock models (custom models accepted)
/// </summary>
public record AgentThinkModelsV1ResponseModelsItems4
{
    /// <summary>
    /// The unique identifier of the AWS Bedrock model (any model string accepted for BYO LLMs)
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

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
