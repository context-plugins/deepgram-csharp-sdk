namespace Deepgram.Requests.VoiceAgentConfigurations;

/// <summary>
/// The inputs of the Get operation.
/// </summary>
public sealed record GetRequest
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the agent configuration
    /// </summary>
    public required string AgentId { get; init; }
}
