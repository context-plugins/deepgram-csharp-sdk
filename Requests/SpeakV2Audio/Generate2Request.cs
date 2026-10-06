using Deepgram.Models;
using Deepgram.Models.AnyOf;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.SpeakV2Audio;

/// <summary>
/// The inputs of the Generate2 operation.
/// </summary>
public sealed record Generate2Request
{
    /// <summary>
    /// Flux TTS model used to synthesize the submitted text, in the form <c>flux-{voice}-{language}</c> (for example, <c>flux-alexis-en</c>). Required; unlike the v1 (Aura) endpoint there is no default and only flux models are accepted. English-only at launch.
    /// </summary>
    public required string Model { get; init; }

    /// <summary>
    /// URL to which we'll make the callback request
    /// </summary>
    public string? Callback { get; init; }

    /// <summary>
    /// HTTP method by which the callback request will be made
    /// </summary>
    public V1ListenPostParametersCallbackMethod CallbackMethod { get; init; } = V1ListenPostParametersCallbackMethod.Post;

    /// <summary>
    /// Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip
    /// </summary>
    public bool MipOptOut { get; init; } = false;

    /// <summary>
    /// Label your requests for the purpose of identification during usage reporting
    /// </summary>
    public V2SpeakPostParametersTag? Tag { get; init; }

    /// <summary>
    /// The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
    /// </summary>
    public V2SpeakPostParametersBitRate? BitRate { get; init; }

    /// <summary>
    /// Container specifies the file format wrapper for the output audio. The available options depend on the encoding type.
    /// </summary>
    public V2SpeakPostParametersContainer? Container { get; init; }

    /// <summary>
    /// Encoding allows you to specify the expected encoding of your audio output
    /// </summary>
    public V2SpeakPostParametersEncoding? Encoding { get; init; }

    /// <summary>
    /// Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
    /// </summary>
    public V2SpeakPostParametersSampleRate? SampleRate { get; init; }

    /// <summary>
    /// Processing priority for asynchronous (callback) requests. The only supported value is low.
    /// </summary>
    public V2SpeakPostParametersPriority? Priority { get; init; }

    /// <summary>
    /// Transform text to speech
    /// </summary>
    public SpeakV2Request? Body { get; init; }
}
