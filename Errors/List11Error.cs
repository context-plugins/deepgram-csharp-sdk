using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Errors;

public sealed class List11Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private List11Error(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static List11Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static List11Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    private static Task<List11Error> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<List11Error> Response { get; } = new(Create);
}
