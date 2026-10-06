using Deepgram.Models;

namespace Deepgram.Requests.VoiceAgentConfigurations;

/// <summary>
/// The inputs of the Update operation.
/// </summary>
public sealed record UpdateRequest
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the agent configuration
    /// </summary>
    public required string AgentId { get; init; }

    /// <summary>
    /// Updated metadata for the agent configuration
    /// </summary>
    public UpdateAgentMetadataV1Request? Body { get; init; }
}
