<!-- Generated file — do not edit; regenerated with the SDK. -->

# VoiceAgentConfigurations — operations

Accessor: `client.VoiceAgentConfigurations` · Source: `Api/VoiceAgentConfigurations.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Create

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Create(CreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `CreateAgentConfigurationV1Response`
- **Error**: `ApiException<CreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateRequest` | `Requests/VoiceAgentConfigurations/CreateRequest.cs` |
| `CreateAgentConfigurationV1Request` | `Models/CreateAgentConfigurationV1Request.cs` |
| `CreateAgentConfigurationV1Response` | `Models/CreateAgentConfigurationV1Response.cs` |
| `CreateError` | `Errors/CreateError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Delete

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete(DeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `AgentId`
- **Returns**: `object`
- **Error**: `ApiException<DeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteRequest` | `Requests/VoiceAgentConfigurations/DeleteRequest.cs` |
| `DeleteError` | `Errors/DeleteError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Get

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get(GetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `AgentId`
- **Returns**: `AgentConfigurationV1`
- **Error**: `ApiException<GetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRequest` | `Requests/VoiceAgentConfigurations/GetRequest.cs` |
| `AgentConfigurationV1` | `Models/AgentConfigurationV1.cs` |
| `GetError` | `Errors/GetError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### List2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List2(List2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListAgentConfigurationsV1Response`
- **Error**: `ApiException<List2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List2Request` | `Requests/VoiceAgentConfigurations/List2Request.cs` |
| `ListAgentConfigurationsV1Response` | `Models/ListAgentConfigurationsV1Response.cs` |
| `List2Error` | `Errors/List2Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

### Update

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Update(UpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `AgentId`
- **Returns**: `AgentConfigurationV1`
- **Error**: `ApiException<UpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateRequest` | `Requests/VoiceAgentConfigurations/UpdateRequest.cs` |
| `UpdateAgentMetadataV1Request` | `Models/UpdateAgentMetadataV1Request.cs` |
| `AgentConfigurationV1` | `Models/AgentConfigurationV1.cs` |
| `UpdateError` | `Errors/UpdateError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

