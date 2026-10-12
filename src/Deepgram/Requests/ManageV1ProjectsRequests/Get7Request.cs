namespace Deepgram.Requests.ManageV1ProjectsRequests;

/// <summary>
/// The inputs of the Get7 operation.
/// </summary>
public sealed record Get7Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the request
    /// </summary>
    public required string RequestId { get; init; }
}
