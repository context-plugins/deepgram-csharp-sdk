<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsMembersInvites — operations

Accessor: `client.ManageV1ProjectsMembersInvites` · Source: `Api/ManageV1ProjectsMembersInvites.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create4

- **Signature**: `Create4(string projectId, CreateProjectInviteV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CreateProjectInviteV1Response`
- **Error**: `SdkException<Create4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProjectInviteV1Request` | `Models/CreateProjectInviteV1Request.cs` |
| `CreateProjectInviteV1Response` | `Models/CreateProjectInviteV1Response.cs` |
| `Create4Error` | `Errors/Create4Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete6

- **Signature**: `Delete6(string projectId, string email, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteProjectInviteV1Response`
- **Error**: `SdkException<Delete6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteProjectInviteV1Response` | `Models/DeleteProjectInviteV1Response.cs` |
| `Delete6Error` | `Errors/Delete6Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List10

- **Signature**: `List10(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListProjectInvitesV1Response`
- **Error**: `SdkException<List10Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectInvitesV1Response` | `Models/ListProjectInvitesV1Response.cs` |
| `List10Error` | `Errors/List10Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

