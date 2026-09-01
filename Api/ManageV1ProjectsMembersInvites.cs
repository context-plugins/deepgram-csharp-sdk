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
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateProjectInviteV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Create4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates an invite for a specific project
    /// </remarks>
    public Task<CreateProjectInviteV1Response> Create4(string projectId,
        CreateProjectInviteV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/invites"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateProjectInviteV1Response>(),
            Create4ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a Project Invite
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="email">The email address of the member</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteProjectInviteV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Delete6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an invite for a specific project
    /// </remarks>
    public Task<DeleteProjectInviteV1Response> Delete6(string projectId,
        string email,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/invites/{email}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("email", email)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteProjectInviteV1Response>(),
            Delete6ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Project Invites
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectInvitesV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List10Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a list of invites for a specific project
    /// </remarks>
    public Task<ListProjectInvitesV1Response> List10(string projectId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/invites"),
            [new TemplateParam("project_id", projectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectInvitesV1Response>(),
            List10ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
