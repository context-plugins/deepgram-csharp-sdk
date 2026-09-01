using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Errors;

public sealed class Get4Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private Get4Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static Get4Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static Get4Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<Get4Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class Get4ErrorResponse : IErrorResponse<Get4Error>
{
    public static Get4ErrorResponse Instance { get; } = new();

    private Get4ErrorResponse()
    {
    }

    public Task<Get4Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        Get4Error.Create(response, ct);
}
