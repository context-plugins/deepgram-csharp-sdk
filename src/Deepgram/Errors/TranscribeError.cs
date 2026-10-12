using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models;

namespace Deepgram.Errors;

public sealed class TranscribeError : ApiError
{
    private readonly Optional<ListenV1Response> _listenV1ResponseValue;

    private TranscribeError(Optional<ListenV1Response> listenV1ResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _listenV1ResponseValue = listenV1ResponseValue;
    }

    private static TranscribeError AsListenV1Response(ListenV1Response value) =>
        new(Optional<ListenV1Response>.Some(value), default);

    private static TranscribeError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetListenV1Response(out ListenV1Response value) => _listenV1ResponseValue.TryGetValue(out value);

    private static Task<TranscribeError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ListenV1Response>().As(AsListenV1Response),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<TranscribeError> Response { get; } = new(Create);
}
