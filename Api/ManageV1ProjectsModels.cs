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
using Deepgram.Models.AnyOf;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsModels
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsModels(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a Project Model
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="modelId">The specific UUID of the model</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetModelV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns metadata for a specific model
    /// </remarks>
    public Task<GetModelV1Response> Get4(string projectId,
        string modelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/models/{model_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("model_id", modelId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetModelV1Response>(),
            Get4ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Project Models
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="includeOutdated">returns non-latest versions of models</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListModelsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns metadata on all the latest models that a specific project has access to, including non-public models
    /// </remarks>
    public Task<ListModelsV1Response> List5(string projectId,
        bool? includeOutdated,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/models"),
            [new TemplateParam("project_id", projectId)],
            [new Param("include_outdated", includeOutdated)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListModelsV1Response>(),
            List5ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
