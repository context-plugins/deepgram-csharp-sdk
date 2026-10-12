<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1Models — operations

Accessor: `client.ManageV1Models` · Source: `src/Deepgram/Api/ManageV1Models.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get5

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get5(Get5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ModelId`
- **Returns**: `GetModelV1Response`
- **Error**: `ApiException<Get5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get5Request` | `src/Deepgram/Requests/ManageV1Models/Get5Request.cs` |
| `GetModelV1Response` | `src/Deepgram/Models/AnyOf/GetModelV1Response.cs` |
| `Get5Error` | `src/Deepgram/Errors/Get5Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List6

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List6(List6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_outdated` ← `IncludeOutdated`
- **Returns**: `ListModelsV1Response`
- **Error**: `ApiException<List6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List6Request` | `src/Deepgram/Requests/ManageV1Models/List6Request.cs` |
| `ListModelsV1Response` | `src/Deepgram/Models/ListModelsV1Response.cs` |
| `List6Error` | `src/Deepgram/Errors/List6Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

