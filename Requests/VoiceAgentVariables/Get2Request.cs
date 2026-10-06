namespace Deepgram.Requests.VoiceAgentVariables;

/// <summary>
/// The inputs of the Get2 operation.
/// </summary>
public sealed record Get2Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the agent variable
    /// </summary>
    public required string VariableId { get; init; }
}
