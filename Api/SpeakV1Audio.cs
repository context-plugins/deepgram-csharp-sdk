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

public sealed class SpeakV1Audio
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SpeakV1Audio(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Text to Speech transformation
    /// </summary>
    /// <param name="callback">URL to which we'll make the callback request</param>
    /// <param name="callbackMethod">HTTP method by which the callback request will be made</param>
    /// <param name="tag">Label your requests for the purpose of identification during usage reporting</param>
    /// <param name="bitRate">The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.</param>
    /// <param name="container">Container specifies the file format wrapper for the output audio. The available options depend on the encoding type.</param>
    /// <param name="encoding">Encoding allows you to specify the expected encoding of your audio output</param>
    /// <param name="model">AI model used to process submitted text</param>
    /// <param name="sampleRate">Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable</param>
    /// <param name="body"></param>
    /// <param name="mipOptOut">Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip</param>
    /// <param name="speed">Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Not yet supported in all languages.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GenerateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert text into natural-sounding speech using Deepgram's TTS REST API
    /// </remarks>
    public Task<object> Generate(string? callback,
        V1ListenPostParametersCallbackMethod? callbackMethod,
        V1SpeakPostParametersTag? tag,
        V1SpeakPostParametersBitRate? bitRate,
        V1SpeakPostParametersContainer? container,
        V1SpeakPostParametersEncoding? encoding,
        V1SpeakPostParametersModel? model,
        V1SpeakPostParametersSampleRate? sampleRate,
        SpeakV1Request? body,
        bool? mipOptOut = false,
        double? speed = 1d,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/speak"),
            [],
            [new Param("callback", callback),
                new Param("callback_method", callbackMethod),
                new Param("mip_opt_out", mipOptOut),
                new Param("tag", tag),
                new Param("bit_rate", bitRate),
                new Param("container", container),
                new Param("encoding", encoding),
                new Param("model", model),
                new Param("sample_rate", sampleRate),
                new Param("speed", speed)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<object>(),
            GenerateErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
