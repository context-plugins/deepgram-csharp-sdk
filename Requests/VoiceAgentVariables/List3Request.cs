namespace Deepgram.Requests.VoiceAgentVariables;

/// <summary>
/// The inputs of the List3 operation.
/// </summary>
public sealed record List3Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
