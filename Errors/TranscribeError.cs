using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models;

namespace RestApi.Errors;

public sealed class TranscribeError : ApiError
{
    private readonly Optional<ListenV1Response> _listenV1ResponseValue;

    private TranscribeError(Optional<ListenV1Response> listenV1ResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _listenV1ResponseValue = listenV1ResponseValue;
    }

    private static TranscribeError AsListenV1Response(ListenV1Response value) =>
        new(Optional<ListenV1Response>.Some(value), default);

    private static TranscribeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetListenV1Response(out ListenV1Response value) =>
        _listenV1ResponseValue.TryGetValue(out value);

    internal static Task<TranscribeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ListenV1Response>(response, ct).As(AsListenV1Response),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TranscribeErrorResponse : IErrorResponse<TranscribeError>
{
    public static TranscribeErrorResponse Instance { get; } = new();

    private TranscribeErrorResponse()
    {
    }

    public Task<TranscribeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TranscribeError.Create(response, ct);
}
