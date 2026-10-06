using Deepgram.Models;

namespace Deepgram.Requests.VoiceAgentVariables;

/// <summary>
/// The inputs of the Create2 operation.
/// </summary>
public sealed record Create2Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Agent variable details
    /// </summary>
    public CreateAgentVariableV1Request? Body { get; init; }
}
