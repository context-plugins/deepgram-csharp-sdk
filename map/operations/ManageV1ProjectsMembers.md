<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsMembers — operations

Accessor: `client.ManageV1ProjectsMembers` · Source: `src/Deepgram/Api/ManageV1ProjectsMembers.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Delete5

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete5(Delete5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `MemberId`
- **Returns**: `DeleteProjectMemberV1Response`
- **Error**: `ApiException<Delete5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete5Request` | `src/Deepgram/Requests/ManageV1ProjectsMembers/Delete5Request.cs` |
| `DeleteProjectMemberV1Response` | `src/Deepgram/Models/DeleteProjectMemberV1Response.cs` |
| `Delete5Error` | `src/Deepgram/Errors/Delete5Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List8

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List8(List8Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListProjectMembersV1Response`
- **Error**: `ApiException<List8Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List8Request` | `src/Deepgram/Requests/ManageV1ProjectsMembers/List8Request.cs` |
| `ListProjectMembersV1Response` | `src/Deepgram/Models/ListProjectMembersV1Response.cs` |
| `List8Error` | `src/Deepgram/Errors/List8Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

