using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core;
using Deepgram.Core.Exceptions;
using Deepgram.Core.Models;
using Deepgram.Core.Request;
using Deepgram.Core.Response;
using Deepgram.Errors;
using Deepgram.Models;
using Deepgram.Requests.ManageV1Projects;

namespace Deepgram.Api;

public sealed class ManageV1Projects
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1Projects(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a Project
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteProjectV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Delete3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified project
    /// </remarks>
    public Task<DeleteProjectV1Response> Delete3(Delete3Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteProjectV1Response>(),
            Delete3Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a Project
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Get3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves information about the specified project
    /// </remarks>
    public Task<GetProjectV1Response> Get3(Get3Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}"),
            [new TemplateParam("project_id", request.ProjectId)],
            [new Param("limit", request.Limit), new Param("page", request.Page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectV1Response>(),
            Get3Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Leave a Project
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LeaveProjectV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="LeaveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the authenticated account from the specific project
    /// </remarks>
    public Task<LeaveProjectV1Response> Leave(LeaveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/leave"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<LeaveProjectV1Response>(),
            LeaveError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Projects
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves basic information about the projects associated with the API key
    /// </remarks>
    public Task<ListProjectsV1Response> List4(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectsV1Response>(),
            List4Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a Project
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateProjectV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Update3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the name or other properties of an existing project
    /// </remarks>
    public Task<UpdateProjectV1Response> Update3(Update3Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateProjectV1Response>(),
            Update3Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
