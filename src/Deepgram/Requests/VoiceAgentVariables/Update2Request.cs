using Deepgram.Models;

namespace Deepgram.Requests.VoiceAgentVariables;

/// <summary>
/// The inputs of the Update2 operation.
/// </summary>
public sealed record Update2Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the agent variable
    /// </summary>
    public required string VariableId { get; init; }

    /// <summary>
    /// Updated value for the agent variable
    /// </summary>
    public UpdateAgentVariableV1Request? Body { get; init; }
}
