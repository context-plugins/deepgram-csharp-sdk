<!-- Generated file — do not edit; regenerated with the SDK. -->

# SelfHostedV1DistributionCredentials — operations

Accessor: `client.SelfHostedV1DistributionCredentials` · Source: `src/Deepgram/Api/SelfHostedV1DistributionCredentials.cs` · 4 operations

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
| `Create5Request` | `src/Deepgram/Requests/SelfHostedV1DistributionCredentials/Create5Request.cs` |
| `V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.cs` |
| `V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider.cs` |
| `CreateProjectDistributionCredentialsV1Request` | `src/Deepgram/Models/CreateProjectDistributionCredentialsV1Request.cs` |
| `CreateProjectDistributionCredentialsV1Response` | `src/Deepgram/Models/CreateProjectDistributionCredentialsV1Response.cs` |
| `Create5Error` | `src/Deepgram/Errors/Create5Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Delete7

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete7(Delete7Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `DistributionCredentialsId`
- **Returns**: `GetProjectDistributionCredentialsV1Response`
- **Error**: `ApiException<Delete7Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete7Request` | `src/Deepgram/Requests/SelfHostedV1DistributionCredentials/Delete7Request.cs` |
| `GetProjectDistributionCredentialsV1Response` | `src/Deepgram/Models/GetProjectDistributionCredentialsV1Response.cs` |
| `Delete7Error` | `src/Deepgram/Errors/Delete7Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Get11

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get11(Get11Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `DistributionCredentialsId`
- **Returns**: `GetProjectDistributionCredentialsV1Response`
- **Error**: `ApiException<Get11Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get11Request` | `src/Deepgram/Requests/SelfHostedV1DistributionCredentials/Get11Request.cs` |
| `GetProjectDistributionCredentialsV1Response` | `src/Deepgram/Models/GetProjectDistributionCredentialsV1Response.cs` |
| `Get11Error` | `src/Deepgram/Errors/Get11Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List17

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List17(List17Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListProjectDistributionCredentialsV1Response`
- **Error**: `ApiException<List17Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List17Request` | `src/Deepgram/Requests/SelfHostedV1DistributionCredentials/List17Request.cs` |
| `ListProjectDistributionCredentialsV1Response` | `src/Deepgram/Models/ListProjectDistributionCredentialsV1Response.cs` |
| `List17Error` | `src/Deepgram/Errors/List17Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

