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
using Deepgram.Requests.ManageV1ProjectsMembersInvites;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsMembersInvites
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsMembersInvites(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a Project Invite
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateProjectInviteV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Create4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates an invite for a specific project
    /// </remarks>
    public Task<CreateProjectInviteV1Response> Create4(Create4Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/invites"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateProjectInviteV1Response>(),
            Create4Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a Project Invite
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteProjectInviteV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Delete6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an invite for a specific project
    /// </remarks>
    public Task<DeleteProjectInviteV1Response> Delete6(Delete6Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/invites/{email}"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("email", request.Email)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteProjectInviteV1Response>(),
            Delete6Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Project Invites
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectInvitesV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List10Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a list of invites for a specific project
    /// </remarks>
    public Task<ListProjectInvitesV1Response> List10(List10Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/invites"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectInvitesV1Response>(),
            List10Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
