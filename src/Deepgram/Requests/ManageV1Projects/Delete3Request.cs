namespace Deepgram.Requests.ManageV1Projects;

/// <summary>
/// The inputs of the Delete3 operation.
/// </summary>
public sealed record Delete3Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
