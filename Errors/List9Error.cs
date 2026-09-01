using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Errors;

public sealed class List9Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private List9Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static List9Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static List9Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<List9Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class List9ErrorResponse : IErrorResponse<List9Error>
{
    public static List9ErrorResponse Instance { get; } = new();

    private List9ErrorResponse()
    {
    }

    public Task<List9Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        List9Error.Create(response, ct);
}
