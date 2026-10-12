<!-- Generated file — do not edit; regenerated with the SDK. -->

# VoiceAgentVariables — operations

Accessor: `client.VoiceAgentVariables` · Source: `src/Deepgram/Api/VoiceAgentVariables.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Create2(Create2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `AgentVariableV1`
- **Error**: `ApiException<Create2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Create2Request` | `src/Deepgram/Requests/VoiceAgentVariables/Create2Request.cs` |
| `CreateAgentVariableV1Request` | `src/Deepgram/Models/CreateAgentVariableV1Request.cs` |
| `AgentVariableV1` | `src/Deepgram/Models/AgentVariableV1.cs` |
| `Create2Error` | `src/Deepgram/Errors/Create2Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Delete2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete2(Delete2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `VariableId`
- **Returns**: `object`
- **Error**: `ApiException<Delete2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete2Request` | `src/Deepgram/Requests/VoiceAgentVariables/Delete2Request.cs` |
| `Delete2Error` | `src/Deepgram/Errors/Delete2Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Get2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get2(Get2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `VariableId`
- **Returns**: `AgentVariableV1`
- **Error**: `ApiException<Get2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get2Request` | `src/Deepgram/Requests/VoiceAgentVariables/Get2Request.cs` |
| `AgentVariableV1` | `src/Deepgram/Models/AgentVariableV1.cs` |
| `Get2Error` | `src/Deepgram/Errors/Get2Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List3

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List3(List3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListAgentVariablesV1Response`
- **Error**: `ApiException<List3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List3Request` | `src/Deepgram/Requests/VoiceAgentVariables/List3Request.cs` |
| `ListAgentVariablesV1Response` | `src/Deepgram/Models/ListAgentVariablesV1Response.cs` |
| `List3Error` | `src/Deepgram/Errors/List3Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Update2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Update2(Update2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `VariableId`
- **Returns**: `AgentVariableV1`
- **Error**: `ApiException<Update2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Update2Request` | `src/Deepgram/Requests/VoiceAgentVariables/Update2Request.cs` |
| `UpdateAgentVariableV1Request` | `src/Deepgram/Models/UpdateAgentVariableV1Request.cs` |
| `AgentVariableV1` | `src/Deepgram/Models/AgentVariableV1.cs` |
| `Update2Error` | `src/Deepgram/Errors/Update2Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

