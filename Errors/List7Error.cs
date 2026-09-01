using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Errors;

public sealed class List7Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private List7Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static List7Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static List7Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<List7Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class List7ErrorResponse : IErrorResponse<List7Error>
{
    public static List7ErrorResponse Instance { get; } = new();

    private List7ErrorResponse()
    {
    }

    public Task<List7Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        List7Error.Create(response, ct);
}
