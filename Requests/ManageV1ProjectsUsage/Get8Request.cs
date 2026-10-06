using System;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.ManageV1ProjectsUsage;

/// <summary>
/// The inputs of the Get8 operation.
/// </summary>
public sealed record Get8Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Start date of the requested date range. Format accepted is YYYY-MM-DD
    /// </summary>
    public DateTimeOffset? Start { get; init; }

    /// <summary>
    /// End date of the requested date range. Format accepted is YYYY-MM-DD
    /// </summary>
    public DateTimeOffset? End { get; init; }

    /// <summary>
    /// Filter for requests where a specific accessor was used
    /// </summary>
    public string? Accessor { get; init; }

    /// <summary>
    /// Filter for requests where alternatives were used
    /// </summary>
    public bool? Alternatives { get; init; }

    /// <summary>
    /// Filter for requests where callback method was used
    /// </summary>
    public bool? CallbackMethod { get; init; }

    /// <summary>
    /// Filter for requests where callback was used
    /// </summary>
    public bool? Callback { get; init; }

    /// <summary>
    /// Filter for requests where channels were used
    /// </summary>
    public bool? Channels { get; init; }

    /// <summary>
    /// Filter for requests where custom intent mode was used
    /// </summary>
    public bool? CustomIntentMode { get; init; }

    /// <summary>
    /// Filter for requests where custom intent was used
    /// </summary>
    public bool? CustomIntent { get; init; }

    /// <summary>
    /// Filter for requests where custom topic mode was used
    /// </summary>
    public bool? CustomTopicMode { get; init; }

    /// <summary>
    /// Filter for requests where custom topic was used
    /// </summary>
    public bool? CustomTopic { get; init; }

    /// <summary>
    /// Filter for requests where a specific deployment was used
    /// </summary>
    public V1ProjectsProjectIdUsageGetParametersDeployment? Deployment { get; init; }

    /// <summary>
    /// Filter for requests where detect entities was used
    /// </summary>
    public bool? DetectEntities { get; init; }

    /// <summary>
    /// Filter for requests where detect language was used
    /// </summary>
    public bool? DetectLanguage { get; init; }

    /// <summary>
    /// Filter for requests where diarize was used
    /// </summary>
    public bool? Diarize { get; init; }

    /// <summary>
    /// Filter for requests where dictation was used
    /// </summary>
    public bool? Dictation { get; init; }

    /// <summary>
    /// Filter for requests where encoding was used
    /// </summary>
    public bool? Encoding { get; init; }

    /// <summary>
    /// Filter for requests where a specific endpoint was used
    /// </summary>
    public V1ProjectsProjectIdUsageGetParametersEndpoint? Endpoint { get; init; }

    /// <summary>
    /// Filter for requests where extra was used
    /// </summary>
    public bool? Extra { get; init; }

    /// <summary>
    /// Filter for requests where filler words was used
    /// </summary>
    public bool? FillerWords { get; init; }

    /// <summary>
    /// Filter for requests where intents was used
    /// </summary>
    public bool? Intents { get; init; }

    /// <summary>
    /// Filter for requests where keyterm was used
    /// </summary>
    public bool? Keyterm { get; init; }

    /// <summary>
    /// Filter for requests where keywords was used
    /// </summary>
    public bool? Keywords { get; init; }

    /// <summary>
    /// Filter for requests where language was used
    /// </summary>
    public bool? Language { get; init; }

    /// <summary>
    /// Filter for requests where measurements were used
    /// </summary>
    public bool? Measurements { get; init; }

    /// <summary>
    /// Filter for requests where a specific method was used
    /// </summary>
    public V1ProjectsProjectIdUsageGetParametersMethod? Method { get; init; }

    /// <summary>
    /// Filter for requests where a specific model uuid was used
    /// </summary>
    public string? Model { get; init; }

    /// <summary>
    /// Filter for requests where multichannel was used
    /// </summary>
    public bool? Multichannel { get; init; }

    /// <summary>
    /// Filter for requests where numerals were used
    /// </summary>
    public bool? Numerals { get; init; }

    /// <summary>
    /// Filter for requests where paragraphs were used
    /// </summary>
    public bool? Paragraphs { get; init; }

    /// <summary>
    /// Filter for requests where profanity filter was used
    /// </summary>
    public bool? ProfanityFilter { get; init; }

    /// <summary>
    /// Filter for requests where punctuate was used
    /// </summary>
    public bool? Punctuate { get; init; }

    /// <summary>
    /// Filter for requests where redact was used
    /// </summary>
    public bool? Redact { get; init; }

    /// <summary>
    /// Filter for requests where replace was used
    /// </summary>
    public bool? Replace { get; init; }

    /// <summary>
    /// Filter for requests where sample rate was used
    /// </summary>
    public bool? SampleRate { get; init; }

    /// <summary>
    /// Filter for requests where search was used
    /// </summary>
    public bool? Search { get; init; }

    /// <summary>
    /// Filter for requests where sentiment was used
    /// </summary>
    public bool? Sentiment { get; init; }

    /// <summary>
    /// Filter for requests where smart format was used
    /// </summary>
    public bool? SmartFormat { get; init; }

    /// <summary>
    /// Filter for requests where summarize was used
    /// </summary>
    public bool? Summarize { get; init; }

    /// <summary>
    /// Filter for requests where a specific tag was used
    /// </summary>
    public string? Tag { get; init; }

    /// <summary>
    /// Filter for requests where topics was used
    /// </summary>
    public bool? Topics { get; init; }

    /// <summary>
    /// Filter for requests where utt split was used
    /// </summary>
    public bool? UttSplit { get; init; }

    /// <summary>
    /// Filter for requests where utterances was used
    /// </summary>
    public bool? Utterances { get; init; }

    /// <summary>
    /// Filter for requests where version was used
    /// </summary>
    public bool? Version { get; init; }
}
