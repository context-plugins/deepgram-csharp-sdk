using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core;
using RestApi.Core.Exceptions;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Core.Request;
using RestApi.Core.Response;
using RestApi.Errors;
using RestApi.Models;
using RestApi.Models.Enums;

namespace RestApi.Api;

public sealed class ManageV1ProjectsBillingBreakdown
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsBillingBreakdown(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Project Billing Breakdown
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="start">Start date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="end">End date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="accessor">Filter for requests where a specific accessor was used</param>
    /// <param name="deployment">Filter for requests where a specific deployment was used</param>
    /// <param name="tag">Filter for requests where a specific tag was used</param>
    /// <param name="lineItem">Filter requests by line item (e.g. streaming::nova-3)</param>
    /// <param name="grouping">Group billing breakdown by one or more dimensions (accessor, deployment, line_item, tags)</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BillingBreakdownV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List14Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the billing summary for a specific project, with various filter options or by grouping options.
    /// </remarks>
    public Task<BillingBreakdownV1Response> List14(string projectId,
        DateTimeOffset? start,
        DateTimeOffset? end,
        string? accessor,
        V1ProjectsProjectIdBillingBreakdownGetParametersDeployment? deployment,
        string? tag,
        string? lineItem,
        IReadOnlyList<V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>? grouping,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/billing/breakdown"),
            [new TemplateParam("project_id", projectId)],
            [new Param("start", start?.ToDate()),
                new Param("end", end?.ToDate()),
                new Param("accessor", accessor),
                new Param("deployment", deployment),
                new Param("tag", tag),
                new Param("line_item", lineItem),
                new Param("grouping", grouping)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BillingBreakdownV1Response>(),
            List14ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
