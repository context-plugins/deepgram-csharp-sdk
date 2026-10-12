namespace Deepgram.Requests.ManageV1ProjectsBillingBalances;

/// <summary>
/// The inputs of the Get10 operation.
/// </summary>
public sealed record Get10Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// The unique identifier of the balance
    /// </summary>
    public required string BalanceId { get; init; }
}
