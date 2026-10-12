using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core;
using Deepgram.Core.Exceptions;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Core.Request;
using Deepgram.Core.Response;
using Deepgram.Errors;
using Deepgram.Models;
using Deepgram.Requests.ManageV1ProjectsRequests;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsRequests
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsRequests(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a Project Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectRequestV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Get7Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific request for a specific project
    /// </remarks>
    public Task<GetProjectRequestV1Response> Get7(Get7Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/requests/{request_id}"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("request_id", request.RequestId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectRequestV1Response>(),
            Get7Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Project Requests
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectRequestsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List11Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a list of requests for a specific project
    /// </remarks>
    public Task<ListProjectRequestsV1Response> List11(List11Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/requests"),
            [new TemplateParam("project_id", request.ProjectId)],
            [
                new Param("start", request.Start?.ToIso8601()),
                new Param("end", request.End?.ToIso8601()),
                new Param("limit", request.Limit),
                new Param("page", request.Page),
                new Param("accessor", request.Accessor),
                new Param("request_id", request.RequestId),
                new Param("deployment", request.Deployment),
                new Param("endpoint", request.Endpoint),
                new Param("method", request.Method),
                new Param("status", request.Status),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectRequestsV1Response>(),
            List11Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
