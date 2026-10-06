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
using Deepgram.Requests.ManageV1ProjectsBillingBalances;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsBillingBalances
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsBillingBalances(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a Project Balance
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetProjectBalanceV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="Get10Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details about the specified balance
    /// </remarks>
    public Task<GetProjectBalanceV1Response> Get10(Get10Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/balances/{balance_id}"),
            [new TemplateParam("project_id", request.ProjectId), new TemplateParam("balance_id", request.BalanceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetProjectBalanceV1Response>(),
            Get10Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Project Balances
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListProjectBalancesV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List13Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a list of outstanding balances for the specified project
    /// </remarks>
    public Task<ListProjectBalancesV1Response> List13(List13Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/balances"),
            [new TemplateParam("project_id", request.ProjectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListProjectBalancesV1Response>(),
            List13Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
