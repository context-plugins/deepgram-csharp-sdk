<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingPurchases — operations

Accessor: `client.ManageV1ProjectsBillingPurchases` · Source: `Api/ManageV1ProjectsBillingPurchases.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List16

- **Signature**: `List16(string projectId, double? limit = 10d, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `limit` = `10d`
- **Query params (wire ← C#)**: `limit` ← `limit`
- **Returns**: `ListProjectPurchasesV1Response`
- **Error**: `SdkException<List16Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectPurchasesV1Response` | `Models/ListProjectPurchasesV1Response.cs` |
| `List16Error` | `Errors/List16Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

