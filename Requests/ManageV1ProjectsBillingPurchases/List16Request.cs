namespace Deepgram.Requests.ManageV1ProjectsBillingPurchases;

/// <summary>
/// The inputs of the List16 operation.
/// </summary>
public sealed record List16Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Number of results to return per page. Default 10. Range [1,1000]
    /// </summary>
    public double Limit { get; init; } = 10d;
}
