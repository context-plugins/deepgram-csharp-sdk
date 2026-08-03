using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core.ErrorResponse;
using RestApi.Core.Models;
using RestApi.Models.AnyOf;

namespace RestApi.Errors;

public sealed class AnalyzeError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private AnalyzeError(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static AnalyzeError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static AnalyzeError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<AnalyzeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AnalyzeErrorResponse : IErrorResponse<AnalyzeError>
{
    public static AnalyzeErrorResponse Instance { get; } = new();

    private AnalyzeErrorResponse()
    {
    }

    public Task<AnalyzeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AnalyzeError.Create(response, ct);
}
