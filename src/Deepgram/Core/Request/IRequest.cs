using System.Net.Http;

namespace Deepgram.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}