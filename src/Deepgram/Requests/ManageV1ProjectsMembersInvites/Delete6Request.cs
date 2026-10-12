namespace Deepgram.Requests.ManageV1ProjectsMembersInvites;

/// <summary>
/// The inputs of the Delete6 operation.
/// </summary>
public sealed record Delete6Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The email address of the member
    /// </summary>
    public required string Email { get; init; }
}
