<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsMembersInvites — operations

Accessor: `client.ManageV1ProjectsMembersInvites` · Source: `src/Deepgram/Api/ManageV1ProjectsMembersInvites.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create4

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Create4(Create4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `CreateProjectInviteV1Response`
- **Error**: `ApiException<Create4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Create4Request` | `src/Deepgram/Requests/ManageV1ProjectsMembersInvites/Create4Request.cs` |
| `CreateProjectInviteV1Request` | `src/Deepgram/Models/CreateProjectInviteV1Request.cs` |
| `CreateProjectInviteV1Response` | `src/Deepgram/Models/CreateProjectInviteV1Response.cs` |
| `Create4Error` | `src/Deepgram/Errors/Create4Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Delete6

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete6(Delete6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Email`
- **Returns**: `DeleteProjectInviteV1Response`
- **Error**: `ApiException<Delete6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete6Request` | `src/Deepgram/Requests/ManageV1ProjectsMembersInvites/Delete6Request.cs` |
| `DeleteProjectInviteV1Response` | `src/Deepgram/Models/DeleteProjectInviteV1Response.cs` |
| `Delete6Error` | `src/Deepgram/Errors/Delete6Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List10

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List10(List10Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListProjectInvitesV1Response`
- **Error**: `ApiException<List10Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List10Request` | `src/Deepgram/Requests/ManageV1ProjectsMembersInvites/List10Request.cs` |
| `ListProjectInvitesV1Response` | `src/Deepgram/Models/ListProjectInvitesV1Response.cs` |
| `List10Error` | `src/Deepgram/Errors/List10Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

