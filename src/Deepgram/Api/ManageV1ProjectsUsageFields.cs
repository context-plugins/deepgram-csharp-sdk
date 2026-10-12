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
using Deepgram.Requests.ManageV1ProjectsUsageFields;

namespace Deepgram.Api;

public sealed class ManageV1ProjectsUsageFields
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageV1ProjectsUsageFields(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// List Project Usage Fields
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageFieldsV1Response"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="List12Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the features, models, tags, languages, and processing method used for requests in the specified project
    /// </remarks>
    public Task<UsageFieldsV1Response> List12(List12Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/projects/{project_id}/usage/fields"),
            [new TemplateParam("project_id", request.ProjectId)],
            [new Param("start", request.Start?.ToDate()), new Param("end", request.End?.ToDate())],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsageFieldsV1Response>(),
            List12Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
