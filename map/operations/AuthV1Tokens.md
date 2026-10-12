<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthV1Tokens — operations

Accessor: `client.AuthV1Tokens` · Source: `src/Deepgram/Api/AuthV1Tokens.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Grant

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Grant(GrantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GrantV1Response`
- **Error**: `ApiException<GrantError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GrantRequest` | `src/Deepgram/Requests/AuthV1Tokens/GrantRequest.cs` |
| `GrantV1Request` | `src/Deepgram/Models/GrantV1Request.cs` |
| `GrantV1Response` | `src/Deepgram/Models/GrantV1Response.cs` |
| `GrantError` | `src/Deepgram/Errors/GrantError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

