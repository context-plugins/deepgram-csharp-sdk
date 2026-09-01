<!-- Generated file — do not edit; regenerated with the SDK. -->

# SelfHostedV1DistributionCredentials — operations

Accessor: `client.SelfHostedV1DistributionCredentials` · Source: `Api/SelfHostedV1DistributionCredentials.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create5

- **Signature**: `Create5(string projectId, IReadOnlyList<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>? scopes, V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider? provider, CreateProjectDistributionCredentialsV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `scopes` — nullable, no default → **must pass explicitly**
  - `provider` — nullable, no default → **must pass explicitly**
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `scopes` ← `scopes`, `provider` ← `provider`
- **Returns**: `CreateProjectDistributionCredentialsV1Response`
- **Error**: `SdkException<Create5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems` | `Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.cs` |
| `V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider` | `Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider.cs` |
| `CreateProjectDistributionCredentialsV1Request` | `Models/CreateProjectDistributionCredentialsV1Request.cs` |
| `CreateProjectDistributionCredentialsV1Response` | `Models/CreateProjectDistributionCredentialsV1Response.cs` |
| `Create5Error` | `Errors/Create5Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete7

- **Signature**: `Delete7(string projectId, string distributionCredentialsId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetProjectDistributionCredentialsV1Response`
- **Error**: `SdkException<Delete7Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProjectDistributionCredentialsV1Response` | `Models/GetProjectDistributionCredentialsV1Response.cs` |
| `Delete7Error` | `Errors/Delete7Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get11

- **Signature**: `Get11(string projectId, string distributionCredentialsId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetProjectDistributionCredentialsV1Response`
- **Error**: `SdkException<Get11Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProjectDistributionCredentialsV1Response` | `Models/GetProjectDistributionCredentialsV1Response.cs` |
| `Get11Error` | `Errors/Get11Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List17

- **Signature**: `List17(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListProjectDistributionCredentialsV1Response`
- **Error**: `SdkException<List17Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectDistributionCredentialsV1Response` | `Models/ListProjectDistributionCredentialsV1Response.cs` |
| `List17Error` | `Errors/List17Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

