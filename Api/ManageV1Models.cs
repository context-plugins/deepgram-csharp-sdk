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

public sealed class ManageV1Models
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1Models(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a specific Model
    /// </summary>
    /// <param name="modelId">The specific UUID of the model</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetModelV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns metadata for a specific public model
    /// </remarks>
    public Task<GetModelV1Response> Get5(string modelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/models/{model_id}"),
            [new TemplateParam("model_id", modelId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetModelV1Response>(),
            Get5ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Models
    /// </summary>
    /// <param name="includeOutdated">returns non-latest versions of models</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListModelsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns metadata on all the latest public models. To retrieve custom models, use Get Project Models.
    /// </remarks>
    public Task<ListModelsV1Response> List6(bool? includeOutdated,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/models"),
            [],
            [new Param("include_outdated", includeOutdated)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListModelsV1Response>(),
            List6ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
