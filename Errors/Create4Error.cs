using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core.ErrorResponse;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Errors;

public sealed class Create4Error : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private Create4Error(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static Create4Error AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static Create4Error AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<Create4Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class Create4ErrorResponse : IErrorResponse<Create4Error>
{
    public static Create4ErrorResponse Instance { get; } = new();

    private Create4ErrorResponse()
    {
    }

    public Task<Create4Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        Create4Error.Create(response, ct);
}
