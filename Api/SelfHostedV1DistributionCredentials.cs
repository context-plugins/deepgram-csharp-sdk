using System;
using System.Collections.Generic;
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
using RestApi.Models.Enums;

namespace RestApi.Api;

public sealed class SelfHostedV1DistributionCredentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal SelfHostedV1DistributionCredentials(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create a Project Self-Hosted Distribution Credential
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="scopes">List of permission scopes for the credentials</param>
    /// <param name="provider">The provider of the distribution service</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Create5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a set of distribution credentials for the specified project
    /// </remarks>
    public Task<CreateProjectDistributionCredentialsV1Response> Create5(string projectId,
        IReadOnlyList<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>? scopes,
        V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider? provider,
        string authorization,
        CreateProjectDistributionCredentialsV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/self-hosted/distribution/credentials"),
            [new TemplateParam("project_id", projectId)],
            [new Param("scopes", scopes), new Param("provider", provider)],
            [new HeaderParam("Authorization", authorization), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateProjectDistributionCredentialsV1Response>(),
            Create5ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a Project Self-Hosted Distribution Credential
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="distributionCredentialsId">The UUID of the distribution credentials</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Delete7Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a set of distribution credentials for the specified project
    /// </remarks>
    public Task<GetProjectDistributionCredentialsV1Response> Delete7(string projectId,
        string distributionCredentialsId,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/self-hosted/distribution/credentials/{distribution_credentials_id}"),
            [new TemplateParam("project_id", projectId),
                new TemplateParam("distribution_credentials_id", distributionCredentialsId)],
            [],
            [new HeaderParam("Authorization", authorization), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectDistributionCredentialsV1Response>(),
            Delete7ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Project Self-Hosted Distribution Credential
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="distributionCredentialsId">The UUID of the distribution credentials</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get11Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a set of distribution credentials for the specified project
    /// </remarks>
    public Task<GetProjectDistributionCredentialsV1Response> Get11(string projectId,
        string distributionCredentialsId,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/self-hosted/distribution/credentials/{distribution_credentials_id}"),
            [new TemplateParam("project_id", projectId),
                new TemplateParam("distribution_credentials_id", distributionCredentialsId)],
            [],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectDistributionCredentialsV1Response>(),
            Get11ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List Project Self-Hosted Distribution Credentials
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List17Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists sets of distribution credentials for the specified project
    /// </remarks>
    public Task<ListProjectDistributionCredentialsV1Response> List17(string projectId,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/self-hosted/distribution/credentials"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectDistributionCredentialsV1Response>(),
            List17ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
