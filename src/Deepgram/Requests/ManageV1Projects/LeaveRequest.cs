namespace Deepgram.Requests.ManageV1Projects;

/// <summary>
/// The inputs of the Leave operation.
/// </summary>
public sealed record LeaveRequest
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
