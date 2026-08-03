using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models.AnyOf;

namespace RestApi.Errors;

public sealed class Delete6Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private Delete6Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static Delete6Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static Delete6Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<Delete6Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class Delete6ErrorResponse : IErrorResponse<Delete6Error>
{
    public static Delete6ErrorResponse Instance { get; } = new();

    private Delete6ErrorResponse()
    {
    }

    public Task<Delete6Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        Delete6Error.Create(response, ct);
}
