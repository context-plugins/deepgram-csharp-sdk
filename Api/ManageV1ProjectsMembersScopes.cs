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

public sealed class ManageV1ProjectsMembersScopes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsMembersScopes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// List Project Member Scopes
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="memberId">The unique identifier of the Member</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectMemberScopesV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List9Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of scopes for a specific member
    /// </remarks>
    public Task<ListProjectMemberScopesV1Response> List9(string projectId,
        string memberId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/members/{member_id}/scopes"),
            [new TemplateParam("project_id", projectId), new TemplateParam("member_id", memberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectMemberScopesV1Response>(),
            List9ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update Project Member Scopes
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="memberId">The unique identifier of the Member</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateProjectMemberScopesV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Update4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the scopes for a specific member
    /// </remarks>
    public Task<UpdateProjectMemberScopesV1Response> Update4(string projectId,
        string memberId,
        UpdateProjectMemberScopesV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/members/{member_id}/scopes"),
            [new TemplateParam("project_id", projectId), new TemplateParam("member_id", memberId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateProjectMemberScopesV1Response>(),
            Update4ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
