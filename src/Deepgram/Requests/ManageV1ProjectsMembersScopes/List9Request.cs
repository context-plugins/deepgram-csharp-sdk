namespace Deepgram.Requests.ManageV1ProjectsMembersScopes;

/// <summary>
/// The inputs of the List9 operation.
/// </summary>
public sealed record List9Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the Member
    /// </summary>
    public required string MemberId { get; init; }
}
