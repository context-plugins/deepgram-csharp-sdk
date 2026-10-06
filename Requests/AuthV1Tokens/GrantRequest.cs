using Deepgram.Models;

namespace Deepgram.Requests.AuthV1Tokens;

/// <summary>
/// The inputs of the Grant operation.
/// </summary>
public sealed record GrantRequest
{
    /// <summary>
    /// Time to live settings
    /// </summary>
    public GrantV1Request? Body { get; init; }
}
