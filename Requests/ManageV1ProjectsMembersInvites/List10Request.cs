namespace Deepgram.Requests.ManageV1ProjectsMembersInvites;

/// <summary>
/// The inputs of the List10 operation.
/// </summary>
public sealed record List10Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
