<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsKeys — operations

Accessor: `client.ManageV1ProjectsKeys` · Source: `Api/ManageV1ProjectsKeys.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create3

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Create3(Create3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `CreateKeyV1Response`
- **Error**: `ApiException<Create3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Create3Request` | `Requests/ManageV1ProjectsKeys/Create3Request.cs` |
| `CreateKeyV1Request` | `Models/AnyOf/CreateKeyV1Request.cs` |
| `CreateKeyV1Response` | `Models/CreateKeyV1Response.cs` |
| `Create3Error` | `Errors/Create3Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete4

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete4(Delete4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `KeyId`
- **Returns**: `DeleteProjectKeyV1Response`
- **Error**: `ApiException<Delete4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete4Request` | `Requests/ManageV1ProjectsKeys/Delete4Request.cs` |
| `DeleteProjectKeyV1Response` | `Models/DeleteProjectKeyV1Response.cs` |
| `Delete4Error` | `Errors/Delete4Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get6

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get6(Get6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `KeyId`
- **Returns**: `GetProjectKeyV1Response`
- **Error**: `ApiException<Get6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get6Request` | `Requests/ManageV1ProjectsKeys/Get6Request.cs` |
| `GetProjectKeyV1Response` | `Models/GetProjectKeyV1Response.cs` |
| `Get6Error` | `Errors/Get6Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List7

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List7(List7Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `status` ← `Status`
- **Returns**: `ListProjectKeysV1Response`
- **Error**: `ApiException<List7Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List7Request` | `Requests/ManageV1ProjectsKeys/List7Request.cs` |
| `V1ProjectsProjectIdKeysGetParametersStatus` | `Models/Enums/V1ProjectsProjectIdKeysGetParametersStatus.cs` |
| `ListProjectKeysV1Response` | `Models/ListProjectKeysV1Response.cs` |
| `List7Error` | `Errors/List7Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

