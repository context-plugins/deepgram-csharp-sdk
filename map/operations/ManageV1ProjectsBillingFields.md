<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingFields — operations

Accessor: `client.ManageV1ProjectsBillingFields` · Source: `Api/ManageV1ProjectsBillingFields.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List15

- **Signature**: `List15(string projectId, DateTimeOffset? start, DateTimeOffset? end, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `start` — nullable, no default → **must pass explicitly**
  - `end` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `start` ← `start`, `end` ← `end`
- **Returns**: `ListBillingFieldsV1Response`
- **Error**: `SdkException<List15Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListBillingFieldsV1Response` | `Models/ListBillingFieldsV1Response.cs` |
| `List15Error` | `Errors/List15Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

