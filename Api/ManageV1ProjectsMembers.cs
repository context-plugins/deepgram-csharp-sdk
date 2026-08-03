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

public sealed class ManageV1ProjectsMembers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ManageV1ProjectsMembers(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete a Project Member
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="memberId">The unique identifier of the Member</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteProjectMemberV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Delete5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a member from the project using their unique member ID
    /// </remarks>
    public Task<DeleteProjectMemberV1Response> Delete5(string projectId,
        string memberId,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/members/{member_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("member_id", memberId)],
            [],
            [new HeaderParam("Authorization", authorization), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteProjectMemberV1Response>(),
            Delete5ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List Project Members
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectMembersV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List8Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of members for a given project
    /// </remarks>
    public Task<ListProjectMembersV1Response> List8(string projectId,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/members"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectMembersV1Response>(),
            List8ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
