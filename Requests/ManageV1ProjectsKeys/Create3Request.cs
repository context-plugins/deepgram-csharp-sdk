using Deepgram.Models.AnyOf;

namespace Deepgram.Requests.ManageV1ProjectsKeys;

/// <summary>
/// The inputs of the Create3 operation.
/// </summary>
public sealed record Create3Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// API key settings
    /// </summary>
    public CreateKeyV1Request? Body { get; init; }
}
