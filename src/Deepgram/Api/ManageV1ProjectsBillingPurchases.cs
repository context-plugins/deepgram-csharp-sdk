using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core;
using Deepgram.Core.Exceptions;
using Deepgram.Core.Models;
using Deepgram.Core.Request;
using Deepgram.Core.Response;
using Deepgram.Errors;
using Deepgram.Models;
using Deepgram.Requests.ManageV1ProjectsBillingPurchases;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsBillingPurchases
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsBillingPurchases(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// List Project Purchases
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectPurchasesV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List16Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the original purchased amount on an order transaction
    /// </remarks>
    public Task<ListProjectPurchasesV1Response> List16(List16Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/purchases"),
            [new TemplateParam("project_id", request.ProjectId)],
            [new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectPurchasesV1Response>(),
            List16Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
