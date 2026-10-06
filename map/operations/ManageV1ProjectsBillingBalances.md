<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingBalances — operations

Accessor: `client.ManageV1ProjectsBillingBalances` · Source: `Api/ManageV1ProjectsBillingBalances.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get10

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get10(Get10Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `BalanceId`
- **Returns**: `GetProjectBalanceV1Response`
- **Error**: `ApiException<Get10Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get10Request` | `Requests/ManageV1ProjectsBillingBalances/Get10Request.cs` |
| `GetProjectBalanceV1Response` | `Models/GetProjectBalanceV1Response.cs` |
| `Get10Error` | `Errors/Get10Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List13

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List13(List13Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListProjectBalancesV1Response`
- **Error**: `ApiException<List13Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List13Request` | `Requests/ManageV1ProjectsBillingBalances/List13Request.cs` |
| `ListProjectBalancesV1Response` | `Models/ListProjectBalancesV1Response.cs` |
| `List13Error` | `Errors/List13Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

