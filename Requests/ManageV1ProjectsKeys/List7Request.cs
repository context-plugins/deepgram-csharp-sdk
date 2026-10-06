using Deepgram.Models.Enums;

namespace Deepgram.Requests.ManageV1ProjectsKeys;

/// <summary>
/// The inputs of the List7 operation.
/// </summary>
public sealed record List7Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Only return keys with a specific status
    /// </summary>
    public V1ProjectsProjectIdKeysGetParametersStatus? Status { get; init; }
}
