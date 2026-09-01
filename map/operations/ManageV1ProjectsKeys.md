<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsKeys — operations

Accessor: `client.ManageV1ProjectsKeys` · Source: `Api/ManageV1ProjectsKeys.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create3

- **Signature**: `Create3(string projectId, CreateKeyV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CreateKeyV1Response`
- **Error**: `SdkException<Create3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateKeyV1Request` | `Models/AnyOf/CreateKeyV1Request.cs` |
| `CreateKeyV1Response` | `Models/CreateKeyV1Response.cs` |
| `Create3Error` | `Errors/Create3Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete4

- **Signature**: `Delete4(string projectId, string keyId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteProjectKeyV1Response`
- **Error**: `SdkException<Delete4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteProjectKeyV1Response` | `Models/DeleteProjectKeyV1Response.cs` |
| `Delete4Error` | `Errors/Delete4Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get6

- **Signature**: `Get6(string projectId, string keyId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetProjectKeyV1Response`
- **Error**: `SdkException<Get6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProjectKeyV1Response` | `Models/GetProjectKeyV1Response.cs` |
| `Get6Error` | `Errors/Get6Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List7

- **Signature**: `List7(string projectId, V1ProjectsProjectIdKeysGetParametersStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `status` ← `status`
- **Returns**: `ListProjectKeysV1Response`
- **Error**: `SdkException<List7Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ProjectsProjectIdKeysGetParametersStatus` | `Models/Enums/V1ProjectsProjectIdKeysGetParametersStatus.cs` |
| `ListProjectKeysV1Response` | `Models/ListProjectKeysV1Response.cs` |
| `List7Error` | `Errors/List7Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

