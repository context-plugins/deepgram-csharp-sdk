<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsRequests — operations

Accessor: `client.ManageV1ProjectsRequests` · Source: `src/Deepgram/Api/ManageV1ProjectsRequests.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get7

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get7(Get7Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `RequestId`
- **Returns**: `GetProjectRequestV1Response`
- **Error**: `ApiException<Get7Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get7Request` | `src/Deepgram/Requests/ManageV1ProjectsRequests/Get7Request.cs` |
| `GetProjectRequestV1Response` | `src/Deepgram/Models/GetProjectRequestV1Response.cs` |
| `Get7Error` | `src/Deepgram/Errors/Get7Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List11

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List11(List11Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `start` ← `Start`, `end` ← `End`, `limit` ← `Limit`, `page` ← `Page`, `accessor` ← `Accessor`, `request_id` ← `RequestId`, `deployment` ← `Deployment`, `endpoint` ← `Endpoint`, `method` ← `Method`, `status` ← `Status`
- **Returns**: `ListProjectRequestsV1Response`
- **Error**: `ApiException<List11Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List11Request` | `src/Deepgram/Requests/ManageV1ProjectsRequests/List11Request.cs` |
| `V1ProjectsProjectIdRequestsGetParametersDeployment` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdRequestsGetParametersDeployment.cs` |
| `V1ProjectsProjectIdRequestsGetParametersEndpoint` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdRequestsGetParametersEndpoint.cs` |
| `V1ProjectsProjectIdRequestsGetParametersMethod` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdRequestsGetParametersMethod.cs` |
| `V1ProjectsProjectIdRequestsGetParametersStatus` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdRequestsGetParametersStatus.cs` |
| `ListProjectRequestsV1Response` | `src/Deepgram/Models/ListProjectRequestsV1Response.cs` |
| `List11Error` | `src/Deepgram/Errors/List11Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

