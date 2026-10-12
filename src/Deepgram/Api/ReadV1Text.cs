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
using Deepgram.Requests.ReadV1Text;

namespace Deepgram.Api;

public sealed class ReadV1Text
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ReadV1Text(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Analyze text content
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReadV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AnalyzeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Analyze text content using Deepgrams text analysis API
    /// </remarks>
    public Task<ReadV1Response> Analyze(AnalyzeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/read"),
            [],
            [
                new Param("callback", request.Callback),
                new Param("callback_method", request.CallbackMethod),
                new Param("sentiment", request.Sentiment),
                new Param("summarize", request.Summarize),
                new Param("tag", request.Tag),
                new Param("topics", request.Topics),
                new Param("custom_topic", request.CustomTopic),
                new Param("custom_topic_mode", request.CustomTopicMode),
                new Param("intents", request.Intents),
                new Param("custom_intent", request.CustomIntent),
                new Param("custom_intent_mode", request.CustomIntentMode),
                new Param("language", request.Language),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ReadV1Response>(),
            AnalyzeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
