<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1Projects — operations

Accessor: `client.ManageV1Projects` · Source: `Api/ManageV1Projects.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Delete3

- **Signature**: `Delete3(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteProjectV1Response`
- **Error**: `SdkException<Delete3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteProjectV1Response` | `Models/DeleteProjectV1Response.cs` |
| `Delete3Error` | `Errors/Delete3Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get3

- **Signature**: `Get3(string projectId, double? page, double? limit = 10d, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `10d`
- **Query params (wire ← C#)**: `limit` ← `limit`, `page` ← `page`
- **Returns**: `GetProjectV1Response`
- **Error**: `SdkException<Get3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProjectV1Response` | `Models/GetProjectV1Response.cs` |
| `Get3Error` | `Errors/Get3Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Leave

- **Signature**: `Leave(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LeaveProjectV1Response`
- **Error**: `SdkException<LeaveError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LeaveProjectV1Response` | `Models/LeaveProjectV1Response.cs` |
| `LeaveError` | `Errors/LeaveError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List4

- **Signature**: `List4(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListProjectsV1Response`
- **Error**: `SdkException<List4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectsV1Response` | `Models/ListProjectsV1Response.cs` |
| `List4Error` | `Errors/List4Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Update3

- **Signature**: `Update3(string projectId, UpdateProjectV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UpdateProjectV1Response`
- **Error**: `SdkException<Update3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProjectV1Request` | `Models/UpdateProjectV1Request.cs` |
| `UpdateProjectV1Response` | `Models/UpdateProjectV1Response.cs` |
| `Update3Error` | `Errors/Update3Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

