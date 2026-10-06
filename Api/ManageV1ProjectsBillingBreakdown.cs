using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Deepgram.Core;
using Deepgram.Core.Exceptions;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Core.Request;
using Deepgram.Core.Response;
using Deepgram.Errors;
using Deepgram.Models;
using Deepgram.Requests.ManageV1ProjectsBillingBreakdown;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsBillingBreakdown
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsBillingBreakdown(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Project Billing Breakdown
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BillingBreakdownV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List14Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the billing summary for a specific project, with various filter options or by grouping options.
    /// </remarks>
    public Task<BillingBreakdownV1Response> List14(List14Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/billing/breakdown"),
            [new TemplateParam("project_id", request.ProjectId)],
            [
                new Param("start", request.Start?.ToDate()),
                new Param("end", request.End?.ToDate()),
                new Param("accessor", request.Accessor),
                new Param("deployment", request.Deployment),
                new Param("tag", request.Tag),
                new Param("line_item", request.LineItem),
                new Param("grouping", request.Grouping),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BillingBreakdownV1Response>(),
            List14Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
