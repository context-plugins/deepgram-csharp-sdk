<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthV1Tokens — operations

Accessor: `client.AuthV1Tokens` · Source: `Api/AuthV1Tokens.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Grant

- **Signature**: `Grant(GrantV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `GrantV1Response`
- **Error**: `SdkException<GrantError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GrantV1Request` | `Models/GrantV1Request.cs` |
| `GrantV1Response` | `Models/GrantV1Response.cs` |
| `GrantError` | `Errors/GrantError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

