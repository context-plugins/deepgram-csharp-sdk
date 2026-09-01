<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsRequests — operations

Accessor: `client.ManageV1ProjectsRequests` · Source: `Api/ManageV1ProjectsRequests.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get7

- **Signature**: `Get7(string projectId, string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetProjectRequestV1Response`
- **Error**: `SdkException<Get7Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProjectRequestV1Response` | `Models/GetProjectRequestV1Response.cs` |
| `Get7Error` | `Errors/Get7Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List11

- **Signature**: `List11(string projectId, DateTimeOffset? start, DateTimeOffset? end, double? page, string? accessor, string? requestId, V1ProjectsProjectIdRequestsGetParametersDeployment? deployment, V1ProjectsProjectIdRequestsGetParametersEndpoint? endpoint, V1ProjectsProjectIdRequestsGetParametersMethod? method, V1ProjectsProjectIdRequestsGetParametersStatus? status, double? limit = 10d, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`start` … `status`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `limit` = `10d`
- **Query params (wire ← C#)**: `start` ← `start`, `end` ← `end`, `limit` ← `limit`, `page` ← `page`, `accessor` ← `accessor`, `request_id` ← `requestId`, `deployment` ← `deployment`, `endpoint` ← `endpoint`, `method` ← `method`, `status` ← `status`
- **Returns**: `ListProjectRequestsV1Response`
- **Error**: `SdkException<List11Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ProjectsProjectIdRequestsGetParametersDeployment` | `Models/Enums/V1ProjectsProjectIdRequestsGetParametersDeployment.cs` |
| `V1ProjectsProjectIdRequestsGetParametersEndpoint` | `Models/Enums/V1ProjectsProjectIdRequestsGetParametersEndpoint.cs` |
| `V1ProjectsProjectIdRequestsGetParametersMethod` | `Models/Enums/V1ProjectsProjectIdRequestsGetParametersMethod.cs` |
| `V1ProjectsProjectIdRequestsGetParametersStatus` | `Models/Enums/V1ProjectsProjectIdRequestsGetParametersStatus.cs` |
| `ListProjectRequestsV1Response` | `Models/ListProjectRequestsV1Response.cs` |
| `List11Error` | `Errors/List11Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

