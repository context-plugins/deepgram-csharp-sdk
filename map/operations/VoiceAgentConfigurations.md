<!-- Generated file — do not edit; regenerated with the SDK. -->

# VoiceAgentConfigurations — operations

Accessor: `client.VoiceAgentConfigurations` · Source: `Api/VoiceAgentConfigurations.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create

- **Signature**: `Create(string projectId, CreateAgentConfigurationV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `CreateAgentConfigurationV1Response`
- **Error**: `SdkException<CreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateAgentConfigurationV1Request` | `Models/CreateAgentConfigurationV1Request.cs` |
| `CreateAgentConfigurationV1Response` | `Models/CreateAgentConfigurationV1Response.cs` |
| `CreateError` | `Errors/CreateError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete

- **Signature**: `Delete(string projectId, string agentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<DeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteError` | `Errors/DeleteError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get

- **Signature**: `Get(string projectId, string agentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AgentConfigurationV1`
- **Error**: `SdkException<GetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AgentConfigurationV1` | `Models/AgentConfigurationV1.cs` |
| `GetError` | `Errors/GetError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List2

- **Signature**: `List2(string projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListAgentConfigurationsV1Response`
- **Error**: `SdkException<List2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAgentConfigurationsV1Response` | `Models/ListAgentConfigurationsV1Response.cs` |
| `List2Error` | `Errors/List2Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Update

- **Signature**: `Update(string projectId, string agentId, UpdateAgentMetadataV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AgentConfigurationV1`
- **Error**: `SdkException<UpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAgentMetadataV1Request` | `Models/UpdateAgentMetadataV1Request.cs` |
| `AgentConfigurationV1` | `Models/AgentConfigurationV1.cs` |
| `UpdateError` | `Errors/UpdateError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

