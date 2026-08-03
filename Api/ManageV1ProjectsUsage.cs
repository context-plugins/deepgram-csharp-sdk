using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core;
using RestApi.Core.Exceptions;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Core.Request;
using RestApi.Core.Response;
using RestApi.Errors;
using RestApi.Models;
using RestApi.Models.Enums;

namespace RestApi.Api;

public sealed class ManageV1ProjectsUsage
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ManageV1ProjectsUsage(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get Project Usage
    /// </summary>
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="start">Start date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="end">End date of the requested date range. Format accepted is YYYY-MM-DD</param>
    /// <param name="accessor">Filter for requests where a specific accessor was used</param>
    /// <param name="alternatives">Filter for requests where alternatives were used</param>
    /// <param name="callbackMethod">Filter for requests where callback method was used</param>
    /// <param name="callback">Filter for requests where callback was used</param>
    /// <param name="channels">Filter for requests where channels were used</param>
    /// <param name="customIntentMode">Filter for requests where custom intent mode was used</param>
    /// <param name="customIntent">Filter for requests where custom intent was used</param>
    /// <param name="customTopicMode">Filter for requests where custom topic mode was used</param>
    /// <param name="customTopic">Filter for requests where custom topic was used</param>
    /// <param name="deployment">Filter for requests where a specific deployment was used</param>
    /// <param name="detectEntities">Filter for requests where detect entities was used</param>
    /// <param name="detectLanguage">Filter for requests where detect language was used</param>
    /// <param name="diarize">Filter for requests where diarize was used</param>
    /// <param name="dictation">Filter for requests where dictation was used</param>
    /// <param name="encoding">Filter for requests where encoding was used</param>
    /// <param name="endpoint">Filter for requests where a specific endpoint was used</param>
    /// <param name="extra">Filter for requests where extra was used</param>
    /// <param name="fillerWords">Filter for requests where filler words was used</param>
    /// <param name="intents">Filter for requests where intents was used</param>
    /// <param name="keyterm">Filter for requests where keyterm was used</param>
    /// <param name="keywords">Filter for requests where keywords was used</param>
    /// <param name="language">Filter for requests where language was used</param>
    /// <param name="measurements">Filter for requests where measurements were used</param>
    /// <param name="method">Filter for requests where a specific method was used</param>
    /// <param name="model">Filter for requests where a specific model uuid was used</param>
    /// <param name="multichannel">Filter for requests where multichannel was used</param>
    /// <param name="numerals">Filter for requests where numerals were used</param>
    /// <param name="paragraphs">Filter for requests where paragraphs were used</param>
    /// <param name="profanityFilter">Filter for requests where profanity filter was used</param>
    /// <param name="punctuate">Filter for requests where punctuate was used</param>
    /// <param name="redact">Filter for requests where redact was used</param>
    /// <param name="replace">Filter for requests where replace was used</param>
    /// <param name="sampleRate">Filter for requests where sample rate was used</param>
    /// <param name="search">Filter for requests where search was used</param>
    /// <param name="sentiment">Filter for requests where sentiment was used</param>
    /// <param name="smartFormat">Filter for requests where smart format was used</param>
    /// <param name="summarize">Filter for requests where summarize was used</param>
    /// <param name="tag">Filter for requests where a specific tag was used</param>
    /// <param name="topics">Filter for requests where topics was used</param>
    /// <param name="uttSplit">Filter for requests where utt split was used</param>
    /// <param name="utterances">Filter for requests where utterances was used</param>
    /// <param name="version">Filter for requests where version was used</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Get8Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the usage for a specific project. Use Get Project Usage Breakdown for a more comprehensive usage summary.
    /// </remarks>
    public Task<UsageV1Response> Get8(string projectId,
        DateTimeOffset? start,
        DateTimeOffset? end,
        string? accessor,
        bool? alternatives,
        bool? callbackMethod,
        bool? callback,
        bool? channels,
        bool? customIntentMode,
        bool? customIntent,
        bool? customTopicMode,
        bool? customTopic,
        V1ProjectsProjectIdUsageGetParametersDeployment? deployment,
        bool? detectEntities,
        bool? detectLanguage,
        bool? diarize,
        bool? dictation,
        bool? encoding,
        V1ProjectsProjectIdUsageGetParametersEndpoint? endpoint,
        bool? extra,
        bool? fillerWords,
        bool? intents,
        bool? keyterm,
        bool? keywords,
        bool? language,
        bool? measurements,
        V1ProjectsProjectIdUsageGetParametersMethod? method,
        string? model,
        bool? multichannel,
        bool? numerals,
        bool? paragraphs,
        bool? profanityFilter,
        bool? punctuate,
        bool? redact,
        bool? replace,
        bool? sampleRate,
        bool? search,
        bool? sentiment,
        bool? smartFormat,
        bool? summarize,
        string? tag,
        bool? topics,
        bool? uttSplit,
        bool? utterances,
        bool? version,
        string authorization,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/usage"),
            [new TemplateParam("project_id", projectId)],
            [new Param("start", start?.ToDate()),
                new Param("end", end?.ToDate()),
                new Param("accessor", accessor),
                new Param("alternatives", alternatives),
                new Param("callback_method", callbackMethod),
                new Param("callback", callback),
                new Param("channels", channels),
                new Param("custom_intent_mode", customIntentMode),
                new Param("custom_intent", customIntent),
                new Param("custom_topic_mode", customTopicMode),
                new Param("custom_topic", customTopic),
                new Param("deployment", deployment),
                new Param("detect_entities", detectEntities),
                new Param("detect_language", detectLanguage),
                new Param("diarize", diarize),
                new Param("dictation", dictation),
                new Param("encoding", encoding),
                new Param("endpoint", endpoint),
                new Param("extra", extra),
                new Param("filler_words", fillerWords),
                new Param("intents", intents),
                new Param("keyterm", keyterm),
                new Param("keywords", keywords),
                new Param("language", language),
                new Param("measurements", measurements),
                new Param("method", method),
                new Param("model", model),
                new Param("multichannel", multichannel),
                new Param("numerals", numerals),
                new Param("paragraphs", paragraphs),
                new Param("profanity_filter", profanityFilter),
                new Param("punctuate", punctuate),
                new Param("redact", redact),
                new Param("replace", replace),
                new Param("sample_rate", sampleRate),
                new Param("search", search),
                new Param("sentiment", sentiment),
                new Param("smart_format", smartFormat),
                new Param("summarize", summarize),
                new Param("tag", tag),
                new Param("topics", topics),
                new Param("utt_split", uttSplit),
                new Param("utterances", utterances),
                new Param("version", version)],
            [new HeaderParam("Authorization", authorization)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsageV1Response>(),
            Get8ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
