<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1Models — operations

Accessor: `client.ManageV1Models` · Source: `Api/ManageV1Models.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get5

- **Signature**: `Get5(string modelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetModelV1Response`
- **Error**: `SdkException<Get5Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetModelV1Response` | `Models/AnyOf/GetModelV1Response.cs` |
| `Get5Error` | `Errors/Get5Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List6

- **Signature**: `List6(bool? includeOutdated, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeOutdated` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include_outdated` ← `includeOutdated`
- **Returns**: `ListModelsV1Response`
- **Error**: `SdkException<List6Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListModelsV1Response` | `Models/ListModelsV1Response.cs` |
| `List6Error` | `Errors/List6Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

