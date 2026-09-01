<!-- Generated file — do not edit; regenerated with the SDK. -->

# AgentV1SettingsThinkModels — operations

Accessor: `client.AgentV1SettingsThinkModels` · Source: `Api/AgentV1SettingsThinkModels.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List

- **Signature**: `List(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AgentThinkModelsV1Response`
- **Error**: `SdkException<ListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AgentThinkModelsV1Response` | `Models/AgentThinkModelsV1Response.cs` |
| `ListError` | `Errors/ListError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

