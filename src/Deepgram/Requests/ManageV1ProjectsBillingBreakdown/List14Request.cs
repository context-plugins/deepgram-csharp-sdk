using System;
using System.Collections.Generic;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.ManageV1ProjectsBillingBreakdown;

/// <summary>
/// The inputs of the List14 operation.
/// </summary>
public sealed record List14Request
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

    /// <summary>
    /// Filter for requests where a specific accessor was used
    /// </summary>
    public string? Accessor { get; init; }

    /// <summary>
    /// Filter for requests where a specific deployment was used
    /// </summary>
    public V1ProjectsProjectIdBillingBreakdownGetParametersDeployment? Deployment { get; init; }

    /// <summary>
    /// Filter for requests where a specific tag was used
    /// </summary>
    public string? Tag { get; init; }

    /// <summary>
    /// Filter requests by line item (e.g. streaming::nova-3)
    /// </summary>
    public string? LineItem { get; init; }

    /// <summary>
    /// Group billing breakdown by one or more dimensions (accessor, deployment, line_item, tags)
    /// </summary>
    public IReadOnlyList<V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>? Grouping { get; init; }
}
