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
using RestApi.Models.AnyOf;
using RestApi.Models.Enums;

namespace RestApi.Api;

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
    /// <param name="callback">URL to which we'll make the callback request</param>
    /// <param name="callbackMethod">HTTP method by which the callback request will be made</param>
    /// <param name="extra">Arbitrary key-value pairs that are attached to the API response for usage in downstream processing</param>
    /// <param name="summarize">Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only.</param>
    /// <param name="tag">Label your requests for the purpose of identification during usage reporting</param>
    /// <param name="customTopic">Custom topics you want the model to detect within your input audio or text if present Submit up to <c>100</c>.</param>
    /// <param name="customTopicMode">Sets how the model will interpret strings submitted to the <c>custom_topic</c> param. When <c>strict</c>, the model will only return topics submitted using the <c>custom_topic</c> param. When <c>extended</c>, the model will return its own detected topics in addition to those submitted using the <c>custom_topic</c> param</param>
    /// <param name="customIntent">Custom intents you want the model to detect within your input audio if present</param>
    /// <param name="customIntentMode">Sets how the model will interpret intents submitted to the <c>custom_intent</c> param. When <c>strict</c>, the model will only return intents submitted using the <c>custom_intent</c> param. When <c>extended</c>, the model will return its own detected intents in the <c>custom_intent</c> param.</param>
    /// <param name="detectLanguage">Identifies the dominant language spoken in submitted audio</param>
    /// <param name="diarizeModel">Select and enable a specific diarization model version. Specifying this parameter enables diarization and selects the model — you do not need to also set the deprecated <c>diarize=true</c> parameter. For batch, supported values are <c>latest</c> (currently v2), <c>v1</c>, and <c>v2</c>. For streaming, supported values are <c>latest</c> (currently v1) and <c>v1</c>; <c>v2</c> returns a validation error on streaming requests.</param>
    /// <param name="encoding">Specify the expected encoding of your submitted audio</param>
    /// <param name="keyterm">Key term prompting improves recognition of specialized terminology and brands. Only compatible with Nova-3.  <c>keyterm</c> accepts plain terms only. Unlike the legacy <c>keywords</c> feature, it does not support weights or intensifiers. Appending one (for example, <c>keyterm=term:0.15</c>) is not rejected—the weight is silently ignored and the entire value is treated as a literal keyterm.  To boost multiple separate keyterms, repeat the <c>keyterm</c> parameter (for example, <c>keyterm=term1&amp;keyterm=term2</c>). To boost one multi-word phrase as a single keyterm, join the words with <c>%20</c> or <c>+</c> (for example, <c>keyterm=customer%20service</c>). Do not separate keyterms with commas, semicolons, or line breaks.</param>
    /// <param name="keywords">Keywords can boost or suppress specialized terminology and brands</param>
    /// <param name="model">AI model used to process submitted audio</param>
    /// <param name="redact">Redaction removes sensitive information from your transcripts</param>
    /// <param name="replace">Search for terms or phrases in submitted audio and replaces them</param>
    /// <param name="search">Search for terms or phrases in submitted audio</param>
    /// <param name="version">Version of an AI model to use</param>
    /// <param name="body"></param>
    /// <param name="sentiment">Recognizes the sentiment throughout a transcript or text</param>
    /// <param name="topics">Detect topics throughout a transcript or text</param>
    /// <param name="intents">Recognizes speaker intent throughout a transcript or text</param>
    /// <param name="detectEntities">Identifies and extracts key entities from content in submitted audio</param>
    /// <param name="diarize">Deprecated: use <c>diarize_model</c> instead. Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0.</param>
    /// <param name="dictation">Dictation mode for controlling formatting with dictated speech</param>
    /// <param name="fillerWords">Filler Words can help transcribe interruptions in your audio, like "uh" and "um"</param>
    /// <param name="language">The <see href="https://tools.ietf.org/html/bcp47">BCP-47 language tag</see> that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available</param>
    /// <param name="measurements">Spoken measurements will be converted to their corresponding abbreviations</param>
    /// <param name="multichannel">Transcribe each audio channel independently</param>
    /// <param name="numerals">Numerals converts numbers from written format to numerical format</param>
    /// <param name="paragraphs">Splits audio into paragraphs to improve transcript readability</param>
    /// <param name="profanityFilter">Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely</param>
    /// <param name="punctuate">Add punctuation and capitalization to the transcript</param>
    /// <param name="smartFormat">Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability</param>
    /// <param name="utterances">Segments speech into meaningful semantic units</param>
    /// <param name="uttSplit">Seconds to wait before detecting a pause between words in submitted audio</param>
    /// <param name="mipOptOut">Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListenV1MediaTranscribeResponse200"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TranscribeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transcribe audio and video using Deepgram's speech-to-text REST API
    /// </remarks>
    public Task<ListenV1MediaTranscribeResponse200> Transcribe(string? callback,
        V1ListenPostParametersCallbackMethod? callbackMethod,
        V1ListenPostParametersExtra? extra,
        V1ListenPostParametersSummarize? summarize,
        V1ListenPostParametersTag? tag,
        V1ListenPostParametersCustomTopic? customTopic,
        V1ListenPostParametersCustomTopicMode? customTopicMode,
        V1ListenPostParametersCustomIntent? customIntent,
        V1ListenPostParametersCustomTopicMode? customIntentMode,
        V1ListenPostParametersDetectLanguage? detectLanguage,
        V1ListenPostParametersDiarizeModel? diarizeModel,
        V1ListenPostParametersEncoding? encoding,
        IReadOnlyList<string>? keyterm,
        V1ListenPostParametersKeywords? keywords,
        V1ListenPostParametersModel? model,
        V1ListenPostParametersRedact? redact,
        V1ListenPostParametersReplace? replace,
        V1ListenPostParametersSearch? search,
        V1ListenPostParametersVersion? version,
        ListenV1RequestUrl? body,
        bool? sentiment = false,
        bool? topics = false,
        bool? intents = false,
        bool? detectEntities = false,
        bool? diarize = false,
        bool? dictation = false,
        bool? fillerWords = false,
        string? language = "en",
        bool? measurements = false,
        bool? multichannel = false,
        bool? numerals = false,
        bool? paragraphs = false,
        bool? profanityFilter = false,
        bool? punctuate = false,
        bool? smartFormat = false,
        bool? utterances = false,
        double? uttSplit = 0.8d,
        bool? mipOptOut = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/listen"),
            [],
            [new Param("callback", callback),
                new Param("callback_method", callbackMethod),
                new Param("extra", extra),
                new Param("sentiment", sentiment),
                new Param("summarize", summarize),
                new Param("tag", tag),
                new Param("topics", topics),
                new Param("custom_topic", customTopic),
                new Param("custom_topic_mode", customTopicMode),
                new Param("intents", intents),
                new Param("custom_intent", customIntent),
                new Param("custom_intent_mode", customIntentMode),
                new Param("detect_entities", detectEntities),
                new Param("detect_language", detectLanguage),
                new Param("diarize", diarize),
                new Param("diarize_model", diarizeModel),
                new Param("dictation", dictation),
                new Param("encoding", encoding),
                new Param("filler_words", fillerWords),
                new Param("keyterm", keyterm),
                new Param("keywords", keywords),
                new Param("language", language),
                new Param("measurements", measurements),
                new Param("model", model),
                new Param("multichannel", multichannel),
                new Param("numerals", numerals),
                new Param("paragraphs", paragraphs),
                new Param("profanity_filter", profanityFilter),
                new Param("punctuate", punctuate),
                new Param("redact", redact),
                new Param("replace", replace),
                new Param("search", search),
                new Param("smart_format", smartFormat),
                new Param("utterances", utterances),
                new Param("utt_split", uttSplit),
                new Param("version", version),
                new Param("mip_opt_out", mipOptOut)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ListenV1MediaTranscribeResponse200>(),
            TranscribeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
