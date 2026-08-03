using System;
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

public sealed class SpeakV2Audio
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal SpeakV2Audio(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Flux Text to Speech (batch)
    /// </summary>
    /// <param name="model">Flux TTS model used to synthesize the submitted text, in the form <c>flux-{voice}-{language}</c> (for example, <c>flux-alexis-en</c>). Required; unlike the v1 (Aura) endpoint there is no default and only flux models are accepted. English-only at launch.</param>
    /// <param name="callback">URL to which we'll make the callback request</param>
    /// <param name="callbackMethod">HTTP method by which the callback request will be made</param>
    /// <param name="tag">Label your requests for the purpose of identification during usage reporting</param>
    /// <param name="bitRate">The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.</param>
    /// <param name="container">Container specifies the file format wrapper for the output audio. The available options depend on the encoding type.</param>
    /// <param name="encoding">Encoding allows you to specify the expected encoding of your audio output</param>
    /// <param name="sampleRate">Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable</param>
    /// <param name="priority">Processing priority for asynchronous (callback) requests. The only supported value is low.</param>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="body"></param>
    /// <param name="mipOptOut">Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SpeakV2AcceptedResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="Generate2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
    /// </remarks>
    public Task<SpeakV2AcceptedResponse> Generate2(string model,
        string? callback,
        V1ListenPostParametersCallbackMethod? callbackMethod,
        V2SpeakPostParametersTag? tag,
        V2SpeakPostParametersBitRate? bitRate,
        V2SpeakPostParametersContainer? container,
        V2SpeakPostParametersEncoding? encoding,
        V2SpeakPostParametersSampleRate? sampleRate,
        V2SpeakPostParametersPriority? priority,
        string authorization,
        SpeakV2Request? body,
        bool? mipOptOut = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/speak"),
            [],
            [new Param("model", model),
                new Param("callback", callback),
                new Param("callback_method", callbackMethod),
                new Param("mip_opt_out", mipOptOut),
                new Param("tag", tag),
                new Param("bit_rate", bitRate),
                new Param("container", container),
                new Param("encoding", encoding),
                new Param("sample_rate", sampleRate),
                new Param("priority", priority)],
            [new HeaderParam("Authorization", authorization), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SpeakV2AcceptedResponse>(),
            Generate2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
