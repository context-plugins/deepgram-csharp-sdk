namespace Deepgram.Requests.ManageV1ProjectsMembers;

/// <summary>
/// The inputs of the List8 operation.
/// </summary>
public sealed record List8Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
