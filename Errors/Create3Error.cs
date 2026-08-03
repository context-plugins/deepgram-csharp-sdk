using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models.AnyOf;

namespace RestApi.Errors;

public sealed class Create3Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private Create3Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static Create3Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static Create3Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<Create3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class Create3ErrorResponse : IErrorResponse<Create3Error>
{
    public static Create3ErrorResponse Instance { get; } = new();

    private Create3ErrorResponse()
    {
    }

    public Task<Create3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        Create3Error.Create(response, ct);
}
