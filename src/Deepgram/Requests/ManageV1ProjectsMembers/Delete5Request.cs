namespace Deepgram.Requests.ManageV1ProjectsMembers;

/// <summary>
/// The inputs of the Delete5 operation.
/// </summary>
public sealed record Delete5Request
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
