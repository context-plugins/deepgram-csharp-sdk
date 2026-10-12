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
using Deepgram.Models.AnyOf;
using Deepgram.Requests.ListenV1Media;

namespace Deepgram.Api;

public sealed class ListenV1Media
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ListenV1Media(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Transcribe and analyze pre-recorded audio and video
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListenV1MediaTranscribeResponse200"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TranscribeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transcribe audio and video using Deepgram's speech-to-text REST API
    /// </remarks>
    public Task<ListenV1MediaTranscribeResponse200> Transcribe(TranscribeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/listen"),
            [],
            [
                new Param("callback", request.Callback),
                new Param("callback_method", request.CallbackMethod),
                new Param("extra", request.Extra),
                new Param("sentiment", request.Sentiment),
                new Param("summarize", request.Summarize),
                new Param("tag", request.Tag),
                new Param("topics", request.Topics),
                new Param("custom_topic", request.CustomTopic),
                new Param("custom_topic_mode", request.CustomTopicMode),
                new Param("intents", request.Intents),
                new Param("custom_intent", request.CustomIntent),
                new Param("custom_intent_mode", request.CustomIntentMode),
                new Param("detect_entities", request.DetectEntities),
                new Param("detect_language", request.DetectLanguage),
                new Param("diarize", request.Diarize),
                new Param("diarize_model", request.DiarizeModel),
                new Param("dictation", request.Dictation),
                new Param("encoding", request.Encoding),
                new Param("filler_words", request.FillerWords),
                new Param("keyterm", request.Keyterm),
                new Param("keywords", request.Keywords),
                new Param("language", request.Language),
                new Param("measurements", request.Measurements),
                new Param("model", request.Model),
                new Param("multichannel", request.Multichannel),
                new Param("numerals", request.Numerals),
                new Param("paragraphs", request.Paragraphs),
                new Param("profanity_filter", request.ProfanityFilter),
                new Param("punctuate", request.Punctuate),
                new Param("redact", request.Redact),
                new Param("replace", request.Replace),
                new Param("search", request.Search),
                new Param("smart_format", request.SmartFormat),
                new Param("utterances", request.Utterances),
                new Param("utt_split", request.UttSplit),
                new Param("version", request.Version),
                new Param("mip_opt_out", request.MipOptOut),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ListenV1MediaTranscribeResponse200>(),
            TranscribeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
