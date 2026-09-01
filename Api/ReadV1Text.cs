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
using Deepgram.Models.AnyOf;
using Deepgram.Models.Enums;

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
    /// <param name="callback">URL to which we'll make the callback request</param>
    /// <param name="callbackMethod">HTTP method by which the callback request will be made</param>
    /// <param name="summarize">Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only.</param>
    /// <param name="tag">Label your requests for the purpose of identification during usage reporting</param>
    /// <param name="customTopic">Custom topics you want the model to detect within your input audio or text if present Submit up to <c>100</c>.</param>
    /// <param name="customTopicMode">Sets how the model will interpret strings submitted to the <c>custom_topic</c> param. When <c>strict</c>, the model will only return topics submitted using the <c>custom_topic</c> param. When <c>extended</c>, the model will return its own detected topics in addition to those submitted using the <c>custom_topic</c> param</param>
    /// <param name="customIntent">Custom intents you want the model to detect within your input audio if present</param>
    /// <param name="customIntentMode">Sets how the model will interpret intents submitted to the <c>custom_intent</c> param. When <c>strict</c>, the model will only return intents submitted using the <c>custom_intent</c> param. When <c>extended</c>, the model will return its own detected intents in the <c>custom_intent</c> param.</param>
    /// <param name="body"></param>
    /// <param name="sentiment">Recognizes the sentiment throughout a transcript or text</param>
    /// <param name="topics">Detect topics throughout a transcript or text</param>
    /// <param name="intents">Recognizes speaker intent throughout a transcript or text</param>
    /// <param name="language">The <see href="https://tools.ietf.org/html/bcp47">BCP-47 language tag</see> that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReadV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AnalyzeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Analyze text content using Deepgrams text analysis API
    /// </remarks>
    public Task<ReadV1Response> Analyze(string? callback,
        V1ListenPostParametersCallbackMethod? callbackMethod,
        V1ReadPostParametersSummarize? summarize,
        V1ReadPostParametersTag? tag,
        V1ReadPostParametersCustomTopic? customTopic,
        V1ListenPostParametersCustomTopicMode? customTopicMode,
        V1ReadPostParametersCustomIntent? customIntent,
        V1ListenPostParametersCustomTopicMode? customIntentMode,
        ReadV1Request? body,
        bool? sentiment = false,
        bool? topics = false,
        bool? intents = false,
        string? language = "en",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/read"),
            [],
            [new Param("callback", callback),
                new Param("callback_method", callbackMethod),
                new Param("sentiment", sentiment),
                new Param("summarize", summarize),
                new Param("tag", tag),
                new Param("topics", topics),
                new Param("custom_topic", customTopic),
                new Param("custom_topic_mode", customTopicMode),
                new Param("intents", intents),
                new Param("custom_intent", customIntent),
                new Param("custom_intent_mode", customIntentMode),
                new Param("language", language)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ReadV1Response>(),
            AnalyzeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
