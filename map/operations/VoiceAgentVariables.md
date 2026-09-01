<!-- Generated file — do not edit; regenerated with the SDK. -->

# VoiceAgentVariables — operations

Accessor: `client.VoiceAgentVariables` · Source: `Api/VoiceAgentVariables.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create2

- **Signature**: `Create2(string projectId, CreateAgentVariableV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AgentVariableV1`
- **Error**: `SdkException<Create2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateAgentVariableV1Request` | `Models/CreateAgentVariableV1Request.cs` |
| `AgentVariableV1` | `Models/AgentVariableV1.cs` |
| `Create2Error` | `Errors/Create2Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete2

- **Signature**: `Delete2(string projectId, string variableId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<Delete2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Delete2Error` | `Errors/Delete2Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get2

- **Signature**: `Get2(string projectId, string variableId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AgentVariableV1`
- **Error**: `SdkException<Get2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AgentVariableV1` | `Models/AgentVariableV1.cs` |
| `Get2Error` | `Errors/Get2Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List3

- **Signature**: `List3(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListAgentVariablesV1Response`
- **Error**: `SdkException<List3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAgentVariablesV1Response` | `Models/ListAgentVariablesV1Response.cs` |
| `List3Error` | `Errors/List3Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Update2

- **Signature**: `Update2(string projectId, string variableId, UpdateAgentVariableV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AgentVariableV1`
- **Error**: `SdkException<Update2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAgentVariableV1Request` | `Models/UpdateAgentVariableV1Request.cs` |
| `AgentVariableV1` | `Models/AgentVariableV1.cs` |
| `Update2Error` | `Errors/Update2Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

