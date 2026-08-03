using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models.AnyOf;

namespace RestApi.Errors;

public sealed class Get3Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private Get3Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static Get3Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static Get3Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<Get3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class Get3ErrorResponse : IErrorResponse<Get3Error>
{
    public static Get3ErrorResponse Instance { get; } = new();

    private Get3ErrorResponse()
    {
    }

    public Task<Get3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        Get3Error.Create(response, ct);
}
