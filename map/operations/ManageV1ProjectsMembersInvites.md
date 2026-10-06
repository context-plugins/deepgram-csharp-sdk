<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsMembersInvites — operations

Accessor: `client.ManageV1ProjectsMembersInvites` · Source: `Api/ManageV1ProjectsMembersInvites.cs` · 3 operations

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
| `Create4Request` | `Requests/ManageV1ProjectsMembersInvites/Create4Request.cs` |
| `CreateProjectInviteV1Request` | `Models/CreateProjectInviteV1Request.cs` |
| `CreateProjectInviteV1Response` | `Models/CreateProjectInviteV1Response.cs` |
| `Create4Error` | `Errors/Create4Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete6

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete6(Delete6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Email`
- **Returns**: `DeleteProjectInviteV1Response`
- **Error**: `ApiException<Delete6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete6Request` | `Requests/ManageV1ProjectsMembersInvites/Delete6Request.cs` |
| `DeleteProjectInviteV1Response` | `Models/DeleteProjectInviteV1Response.cs` |
| `Delete6Error` | `Errors/Delete6Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List10

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List10(List10Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListProjectInvitesV1Response`
- **Error**: `ApiException<List10Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List10Request` | `Requests/ManageV1ProjectsMembersInvites/List10Request.cs` |
| `ListProjectInvitesV1Response` | `Models/ListProjectInvitesV1Response.cs` |
| `List10Error` | `Errors/List10Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

