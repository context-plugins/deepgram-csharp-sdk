using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core;
using RestApi.Core.Exceptions;
using RestApi.Core.Request;
using RestApi.Core.Response;
using RestApi.Errors;
using RestApi.Models;

namespace RestApi.Api;

public sealed class AgentV1SettingsThinkModels
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal AgentV1SettingsThinkModels(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List Agent Think Models
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AgentThinkModelsV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the available think models that can be used for AI agent processing
    /// </remarks>
    public Task<AgentThinkModelsV1Response> List(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/agent/settings/think/models"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AgentThinkModelsV1Response>(),
            ListErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
