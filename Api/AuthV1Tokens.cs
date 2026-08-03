using System;
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

public sealed class AuthV1Tokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal AuthV1Tokens(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Token-based Authentication
    /// </summary>
    /// <param name="authorization">Use <c>Authorization: Token &lt;API_KEY&gt;</c> Example: <c>Authorization: Token 12345abcdef</c></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantV1Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GrantError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a temporary JSON Web Token (JWT) with a 30-second (by default) TTL and usage::write permission for core voice APIs, requiring an API key with Member or higher authorization. Tokens created with this endpoint will not work with the Manage APIs.
    /// </remarks>
    public Task<GrantV1Response> Grant(string authorization,
        GrantV1Request? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/auth/grant"),
            [],
            [],
            [new HeaderParam("Authorization", authorization), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GrantV1Response>(),
            GrantErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
