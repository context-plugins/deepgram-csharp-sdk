namespace Deepgram.Requests.ManageV1Models;

/// <summary>
/// The inputs of the Get5 operation.
/// </summary>
public sealed record Get5Request
{
    /// <summary>
    /// The specific UUID of the model
    /// </summary>
    public required string ModelId { get; init; }
}
