using System;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.ManageV1ProjectsRequests;

/// <summary>
/// The inputs of the List11 operation.
/// </summary>
public sealed record List11Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Start date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM
    /// </summary>
    public DateTimeOffset? Start { get; init; }

    /// <summary>
    /// End date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM
    /// </summary>
    public DateTimeOffset? End { get; init; }

    /// <summary>
    /// Number of results to return per page. Default 10. Range [1,1000]
    /// </summary>
    public double Limit { get; init; } = 10d;

    /// <summary>
    /// Navigate and return the results to retrieve specific portions of information of the response
    /// </summary>
    public double? Page { get; init; }

    /// <summary>
    /// Filter for requests where a specific accessor was used
    /// </summary>
    public string? Accessor { get; init; }

    /// <summary>
    /// Filter for a specific request id
    /// </summary>
    public string? RequestId { get; init; }

    /// <summary>
    /// Filter for requests where a specific deployment was used
    /// </summary>
    public V1ProjectsProjectIdRequestsGetParametersDeployment? Deployment { get; init; }

    /// <summary>
    /// Filter for requests where a specific endpoint was used
    /// </summary>
    public V1ProjectsProjectIdRequestsGetParametersEndpoint? Endpoint { get; init; }

    /// <summary>
    /// Filter for requests where a specific method was used
    /// </summary>
    public V1ProjectsProjectIdRequestsGetParametersMethod? Method { get; init; }

    /// <summary>
    /// Filter for requests that succeeded (status code &lt; 300) or failed (status code &gt;=400)
    /// </summary>
    public V1ProjectsProjectIdRequestsGetParametersStatus? Status { get; init; }
}
