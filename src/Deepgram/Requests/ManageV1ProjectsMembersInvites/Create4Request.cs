using Deepgram.Models;

namespace Deepgram.Requests.ManageV1ProjectsMembersInvites;

/// <summary>
/// The inputs of the Create4 operation.
/// </summary>
public sealed record Create4Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// email to invite to the project
    /// </summary>
    public CreateProjectInviteV1Request? Body { get; init; }
}
