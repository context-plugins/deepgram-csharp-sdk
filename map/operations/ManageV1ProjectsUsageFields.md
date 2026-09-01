<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsUsageFields — operations

Accessor: `client.ManageV1ProjectsUsageFields` · Source: `Api/ManageV1ProjectsUsageFields.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List12

- **Signature**: `List12(string projectId, DateTimeOffset? start, DateTimeOffset? end, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `start` — nullable, no default → **must pass explicitly**
  - `end` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `start` ← `start`, `end` ← `end`
- **Returns**: `UsageFieldsV1Response`
- **Error**: `SdkException<List12Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsageFieldsV1Response` | `Models/UsageFieldsV1Response.cs` |
| `List12Error` | `Errors/List12Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

