using Deepgram.Models;

namespace Deepgram.Requests.ManageV1ProjectsMembersScopes;

/// <summary>
/// The inputs of the Update4 operation.
/// </summary>
public sealed record Update4Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the Member
    /// </summary>
    public required string MemberId { get; init; }

    /// <summary>
    /// A scope to update
    /// </summary>
    public UpdateProjectMemberScopesV1Request? Body { get; init; }
}
