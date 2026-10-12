using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core;
using Deepgram.Core.Exceptions;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Core.Request;
using Deepgram.Core.Response;
using Deepgram.Errors;
using Deepgram.Models;
using Deepgram.Requests.ManageV1ProjectsUsage;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsUsage
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsUsage(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Project Usage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Get8Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the usage for a specific project. Use Get Project Usage Breakdown for a more comprehensive usage summary.
    /// </remarks>
    public Task<UsageV1Response> Get8(Get8Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/usage"),
            [new TemplateParam("project_id", request.ProjectId)],
            [
                new Param("start", request.Start?.ToDate()),
                new Param("end", request.End?.ToDate()),
                new Param("accessor", request.Accessor),
                new Param("alternatives", request.Alternatives),
                new Param("callback_method", request.CallbackMethod),
                new Param("callback", request.Callback),
                new Param("channels", request.Channels),
                new Param("custom_intent_mode", request.CustomIntentMode),
                new Param("custom_intent", request.CustomIntent),
                new Param("custom_topic_mode", request.CustomTopicMode),
                new Param("custom_topic", request.CustomTopic),
                new Param("deployment", request.Deployment),
                new Param("detect_entities", request.DetectEntities),
                new Param("detect_language", request.DetectLanguage),
                new Param("diarize", request.Diarize),
                new Param("dictation", request.Dictation),
                new Param("encoding", request.Encoding),
                new Param("endpoint", request.Endpoint),
                new Param("extra", request.Extra),
                new Param("filler_words", request.FillerWords),
                new Param("intents", request.Intents),
                new Param("keyterm", request.Keyterm),
                new Param("keywords", request.Keywords),
                new Param("language", request.Language),
                new Param("measurements", request.Measurements),
                new Param("method", request.Method),
                new Param("model", request.Model),
                new Param("multichannel", request.Multichannel),
                new Param("numerals", request.Numerals),
                new Param("paragraphs", request.Paragraphs),
                new Param("profanity_filter", request.ProfanityFilter),
                new Param("punctuate", request.Punctuate),
                new Param("redact", request.Redact),
                new Param("replace", request.Replace),
                new Param("sample_rate", request.SampleRate),
                new Param("search", request.Search),
                new Param("sentiment", request.Sentiment),
                new Param("smart_format", request.SmartFormat),
                new Param("summarize", request.Summarize),
                new Param("tag", request.Tag),
                new Param("topics", request.Topics),
                new Param("utt_split", request.UttSplit),
                new Param("utterances", request.Utterances),
                new Param("version", request.Version),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsageV1Response>(),
            Get8Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
