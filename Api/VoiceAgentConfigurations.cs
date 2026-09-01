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
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateAgentConfigurationV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new reusable agent configuration. The <c>config</c> field must be a valid JSON string representing the <c>agent</c> block of a Settings message. The returned <c>agent_id</c> can be passed in place of the full <c>agent</c> object in future Settings messages.
    /// </remarks>
    public Task<CreateAgentConfigurationV1Response> Create(string projectId,
        CreateAgentConfigurationV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agents"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateAgentConfigurationV1Response>(),
            CreateErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an Agent Configuration
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="agentId">The unique identifier of the agent configuration</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified agent configuration. Deleting an agent configuration can cause a production outage if your service references this agent UUID. Migrate all active sessions to a new configuration before deleting.
    /// </remarks>
    public Task<object> Delete(string projectId,
        string agentId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agents/{agent_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("agent_id", agentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DeleteErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get an Agent Configuration
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="agentId">The unique identifier of the agent configuration</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentConfigurationV1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified agent configuration in its uninterpolated form
    /// </remarks>
    public Task<AgentConfigurationV1> Get(string projectId,
        string agentId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agents/{agent_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("agent_id", agentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AgentConfigurationV1>(),
            GetErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Agent Configurations
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListAgentConfigurationsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all agent configurations for the specified project. Configurations are returned in their uninterpolated form—template variable placeholders appear as-is rather than with their substituted values.
    /// </remarks>
    public Task<ListAgentConfigurationsV1Response> List2(string projectId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agents"),
            [new TemplateParam("project_id", projectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListAgentConfigurationsV1Response>(),
            List2ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update Agent Metadata
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="agentId">The unique identifier of the agent configuration</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentConfigurationV1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the metadata associated with an agent configuration. The config itself is immutable—to change the configuration, delete the existing agent and create a new one.
    /// </remarks>
    public Task<AgentConfigurationV1> Update(string projectId,
        string agentId,
        UpdateAgentMetadataV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agents/{agent_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("agent_id", agentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<AgentConfigurationV1>(),
            UpdateErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
