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
using Deepgram.Requests.ManageV1ProjectsMembersScopes;

namespace Deepgram.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectMemberScopesV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List9Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of scopes for a specific member
    /// </remarks>
    public Task<ListProjectMemberScopesV1Response> List9(List9Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/members/{member_id}/scopes"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("member_id", request.MemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectMemberScopesV1Response>(),
            List9Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update Project Member Scopes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateProjectMemberScopesV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Update4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the scopes for a specific member
    /// </remarks>
    public Task<UpdateProjectMemberScopesV1Response> Update4(Update4Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/members/{member_id}/scopes"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("member_id", request.MemberId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateProjectMemberScopesV1Response>(),
            Update4Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
