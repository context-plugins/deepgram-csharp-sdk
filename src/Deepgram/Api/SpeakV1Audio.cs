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
using Deepgram.Requests.SpeakV1Audio;

namespace Deepgram.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GenerateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert text into natural-sounding speech using Deepgram's TTS REST API
    /// </remarks>
    public Task<object> Generate(GenerateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/speak"),
            [],
            [
                new Param("callback", request.Callback),
                new Param("callback_method", request.CallbackMethod),
                new Param("mip_opt_out", request.MipOptOut),
                new Param("tag", request.Tag),
                new Param("bit_rate", request.BitRate),
                new Param("container", request.Container),
                new Param("encoding", request.Encoding),
                new Param("model", request.Model),
                new Param("sample_rate", request.SampleRate),
                new Param("speed", request.Speed),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<object>(),
            GenerateError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
