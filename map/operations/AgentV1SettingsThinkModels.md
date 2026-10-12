<!-- Generated file — do not edit; regenerated with the SDK. -->

# AgentV1SettingsThinkModels — operations

Accessor: `client.AgentV1SettingsThinkModels` · Source: `src/Deepgram/Api/AgentV1SettingsThinkModels.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AgentThinkModelsV1Response`
- **Error**: `ApiException<ListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AgentThinkModelsV1Response` | `src/Deepgram/Models/AgentThinkModelsV1Response.cs` |
| `ListError` | `src/Deepgram/Errors/ListError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

