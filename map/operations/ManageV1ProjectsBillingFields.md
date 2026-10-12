<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingFields — operations

Accessor: `client.ManageV1ProjectsBillingFields` · Source: `src/Deepgram/Api/ManageV1ProjectsBillingFields.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List15

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List15(List15Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `start` ← `Start`, `end` ← `End`
- **Returns**: `ListBillingFieldsV1Response`
- **Error**: `ApiException<List15Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List15Request` | `src/Deepgram/Requests/ManageV1ProjectsBillingFields/List15Request.cs` |
| `ListBillingFieldsV1Response` | `src/Deepgram/Models/ListBillingFieldsV1Response.cs` |
| `List15Error` | `src/Deepgram/Errors/List15Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

