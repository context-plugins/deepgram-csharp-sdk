namespace Deepgram.Requests.ManageV1Models;

/// <summary>
/// The inputs of the List6 operation.
/// </summary>
public sealed record List6Request
{
    /// <summary>
    /// returns non-latest versions of models
    /// </summary>
    public bool? IncludeOutdated { get; init; }
}
