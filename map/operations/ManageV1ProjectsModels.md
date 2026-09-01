<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsModels — operations

Accessor: `client.ManageV1ProjectsModels` · Source: `Api/ManageV1ProjectsModels.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get4

- **Signature**: `Get4(string projectId, string modelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetModelV1Response`
- **Error**: `SdkException<Get4Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetModelV1Response` | `Models/AnyOf/GetModelV1Response.cs` |
| `Get4Error` | `Errors/Get4Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List5

- **Signature**: `List5(string projectId, bool? includeOutdated, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeOutdated` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include_outdated` ← `includeOutdated`
- **Returns**: `ListModelsV1Response`
- **Error**: `SdkException<List5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListModelsV1Response` | `Models/ListModelsV1Response.cs` |
| `List5Error` | `Errors/List5Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

