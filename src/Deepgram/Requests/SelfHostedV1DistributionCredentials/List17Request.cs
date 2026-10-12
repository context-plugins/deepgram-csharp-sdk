namespace Deepgram.Requests.SelfHostedV1DistributionCredentials;

/// <summary>
/// The inputs of the List17 operation.
/// </summary>
public sealed record List17Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
