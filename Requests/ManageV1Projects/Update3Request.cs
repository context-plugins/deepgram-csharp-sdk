using Deepgram.Models;

namespace Deepgram.Requests.ManageV1Projects;

/// <summary>
/// The inputs of the Update3 operation.
/// </summary>
public sealed record Update3Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The name of the project
    /// </summary>
    public UpdateProjectV1Request? Body { get; init; }
}
