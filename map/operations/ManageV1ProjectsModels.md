<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsModels — operations

Accessor: `client.ManageV1ProjectsModels` · Source: `src/Deepgram/Api/ManageV1ProjectsModels.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get4

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get4(Get4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `ModelId`
- **Returns**: `GetModelV1Response`
- **Error**: `ApiException<Get4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get4Request` | `src/Deepgram/Requests/ManageV1ProjectsModels/Get4Request.cs` |
| `GetModelV1Response` | `src/Deepgram/Models/AnyOf/GetModelV1Response.cs` |
| `Get4Error` | `src/Deepgram/Errors/Get4Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List5

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List5(List5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `include_outdated` ← `IncludeOutdated`
- **Returns**: `ListModelsV1Response`
- **Error**: `ApiException<List5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List5Request` | `src/Deepgram/Requests/ManageV1ProjectsModels/List5Request.cs` |
| `ListModelsV1Response` | `src/Deepgram/Models/ListModelsV1Response.cs` |
| `List5Error` | `src/Deepgram/Errors/List5Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

