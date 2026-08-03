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
using RestApi.Models.Enums;

namespace RestApi.Api;

public sealed class ManageV1ProjectsRequests
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ManageV1ProjectsRequests(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get a Project Request
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="requestId">The unique identifier of the request</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectRequestV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get7Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific request for a specific project
    /// </remarks>
    public Task<GetProjectRequestV1Response> Get7(string projectId,
        string requestId,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/requests/{request_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("request_id", requestId)],
            [],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectRequestV1Response>(),
            Get7ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List Project Requests
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="start">Start date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM</param>
    /// <param name="end">End date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM</param>
    /// <param name="page">Navigate and return the results to retrieve specific portions of information of the response</param>
    /// <param name="accessor">Filter for requests where a specific accessor was used</param>
    /// <param name="requestId">Filter for a specific request id</param>
    /// <param name="deployment">Filter for requests where a specific deployment was used</param>
    /// <param name="endpoint">Filter for requests where a specific endpoint was used</param>
    /// <param name="method">Filter for requests where a specific method was used</param>
    /// <param name="status">Filter for requests that succeeded (status code &lt; 300) or failed (status code &gt;=400)</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="limit">Number of results to return per page. Default 10. Range [1,1000]</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectRequestsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List11Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a list of requests for a specific project
    /// </remarks>
    public Task<ListProjectRequestsV1Response> List11(string projectId,
        DateTimeOffset? start,
        DateTimeOffset? end,
        double? page,
        string? accessor,
        string? requestId,
        V1ProjectsProjectIdRequestsGetParametersDeployment? deployment,
        V1ProjectsProjectIdRequestsGetParametersEndpoint? endpoint,
        V1ProjectsProjectIdRequestsGetParametersMethod? method,
        V1ProjectsProjectIdRequestsGetParametersStatus? status,
        string authorization,
        double? limit = 10d,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/requests"),
            [new TemplateParam("project_id", projectId)],
            [new Param("start", start?.ToIso8601()),
                new Param("end", end?.ToIso8601()),
                new Param("limit", limit),
                new Param("page", page),
                new Param("accessor", accessor),
                new Param("request_id", requestId),
                new Param("deployment", deployment),
                new Param("endpoint", endpoint),
                new Param("method", method),
                new Param("status", status)],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectRequestsV1Response>(),
            List11ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
