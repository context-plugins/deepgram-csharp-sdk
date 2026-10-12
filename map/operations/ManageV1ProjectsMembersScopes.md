<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsMembersScopes — operations

Accessor: `client.ManageV1ProjectsMembersScopes` · Source: `src/Deepgram/Api/ManageV1ProjectsMembersScopes.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List9

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List9(List9Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `MemberId`
- **Returns**: `ListProjectMemberScopesV1Response`
- **Error**: `ApiException<List9Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List9Request` | `src/Deepgram/Requests/ManageV1ProjectsMembersScopes/List9Request.cs` |
| `ListProjectMemberScopesV1Response` | `src/Deepgram/Models/ListProjectMemberScopesV1Response.cs` |
| `List9Error` | `src/Deepgram/Errors/List9Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Update4

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Update4(Update4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `MemberId`
- **Returns**: `UpdateProjectMemberScopesV1Response`
- **Error**: `ApiException<Update4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Update4Request` | `src/Deepgram/Requests/ManageV1ProjectsMembersScopes/Update4Request.cs` |
| `UpdateProjectMemberScopesV1Request` | `src/Deepgram/Models/UpdateProjectMemberScopesV1Request.cs` |
| `UpdateProjectMemberScopesV1Response` | `src/Deepgram/Models/UpdateProjectMemberScopesV1Response.cs` |
| `Update4Error` | `src/Deepgram/Errors/Update4Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

