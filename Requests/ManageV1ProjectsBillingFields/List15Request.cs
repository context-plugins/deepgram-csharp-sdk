using System;

namespace Deepgram.Requests.ManageV1ProjectsBillingFields;

/// <summary>
/// The inputs of the List15 operation.
/// </summary>
public sealed record List15Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Start date of the requested date range. Format accepted is YYYY-MM-DD
    /// </summary>
    public DateTimeOffset? Start { get; init; }

    /// <summary>
    /// End date of the requested date range. Format accepted is YYYY-MM-DD
    /// </summary>
    public DateTimeOffset? End { get; init; }
}
