<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1Projects — operations

Accessor: `client.ManageV1Projects` · Source: `src/Deepgram/Api/ManageV1Projects.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Delete3

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete3(Delete3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `DeleteProjectV1Response`
- **Error**: `ApiException<Delete3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete3Request` | `src/Deepgram/Requests/ManageV1Projects/Delete3Request.cs` |
| `DeleteProjectV1Response` | `src/Deepgram/Models/DeleteProjectV1Response.cs` |
| `Delete3Error` | `src/Deepgram/Errors/Delete3Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Get3

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get3(Get3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `page` ← `Page`
- **Returns**: `GetProjectV1Response`
- **Error**: `ApiException<Get3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get3Request` | `src/Deepgram/Requests/ManageV1Projects/Get3Request.cs` |
| `GetProjectV1Response` | `src/Deepgram/Models/GetProjectV1Response.cs` |
| `Get3Error` | `src/Deepgram/Errors/Get3Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Leave

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Leave(LeaveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `LeaveProjectV1Response`
- **Error**: `ApiException<LeaveError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LeaveRequest` | `src/Deepgram/Requests/ManageV1Projects/LeaveRequest.cs` |
| `LeaveProjectV1Response` | `src/Deepgram/Models/LeaveProjectV1Response.cs` |
| `LeaveError` | `src/Deepgram/Errors/LeaveError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List4

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List4(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ListProjectsV1Response`
- **Error**: `ApiException<List4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectsV1Response` | `src/Deepgram/Models/ListProjectsV1Response.cs` |
| `List4Error` | `src/Deepgram/Errors/List4Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Update3

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Update3(Update3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `UpdateProjectV1Response`
- **Error**: `ApiException<Update3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Update3Request` | `src/Deepgram/Requests/ManageV1Projects/Update3Request.cs` |
| `UpdateProjectV1Request` | `src/Deepgram/Models/UpdateProjectV1Request.cs` |
| `UpdateProjectV1Response` | `src/Deepgram/Models/UpdateProjectV1Response.cs` |
| `Update3Error` | `src/Deepgram/Errors/Update3Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

