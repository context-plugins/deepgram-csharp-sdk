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

    internal ManageV1ProjectsUsageFields(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List Project Usage Fields
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="start">Start date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="end">End date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
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
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/usage/fields"),
            [new TemplateParam("project_id", projectId)],
            [new Param("start", start?.ToDate()), new Param("end", end?.ToDate())],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsageFieldsV1Response>(),
            List12ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
