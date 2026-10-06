using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core.Models;

namespace Deepgram.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}