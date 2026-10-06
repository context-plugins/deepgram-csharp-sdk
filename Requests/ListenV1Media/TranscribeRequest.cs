using System.Collections.Generic;
using Deepgram.Models;
using Deepgram.Models.AnyOf;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.ListenV1Media;

/// <summary>
/// The inputs of the Transcribe operation.
/// </summary>
public sealed record TranscribeRequest
{
    /// <summary>
    /// URL to which we'll make the callback request
    /// </summary>
    public string? Callback { get; init; }

    /// <summary>
    /// HTTP method by which the callback request will be made
    /// </summary>
    public V1ListenPostParametersCallbackMethod CallbackMethod { get; init; } = V1ListenPostParametersCallbackMethod.Post;

    /// <summary>
    /// Arbitrary key-value pairs that are attached to the API response for usage in downstream processing
    /// </summary>
    public V1ListenPostParametersExtra? Extra { get; init; }

    /// <summary>
    /// Recognizes the sentiment throughout a transcript or text
    /// </summary>
    public bool Sentiment { get; init; } = false;

    /// <summary>
    /// Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only.
    /// </summary>
    public V1ListenPostParametersSummarize? Summarize { get; init; }

    /// <summary>
    /// Label your requests for the purpose of identification during usage reporting
    /// </summary>
    public V1ListenPostParametersTag? Tag { get; init; }

    /// <summary>
    /// Detect topics throughout a transcript or text
    /// </summary>
    public bool Topics { get; init; } = false;

    /// <summary>
    /// Custom topics you want the model to detect within your input audio or text if present Submit up to <c>100</c>.
    /// </summary>
    public V1ListenPostParametersCustomTopic? CustomTopic { get; init; }

    /// <summary>
    /// Sets how the model will interpret strings submitted to the <c>custom_topic</c> param. When <c>strict</c>, the model will only return topics submitted using the <c>custom_topic</c> param. When <c>extended</c>, the model will return its own detected topics in addition to those submitted using the <c>custom_topic</c> param
    /// </summary>
    public V1ListenPostParametersCustomTopicMode CustomTopicMode { get; init; } = V1ListenPostParametersCustomTopicMode.Extended;

    /// <summary>
    /// Recognizes speaker intent throughout a transcript or text
    /// </summary>
    public bool Intents { get; init; } = false;

    /// <summary>
    /// Custom intents you want the model to detect within your input audio if present
    /// </summary>
    public V1ListenPostParametersCustomIntent? CustomIntent { get; init; }

    /// <summary>
    /// Sets how the model will interpret intents submitted to the <c>custom_intent</c> param. When <c>strict</c>, the model will only return intents submitted using the <c>custom_intent</c> param. When <c>extended</c>, the model will return its own detected intents in the <c>custom_intent</c> param.
    /// </summary>
    public V1ListenPostParametersCustomTopicMode CustomIntentMode { get; init; } = V1ListenPostParametersCustomTopicMode.Extended;

    /// <summary>
    /// Identifies and extracts key entities from content in submitted audio
    /// </summary>
    public bool DetectEntities { get; init; } = false;

    /// <summary>
    /// Identifies the dominant language spoken in submitted audio
    /// </summary>
    public V1ListenPostParametersDetectLanguage? DetectLanguage { get; init; }

    /// <summary>
    /// Deprecated: use <c>diarize_model</c> instead. Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0.
    /// </summary>
    public bool Diarize { get; init; } = false;

    /// <summary>
    /// Select and enable a specific diarization model version. Specifying this parameter enables diarization and selects the model — you do not need to also set the deprecated <c>diarize=true</c> parameter. For batch, supported values are <c>latest</c> (currently v2), <c>v1</c>, and <c>v2</c>. For streaming, supported values are <c>latest</c> (currently v1) and <c>v1</c>; <c>v2</c> returns a validation error on streaming requests.
    /// </summary>
    public V1ListenPostParametersDiarizeModel? DiarizeModel { get; init; }

    /// <summary>
    /// Dictation mode for controlling formatting with dictated speech
    /// </summary>
    public bool Dictation { get; init; } = false;

    /// <summary>
    /// Specify the expected encoding of your submitted audio
    /// </summary>
    public V1ListenPostParametersEncoding? Encoding { get; init; }

    /// <summary>
    /// Filler Words can help transcribe interruptions in your audio, like "uh" and "um"
    /// </summary>
    public bool FillerWords { get; init; } = false;

    /// <summary>
    /// Key term prompting improves recognition of specialized terminology and brands. Only compatible with Nova-3.
    /// <para>
    /// <c>keyterm</c> accepts plain terms only. Unlike the legacy <c>keywords</c> feature, it does not support weights or intensifiers. Appending one (for example, <c>keyterm=term:0.15</c>) is not rejected—the weight is silently ignored and the entire value is treated as a literal keyterm.
    /// </para>
    /// <para>
    /// To boost multiple separate keyterms, repeat the <c>keyterm</c> parameter (for example, <c>keyterm=term1&amp;keyterm=term2</c>). To boost one multi-word phrase as a single keyterm, join the words with <c>%20</c> or <c>+</c> (for example, <c>keyterm=customer%20service</c>). Do not separate keyterms with commas, semicolons, or line breaks.
    /// </para>
    /// </summary>
    public IReadOnlyList<string>? Keyterm { get; init; }

    /// <summary>
    /// Keywords can boost or suppress specialized terminology and brands
    /// </summary>
    public V1ListenPostParametersKeywords? Keywords { get; init; }

    /// <summary>
    /// The <see href="https://tools.ietf.org/html/bcp47">BCP-47 language tag</see> that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available
    /// </summary>
    public string Language { get; init; } = "en";

    /// <summary>
    /// Spoken measurements will be converted to their corresponding abbreviations
    /// </summary>
    public bool Measurements { get; init; } = false;

    /// <summary>
    /// AI model used to process submitted audio
    /// </summary>
    public V1ListenPostParametersModel? Model { get; init; }

    /// <summary>
    /// Transcribe each audio channel independently
    /// </summary>
    public bool Multichannel { get; init; } = false;

    /// <summary>
    /// Numerals converts numbers from written format to numerical format
    /// </summary>
    public bool Numerals { get; init; } = false;

    /// <summary>
    /// Splits audio into paragraphs to improve transcript readability
    /// </summary>
    public bool Paragraphs { get; init; } = false;

    /// <summary>
    /// Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely
    /// </summary>
    public bool ProfanityFilter { get; init; } = false;

    /// <summary>
    /// Add punctuation and capitalization to the transcript
    /// </summary>
    public bool Punctuate { get; init; } = false;

    /// <summary>
    /// Redaction removes sensitive information from your transcripts
    /// </summary>
    public V1ListenPostParametersRedact? Redact { get; init; }

    /// <summary>
    /// Search for terms or phrases in submitted audio and replaces them
    /// </summary>
    public V1ListenPostParametersReplace? Replace { get; init; }

    /// <summary>
    /// Search for terms or phrases in submitted audio
    /// </summary>
    public V1ListenPostParametersSearch? Search { get; init; }

    /// <summary>
    /// Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability
    /// </summary>
    public bool SmartFormat { get; init; } = false;

    /// <summary>
    /// Segments speech into meaningful semantic units
    /// </summary>
    public bool Utterances { get; init; } = false;

    /// <summary>
    /// Seconds to wait before detecting a pause between words in submitted audio
    /// </summary>
    public double UttSplit { get; init; } = 0.8d;

    /// <summary>
    /// Version of an AI model to use
    /// </summary>
    public V1ListenPostParametersVersion? Version { get; init; }

    /// <summary>
    /// Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip
    /// </summary>
    public bool MipOptOut { get; init; } = false;

    /// <summary>
    /// Transcribe an audio or video file
    /// </summary>
    public ListenV1RequestUrl? Body { get; init; }
}
