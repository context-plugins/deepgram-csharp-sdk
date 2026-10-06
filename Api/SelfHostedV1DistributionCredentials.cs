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
using Deepgram.Requests.SelfHostedV1DistributionCredentials;

namespace Deepgram.Api;

public sealed class SelfHostedV1DistributionCredentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SelfHostedV1DistributionCredentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a Project Self-Hosted Distribution Credential
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Create5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a set of distribution credentials for the specified project
    /// </remarks>
    public Task<CreateProjectDistributionCredentialsV1Response> Create5(Create5Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/self-hosted/distribution/credentials"),
            [new TemplateParam("project_id", request.ProjectId)],
            [new Param("scopes", request.Scopes), new Param("provider", request.Provider)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateProjectDistributionCredentialsV1Response>(),
            Create5Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a Project Self-Hosted Distribution Credential
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Delete7Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a set of distribution credentials for the specified project
    /// </remarks>
    public Task<GetProjectDistributionCredentialsV1Response> Delete7(Delete7Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/v1/projects/{project_id}/self-hosted/distribution/credentials/{distribution_credentials_id}"),
            [
                new TemplateParam("project_id", request.ProjectId),
                new TemplateParam("distribution_credentials_id", request.DistributionCredentialsId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectDistributionCredentialsV1Response>(),
            Delete7Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a Project Self-Hosted Distribution Credential
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Get11Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a set of distribution credentials for the specified project
    /// </remarks>
    public Task<GetProjectDistributionCredentialsV1Response> Get11(Get11Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/v1/projects/{project_id}/self-hosted/distribution/credentials/{distribution_credentials_id}"),
            [
                new TemplateParam("project_id", request.ProjectId),
                new TemplateParam("distribution_credentials_id", request.DistributionCredentialsId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectDistributionCredentialsV1Response>(),
            Get11Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Project Self-Hosted Distribution Credentials
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectDistributionCredentialsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List17Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists sets of distribution credentials for the specified project
    /// </remarks>
    public Task<ListProjectDistributionCredentialsV1Response> List17(List17Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/self-hosted/distribution/credentials"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectDistributionCredentialsV1Response>(),
            List17Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
