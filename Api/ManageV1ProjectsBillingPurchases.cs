using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestApi.Core;
using RestApi.Core.Exceptions;
using RestApi.Core.Models;
using RestApi.Core.Request;
using RestApi.Core.Response;
using RestApi.Errors;
using RestApi.Models;

namespace RestApi.Api;

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
    /// <param name="projectId">The unique identifier of the project</param>
    /// <param name="limit">Number of results to return per page. Default 10. Range [1,1000]</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectPurchasesV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="List16Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the original purchased amount on an order transaction
    /// </remarks>
    public Task<ListProjectPurchasesV1Response> List16(string projectId,
        double? limit = 10d,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/projects/{project_id}/purchases"),
            [new TemplateParam("project_id", projectId)],
            [new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectPurchasesV1Response>(),
            List16ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
