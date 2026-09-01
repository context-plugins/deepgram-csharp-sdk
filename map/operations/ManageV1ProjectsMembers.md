<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsMembers — operations

Accessor: `client.ManageV1ProjectsMembers` · Source: `Api/ManageV1ProjectsMembers.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Delete5

- **Signature**: `Delete5(string projectId, string memberId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteProjectMemberV1Response`
- **Error**: `SdkException<Delete5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteProjectMemberV1Response` | `Models/DeleteProjectMemberV1Response.cs` |
| `Delete5Error` | `Errors/Delete5Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List8

- **Signature**: `List8(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListProjectMembersV1Response`
- **Error**: `SdkException<List8Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectMembersV1Response` | `Models/ListProjectMembersV1Response.cs` |
| `List8Error` | `Errors/List8Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

