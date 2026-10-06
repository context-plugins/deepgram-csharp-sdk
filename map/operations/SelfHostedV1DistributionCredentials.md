<!-- Generated file — do not edit; regenerated with the SDK. -->

# SelfHostedV1DistributionCredentials — operations

Accessor: `client.SelfHostedV1DistributionCredentials` · Source: `Api/SelfHostedV1DistributionCredentials.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create5

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Create5(Create5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `scopes` ← `Scopes`, `provider` ← `Provider`
- **Returns**: `CreateProjectDistributionCredentialsV1Response`
- **Error**: `ApiException<Create5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Create5Request` | `Requests/SelfHostedV1DistributionCredentials/Create5Request.cs` |
| `V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems` | `Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.cs` |
| `V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider` | `Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider.cs` |
| `CreateProjectDistributionCredentialsV1Request` | `Models/CreateProjectDistributionCredentialsV1Request.cs` |
| `CreateProjectDistributionCredentialsV1Response` | `Models/CreateProjectDistributionCredentialsV1Response.cs` |
| `Create5Error` | `Errors/Create5Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete7

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete7(Delete7Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `DistributionCredentialsId`
- **Returns**: `GetProjectDistributionCredentialsV1Response`
- **Error**: `ApiException<Delete7Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete7Request` | `Requests/SelfHostedV1DistributionCredentials/Delete7Request.cs` |
| `GetProjectDistributionCredentialsV1Response` | `Models/GetProjectDistributionCredentialsV1Response.cs` |
| `Delete7Error` | `Errors/Delete7Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get11

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get11(Get11Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `DistributionCredentialsId`
- **Returns**: `GetProjectDistributionCredentialsV1Response`
- **Error**: `ApiException<Get11Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get11Request` | `Requests/SelfHostedV1DistributionCredentials/Get11Request.cs` |
| `GetProjectDistributionCredentialsV1Response` | `Models/GetProjectDistributionCredentialsV1Response.cs` |
| `Get11Error` | `Errors/Get11Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List17

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List17(List17Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListProjectDistributionCredentialsV1Response`
- **Error**: `ApiException<List17Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List17Request` | `Requests/SelfHostedV1DistributionCredentials/List17Request.cs` |
| `ListProjectDistributionCredentialsV1Response` | `Models/ListProjectDistributionCredentialsV1Response.cs` |
| `List17Error` | `Errors/List17Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

