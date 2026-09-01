<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingBalances — operations

Accessor: `client.ManageV1ProjectsBillingBalances` · Source: `Api/ManageV1ProjectsBillingBalances.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get10

- **Signature**: `Get10(string projectId, string balanceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetProjectBalanceV1Response`
- **Error**: `SdkException<Get10Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProjectBalanceV1Response` | `Models/GetProjectBalanceV1Response.cs` |
| `Get10Error` | `Errors/Get10Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List13

- **Signature**: `List13(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListProjectBalancesV1Response`
- **Error**: `SdkException<List13Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProjectBalancesV1Response` | `Models/ListProjectBalancesV1Response.cs` |
| `List13Error` | `Errors/List13Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

