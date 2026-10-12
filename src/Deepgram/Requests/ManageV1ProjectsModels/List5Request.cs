namespace Deepgram.Requests.ManageV1ProjectsModels;

/// <summary>
/// The inputs of the List5 operation.
/// </summary>
public sealed record List5Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// returns non-latest versions of models
    /// </summary>
    public bool? IncludeOutdated { get; init; }
}
