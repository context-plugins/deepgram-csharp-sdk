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

public sealed class VoiceAgentVariables
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VoiceAgentVariables(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an Agent Variable
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentVariableV1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Create2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new template variable. Variables follow the <c>DG_&lt;VARIABLE_NAME&gt;</c> naming format and can substitute any JSON value in an agent configuration.
    /// </remarks>
    public Task<AgentVariableV1> Create2(string projectId,
        CreateAgentVariableV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agent-variables"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AgentVariableV1>(),
            Create2ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an Agent Variable
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="variableId">The unique identifier of the agent variable</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Delete2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified template variable
    /// </remarks>
    public Task<object> Delete2(string projectId,
        string variableId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agent-variables/{variable_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("variable_id", variableId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            Delete2ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get an Agent Variable
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="variableId">The unique identifier of the agent variable</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentVariableV1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified template variable
    /// </remarks>
    public Task<AgentVariableV1> Get2(string projectId,
        string variableId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agent-variables/{variable_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("variable_id", variableId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AgentVariableV1>(),
            Get2ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Agent Variables
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListAgentVariablesV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all template variables for the specified project
    /// </remarks>
    public Task<ListAgentVariablesV1Response> List3(string projectId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agent-variables"),
            [new TemplateParam("project_id", projectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListAgentVariablesV1Response>(),
            List3ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update an Agent Variable
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="variableId">The unique identifier of the agent variable</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentVariableV1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Update2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the value of an existing template variable
    /// </remarks>
    public Task<AgentVariableV1> Update2(string projectId,
        string variableId,
        UpdateAgentVariableV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/agent-variables/{variable_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("variable_id", variableId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<AgentVariableV1>(),
            Update2ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
