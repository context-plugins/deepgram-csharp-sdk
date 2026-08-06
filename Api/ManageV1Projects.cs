using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core;
using RestApi.Core.Exceptions;
using RestApi.Core.Models;
using RestApi.Core.Request;
using RestApi.Core.Response;
using RestApi.Errors;
using RestApi.Models;

namespace RestApi.Api;

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
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteProjectV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Delete3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified project
    /// </remarks>
    public Task<DeleteProjectV1Response> Delete3(string projectId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteProjectV1Response>(),
            Delete3ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Project
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="page">Navigate and return the results to retrieve specific portions of information of the response</param>
    /// <param name="limit">Number of results to return per page. Default 10. Range [1,1000]</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves information about the specified project
    /// </remarks>
    public Task<GetProjectV1Response> Get3(string projectId,
        double? page,
        double? limit = 10d,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}"),
            [new TemplateParam("project_id", projectId)],
            [new Param("limit", limit), new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectV1Response>(),
            Get3ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Leave a Project
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LeaveProjectV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="LeaveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the authenticated account from the specific project
    /// </remarks>
    public Task<LeaveProjectV1Response> Leave(string projectId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/leave"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<LeaveProjectV1Response>(),
            LeaveErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Projects
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves basic information about the projects associated with the API key
    /// </remarks>
    public Task<ListProjectsV1Response> List4(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectsV1Response>(),
            List4ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update a Project
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateProjectV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Update3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the name or other properties of an existing project
    /// </remarks>
    public Task<UpdateProjectV1Response> Update3(string projectId,
        UpdateProjectV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateProjectV1Response>(),
            Update3ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
