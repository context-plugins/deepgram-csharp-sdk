using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models.AnyOf;

namespace RestApi.Errors;

public sealed class Delete2Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private Delete2Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static Delete2Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static Delete2Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<Delete2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class Delete2ErrorResponse : IErrorResponse<Delete2Error>
{
    public static Delete2ErrorResponse Instance { get; } = new();

    private Delete2ErrorResponse()
    {
    }

    public Task<Delete2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        Delete2Error.Create(response, ct);
}
