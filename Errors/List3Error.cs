using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Errors;

public sealed class List3Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private List3Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static List3Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static List3Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<List3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class List3ErrorResponse : IErrorResponse<List3Error>
{
    public static List3ErrorResponse Instance { get; } = new();

    private List3ErrorResponse()
    {
    }

    public Task<List3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        List3Error.Create(response, ct);
}
