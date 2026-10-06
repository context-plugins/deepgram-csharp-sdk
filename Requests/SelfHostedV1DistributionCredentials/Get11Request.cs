namespace Deepgram.Requests.SelfHostedV1DistributionCredentials;

/// <summary>
/// The inputs of the Get11 operation.
/// </summary>
public sealed record Get11Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The UUID of the distribution credentials
    /// </summary>
    public required string DistributionCredentialsId { get; init; }
}
