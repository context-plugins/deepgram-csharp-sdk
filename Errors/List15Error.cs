using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models.AnyOf;

namespace RestApi.Errors;

public sealed class List15Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private List15Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static List15Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static List15Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<List15Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class List15ErrorResponse : IErrorResponse<List15Error>
{
    public static List15ErrorResponse Instance { get; } = new();

    private List15ErrorResponse()
    {
    }

    public Task<List15Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        List15Error.Create(response, ct);
}
