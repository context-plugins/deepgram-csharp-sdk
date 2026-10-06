namespace Deepgram.Requests.VoiceAgentConfigurations;

/// <summary>
/// The inputs of the List2 operation.
/// </summary>
public sealed record List2Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
