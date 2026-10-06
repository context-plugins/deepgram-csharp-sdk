using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Errors;

public sealed class GrantError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private GrantError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static GrantError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static GrantError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    private static Task<GrantError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GrantError> Response { get; } = new(Create);
}
