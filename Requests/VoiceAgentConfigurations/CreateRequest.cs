using Deepgram.Models;

namespace Deepgram.Requests.VoiceAgentConfigurations;

/// <summary>
/// The inputs of the Create operation.
/// </summary>
public sealed record CreateRequest
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Agent configuration details
    /// </summary>
    public CreateAgentConfigurationV1Request? Body { get; init; }
}
