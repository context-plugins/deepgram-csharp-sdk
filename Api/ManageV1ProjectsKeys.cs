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
using Deepgram.Models.AnyOf;
using Deepgram.Models.Enums;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsKeys
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsKeys(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a Project Key
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateKeyV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Create3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new API key with specified settings for the project
    /// </remarks>
    public Task<CreateKeyV1Response> Create3(string projectId,
        CreateKeyV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/keys"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateKeyV1Response>(),
            Create3ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a Project Key
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="keyId">The unique identifier of the API key</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteProjectKeyV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Delete4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an API key for a specific project
    /// </remarks>
    public Task<DeleteProjectKeyV1Response> Delete4(string projectId,
        string keyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/keys/{key_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("key_id", keyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteProjectKeyV1Response>(),
            Delete4ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Project Key
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="keyId">The unique identifier of the API key</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectKeyV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves information about a specified API key
    /// </remarks>
    public Task<GetProjectKeyV1Response> Get6(string projectId,
        string keyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/keys/{key_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("key_id", keyId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectKeyV1Response>(),
            Get6ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Project Keys
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="status">Only return keys with a specific status</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectKeysV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List7Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves all API keys associated with the specified project
    /// </remarks>
    public Task<ListProjectKeysV1Response> List7(string projectId,
        V1ProjectsProjectIdKeysGetParametersStatus? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/keys"),
            [new TemplateParam("project_id", projectId)],
            [new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectKeysV1Response>(),
            List7ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
