using Deepgram.Models;
using Deepgram.Models.AnyOf;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.SpeakV1Audio;

/// <summary>
/// The inputs of the Generate operation.
/// </summary>
public sealed record GenerateRequest
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
    /// Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip
    /// </summary>
    public bool MipOptOut { get; init; } = false;

    /// <summary>
    /// Label your requests for the purpose of identification during usage reporting
    /// </summary>
    public V1SpeakPostParametersTag? Tag { get; init; }

    /// <summary>
    /// The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
    /// </summary>
    public V1SpeakPostParametersBitRate? BitRate { get; init; }

    /// <summary>
    /// Container specifies the file format wrapper for the output audio. The available options depend on the encoding type.
    /// </summary>
    public V1SpeakPostParametersContainer? Container { get; init; }

    /// <summary>
    /// Encoding allows you to specify the expected encoding of your audio output
    /// </summary>
    public V1SpeakPostParametersEncoding? Encoding { get; init; }

    /// <summary>
    /// AI model used to process submitted text
    /// </summary>
    public V1SpeakPostParametersModel Model { get; init; } = V1SpeakPostParametersModel.AuraAsteriaEn;

    /// <summary>
    /// Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
    /// </summary>
    public V1SpeakPostParametersSampleRate? SampleRate { get; init; }

    /// <summary>
    /// Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Not yet supported in all languages.
    /// </summary>
    public double Speed { get; init; } = 1d;

    /// <summary>
    /// Transform text to speech
    /// </summary>
    public SpeakV1Request? Body { get; init; }
}
