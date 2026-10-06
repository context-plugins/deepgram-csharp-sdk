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
using Deepgram.Requests.VoiceAgentConfigurations;

namespace Deepgram.Api;

public sealed class VoiceAgentConfigurations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VoiceAgentConfigurations(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an Agent Configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateAgentConfigurationV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new reusable agent configuration. The <c>config</c> field must be a valid JSON string representing the <c>agent</c> block of a Settings message. The returned <c>agent_id</c> can be passed in place of the full <c>agent</c> object in future Settings messages.
    /// </remarks>
    public Task<CreateAgentConfigurationV1Response> Create(CreateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/agents"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateAgentConfigurationV1Response>(),
            CreateError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete an Agent Configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified agent configuration. Deleting an agent configuration can cause a production outage if your service references this agent UUID. Migrate all active sessions to a new configuration before deleting.
    /// </remarks>
    public Task<object> Delete(DeleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/agents/{agent_id}"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("agent_id", request.AgentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DeleteError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an Agent Configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentConfigurationV1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified agent configuration in its uninterpolated form
    /// </remarks>
    public Task<AgentConfigurationV1> Get(GetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/agents/{agent_id}"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("agent_id", request.AgentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AgentConfigurationV1>(),
            GetError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Agent Configurations
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListAgentConfigurationsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all agent configurations for the specified project. Configurations are returned in their uninterpolated form—template variable placeholders appear as-is rather than with their substituted values.
    /// </remarks>
    public Task<ListAgentConfigurationsV1Response> List2(List2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/agents"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListAgentConfigurationsV1Response>(),
            List2Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update Agent Metadata
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentConfigurationV1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the metadata associated with an agent configuration. The config itself is immutable—to change the configuration, delete the existing agent and create a new one.
    /// </remarks>
    public Task<AgentConfigurationV1> Update(UpdateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/agents/{agent_id}"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("agent_id", request.AgentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AgentConfigurationV1>(),
            UpdateError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
