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
using Deepgram.Models;
using Deepgram.Requests.SpeakV2Audio;

namespace Deepgram.Api;

public sealed class SpeakV2Audio
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SpeakV2Audio(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Flux Text to Speech (batch)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SpeakV2AcceptedResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Generate2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
    /// </remarks>
    public Task<SpeakV2AcceptedResponse> Generate2(Generate2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/speak"),
            [],
            [
                new Param("model", request.Model),
                new Param("callback", request.Callback),
                new Param("callback_method", request.CallbackMethod),
                new Param("mip_opt_out", request.MipOptOut),
                new Param("tag", request.Tag),
                new Param("bit_rate", request.BitRate),
                new Param("container", request.Container),
                new Param("encoding", request.Encoding),
                new Param("sample_rate", request.SampleRate),
                new Param("priority", request.Priority),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SpeakV2AcceptedResponse>(),
            Generate2Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
