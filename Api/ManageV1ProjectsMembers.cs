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
using Deepgram.Requests.ManageV1ProjectsMembers;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsMembers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsMembers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a Project Member
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteProjectMemberV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Delete5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a member from the project using their unique member ID
    /// </remarks>
    public Task<DeleteProjectMemberV1Response> Delete5(Delete5Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/members/{member_id}"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("member_id", request.MemberId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteProjectMemberV1Response>(),
            Delete5Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Project Members
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectMembersV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List8Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of members for a given project
    /// </remarks>
    public Task<ListProjectMembersV1Response> List8(List8Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/members"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectMembersV1Response>(),
            List8Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
