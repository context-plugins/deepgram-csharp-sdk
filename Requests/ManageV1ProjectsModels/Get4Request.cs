namespace Deepgram.Requests.ManageV1ProjectsModels;

/// <summary>
/// The inputs of the Get4 operation.
/// </summary>
public sealed record Get4Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The specific UUID of the model
    /// </summary>
    public required string ModelId { get; init; }
}
