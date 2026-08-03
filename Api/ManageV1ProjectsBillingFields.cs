using System;
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

namespace RestApi.Api;

public sealed class ManageV1ProjectsBillingFields
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ManageV1ProjectsBillingFields(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List Project Billing Fields
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="start">Start date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="end">End date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBillingFieldsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List15Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the accessors, deployment types, tags, and line items used for billing data in the specified time period. Use this endpoint if you want to filter your results from the Billing Breakdown endpoint and want to know what filters are available.
    /// </remarks>
    public Task<ListBillingFieldsV1Response> List15(string projectId,
        DateTimeOffset? start,
        DateTimeOffset? end,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/billing/fields"),
            [new TemplateParam("project_id", projectId)],
            [new Param("start", start?.ToDate()), new Param("end", end?.ToDate())],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBillingFieldsV1Response>(),
            List15ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
