<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsMembersScopes — operations

Accessor: `client.ManageV1ProjectsMembersScopes` · Source: `Api/ManageV1ProjectsMembersScopes.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List9

- **Signature**: `List9(string projectId, string memberId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListProjectMemberScopesV1Response`
- **Error**: `SdkException<List9Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectMemberScopesV1Response` | `Models/ListProjectMemberScopesV1Response.cs` |
| `List9Error` | `Errors/List9Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Update4

- **Signature**: `Update4(string projectId, string memberId, UpdateProjectMemberScopesV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `UpdateProjectMemberScopesV1Response`
- **Error**: `SdkException<Update4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProjectMemberScopesV1Request` | `Models/UpdateProjectMemberScopesV1Request.cs` |
| `UpdateProjectMemberScopesV1Response` | `Models/UpdateProjectMemberScopesV1Response.cs` |
| `Update4Error` | `Errors/Update4Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

