<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — Deepgram (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | Deepgram |
| Root namespace | `Deepgram` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `1.0.0` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file and `Deepgram.csproj` — never to the page that carries them. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new DeepgramClientOptions
    {
        ApiKeyAuth = "YOUR_API_KEY",
        JwtAuth = "YOUR_BEARER_TOKEN",
        Environment = ServerEnvironment.Production,
    };
var client = new DeepgramClient(httpClient, options);
```

DI alternative (`services.AddDeepgramClient`):

```csharp
services.AddDeepgramClient(options =>
    {
        options.ApiKeyAuth = "YOUR_API_KEY";
        options.JwtAuth = "YOUR_BEARER_TOKEN";
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

Every API group is a property on the client (e.g. `client.AgentV1SettingsThinkModels`). Source: `DeepgramClient.cs`. The only constructor is `DeepgramClient(HttpClient httpClient, DeepgramClientOptions options)`.

All `DeepgramClientOptions` properties (source: `DeepgramClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `Server` | `ServerOptions` |
| `Hooks` | `IReadOnlyList<SdkHook>` |
| `ApiKeyAuth` | `string?` |
| `JwtAuth` | `string?` |

`RetryOptions` members (namespace `Deepgram.Core.Configuration` — add `using Deepgram.Core.Configuration;`; source: `Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `SdkException<TError>` (`Core/Exceptions/SdkException.cs`) exposing `.Error` of type `TError`. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`Core/ErrorResponse/RawError.cs`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

Core error types (`Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of the 50 typed error classes in `Errors/` | `TryGetRawError(out RawError error): bool` | `Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

```csharp
try
{
    var response = await client.AgentV1SettingsThinkModels.List();
}
catch (SdkException<ListError> ex)
{
    // Case A — typed error
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // Handle 400
    }
    else if (ex.Error.TryGetRawError(out var raw))
    {
        // Any other error status
    }
}
catch (SdkException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **50 operations**, **50 are Case A (typed)** and **0 are Case B (raw)**.

---

## Operations — by controller (24 groups, 50 operations)

Each links to a sub-page with one row per operation: signature with must-pass-explicitly params and defaults, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Default`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Parameter names are literal** — signatures are generated code verbatim; in named arguments use the exact parameter names shown (the cancellation-token parameter is named `ct`) | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `AgentV1SettingsThinkModels` | 1 | [map/operations/AgentV1SettingsThinkModels.md](map/operations/AgentV1SettingsThinkModels.md) |
| `AuthV1Tokens` | 1 | [map/operations/AuthV1Tokens.md](map/operations/AuthV1Tokens.md) |
| `ListenV1Media` | 1 | [map/operations/ListenV1Media.md](map/operations/ListenV1Media.md) |
| `ManageV1Models` | 2 | [map/operations/ManageV1Models.md](map/operations/ManageV1Models.md) |
| `ManageV1Projects` | 5 | [map/operations/ManageV1Projects.md](map/operations/ManageV1Projects.md) |
| `ManageV1ProjectsBillingBalances` | 2 | [map/operations/ManageV1ProjectsBillingBalances.md](map/operations/ManageV1ProjectsBillingBalances.md) |
| `ManageV1ProjectsBillingBreakdown` | 1 | [map/operations/ManageV1ProjectsBillingBreakdown.md](map/operations/ManageV1ProjectsBillingBreakdown.md) |
| `ManageV1ProjectsBillingFields` | 1 | [map/operations/ManageV1ProjectsBillingFields.md](map/operations/ManageV1ProjectsBillingFields.md) |
| `ManageV1ProjectsBillingPurchases` | 1 | [map/operations/ManageV1ProjectsBillingPurchases.md](map/operations/ManageV1ProjectsBillingPurchases.md) |
| `ManageV1ProjectsKeys` | 4 | [map/operations/ManageV1ProjectsKeys.md](map/operations/ManageV1ProjectsKeys.md) |
| `ManageV1ProjectsMembers` | 2 | [map/operations/ManageV1ProjectsMembers.md](map/operations/ManageV1ProjectsMembers.md) |
| `ManageV1ProjectsMembersInvites` | 3 | [map/operations/ManageV1ProjectsMembersInvites.md](map/operations/ManageV1ProjectsMembersInvites.md) |
| `ManageV1ProjectsMembersScopes` | 2 | [map/operations/ManageV1ProjectsMembersScopes.md](map/operations/ManageV1ProjectsMembersScopes.md) |
| `ManageV1ProjectsModels` | 2 | [map/operations/ManageV1ProjectsModels.md](map/operations/ManageV1ProjectsModels.md) |
| `ManageV1ProjectsRequests` | 2 | [map/operations/ManageV1ProjectsRequests.md](map/operations/ManageV1ProjectsRequests.md) |
| `ManageV1ProjectsUsage` | 1 | [map/operations/ManageV1ProjectsUsage.md](map/operations/ManageV1ProjectsUsage.md) |
| `ManageV1ProjectsUsageBreakdown` | 1 | [map/operations/ManageV1ProjectsUsageBreakdown.md](map/operations/ManageV1ProjectsUsageBreakdown.md) |
| `ManageV1ProjectsUsageFields` | 1 | [map/operations/ManageV1ProjectsUsageFields.md](map/operations/ManageV1ProjectsUsageFields.md) |
| `ReadV1Text` | 1 | [map/operations/ReadV1Text.md](map/operations/ReadV1Text.md) |
| `SelfHostedV1DistributionCredentials` | 4 | [map/operations/SelfHostedV1DistributionCredentials.md](map/operations/SelfHostedV1DistributionCredentials.md) |
| `SpeakV1Audio` | 1 | [map/operations/SpeakV1Audio.md](map/operations/SpeakV1Audio.md) |
| `SpeakV2Audio` | 1 | [map/operations/SpeakV2Audio.md](map/operations/SpeakV2Audio.md) |
| `VoiceAgentConfigurations` | 5 | [map/operations/VoiceAgentConfigurations.md](map/operations/VoiceAgentConfigurations.md) |
| `VoiceAgentVariables` | 5 | [map/operations/VoiceAgentVariables.md](map/operations/VoiceAgentVariables.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `Models/` and `Errors/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 139 | `Models/` |
| Unions (`AnyOf`) — variant factories + `TryGet…` | 32 | `Models/AnyOf/` |
| Enums (`StringEnum<T>` / `IntEnum<T>`) — C# member names + wire values | 73 | `Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 50 | `Errors/` |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — build with `Type.FromValue("wire")` or the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`).

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `Deepgram` |
| Operation controllers (`Api/`) | `Deepgram.Api` |
| Records (`Models/`) | `Deepgram.Models` |
| Enums (`Models/Enums/`) | `Deepgram.Models.Enums` |
| AnyOf unions (`Models/AnyOf/`) | `Deepgram.Models.AnyOf` |
| Error classes (`Errors/`) | `Deepgram.Errors` |

---

## Servers & auth

**API key (header `Authorization`).** Set `options.ApiKeyAuth = "<api_key>"`; sent as the `Authorization` request header. Use `Authorization: Token <API_KEY>`
Example: `Authorization: Token 12345abcdef`


**Bearer token.** Set `options.JwtAuth = "<token>"`. Use `Authorization: Bearer <JWT>`
Example: `Authorization: Bearer eyJhbGciOiJ...`


**Environments.** `options.Environment` selects the target environment (`Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `production` | Production |
| `ServerEnvironment.Environment2` | `environment2` | Base |

**1 server group.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | `Environment2` base URL | Override point |
| --- | --- | --- | --- |
| `Default` | `https://agent.deepgram.com` | `https://api.deepgram.com` | `options.Server.Default.Production.BaseUrl` (and the other environments) |

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

