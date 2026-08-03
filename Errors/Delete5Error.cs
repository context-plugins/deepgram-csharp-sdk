using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models.AnyOf;

namespace RestApi.Errors;

public sealed class Delete5Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private Delete5Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static Delete5Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static Delete5Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<Delete5Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class Delete5ErrorResponse : IErrorResponse<Delete5Error>
{
    public static Delete5ErrorResponse Instance { get; } = new();

    private Delete5ErrorResponse()
    {
    }

    public Task<Delete5Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        Delete5Error.Create(response, ct);
}
