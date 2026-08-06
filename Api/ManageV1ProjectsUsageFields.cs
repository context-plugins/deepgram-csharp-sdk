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

public sealed class ManageV1ProjectsUsageFields
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsUsageFields(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// List Project Usage Fields
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="start">Start date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="end">End date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageFieldsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List12Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the features, models, tags, languages, and processing method used for requests in the specified project
    /// </remarks>
    public Task<UsageFieldsV1Response> List12(string projectId,
        DateTimeOffset? start,
        DateTimeOffset? end,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/usage/fields"),
            [new TemplateParam("project_id", projectId)],
            [new Param("start", start?.ToDate()), new Param("end", end?.ToDate())],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsageFieldsV1Response>(),
            List12ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
