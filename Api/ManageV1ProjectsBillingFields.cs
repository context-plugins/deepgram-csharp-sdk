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
using Deepgram.Requests.ManageV1ProjectsBillingFields;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsBillingFields
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsBillingFields(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// List Project Billing Fields
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBillingFieldsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List15Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the accessors, deployment types, tags, and line items used for billing data in the specified time period. Use this endpoint if you want to filter your results from the Billing Breakdown endpoint and want to know what filters are available.
    /// </remarks>
    public Task<ListBillingFieldsV1Response> List15(List15Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/billing/fields"),
            [new TemplateParam("project_id", request.ProjectId)],
            [new Param("start", request.Start?.ToDate()), new Param("end", request.End?.ToDate())],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBillingFieldsV1Response>(),
            List15Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
