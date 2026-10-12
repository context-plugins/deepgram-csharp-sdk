namespace Deepgram.Requests.ManageV1ProjectsBillingBalances;

/// <summary>
/// The inputs of the List13 operation.
/// </summary>
public sealed record List13Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }
}
