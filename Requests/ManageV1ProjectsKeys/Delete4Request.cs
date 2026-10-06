namespace Deepgram.Requests.ManageV1ProjectsKeys;

/// <summary>
/// The inputs of the Delete4 operation.
/// </summary>
public sealed record Delete4Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the API key
    /// </summary>
    public required string KeyId { get; init; }
}
