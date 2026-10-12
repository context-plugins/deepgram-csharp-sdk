<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingPurchases — operations

Accessor: `client.ManageV1ProjectsBillingPurchases` · Source: `src/Deepgram/Api/ManageV1ProjectsBillingPurchases.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List16

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List16(List16Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `limit` ← `Limit`
- **Returns**: `ListProjectPurchasesV1Response`
- **Error**: `ApiException<List16Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List16Request` | `src/Deepgram/Requests/ManageV1ProjectsBillingPurchases/List16Request.cs` |
| `ListProjectPurchasesV1Response` | `src/Deepgram/Models/ListProjectPurchasesV1Response.cs` |
| `List16Error` | `src/Deepgram/Errors/List16Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

