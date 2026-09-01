using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Deepgram.Core.ErrorResponse;

public interface IErrorResponse<TError>
{
    Task<TError> Map(HttpResponseMessage response, CancellationToken ct);
}