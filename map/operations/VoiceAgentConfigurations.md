<!-- Generated file — do not edit; regenerated with the SDK. -->

# VoiceAgentConfigurations — operations

Accessor: `client.VoiceAgentConfigurations` · Source: `src/Deepgram/Api/VoiceAgentConfigurations.cs` · 5 operations

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
| `CreateRequest` | `src/Deepgram/Requests/VoiceAgentConfigurations/CreateRequest.cs` |
| `CreateAgentConfigurationV1Request` | `src/Deepgram/Models/CreateAgentConfigurationV1Request.cs` |
| `CreateAgentConfigurationV1Response` | `src/Deepgram/Models/CreateAgentConfigurationV1Response.cs` |
| `CreateError` | `src/Deepgram/Errors/CreateError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Delete

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Delete(DeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `AgentId`
- **Returns**: `object`
- **Error**: `ApiException<DeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteRequest` | `src/Deepgram/Requests/VoiceAgentConfigurations/DeleteRequest.cs` |
| `DeleteError` | `src/Deepgram/Errors/DeleteError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Get

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get(GetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `AgentId`
- **Returns**: `AgentConfigurationV1`
- **Error**: `ApiException<GetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRequest` | `src/Deepgram/Requests/VoiceAgentConfigurations/GetRequest.cs` |
| `AgentConfigurationV1` | `src/Deepgram/Models/AgentConfigurationV1.cs` |
| `GetError` | `src/Deepgram/Errors/GetError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### List2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List2(List2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Returns**: `ListAgentConfigurationsV1Response`
- **Error**: `ApiException<List2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List2Request` | `src/Deepgram/Requests/VoiceAgentConfigurations/List2Request.cs` |
| `ListAgentConfigurationsV1Response` | `src/Deepgram/Models/ListAgentConfigurationsV1Response.cs` |
| `List2Error` | `src/Deepgram/Errors/List2Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

### Update

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Update(UpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `AgentId`
- **Returns**: `AgentConfigurationV1`
- **Error**: `ApiException<UpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateRequest` | `src/Deepgram/Requests/VoiceAgentConfigurations/UpdateRequest.cs` |
| `UpdateAgentMetadataV1Request` | `src/Deepgram/Models/UpdateAgentMetadataV1Request.cs` |
| `AgentConfigurationV1` | `src/Deepgram/Models/AgentConfigurationV1.cs` |
| `UpdateError` | `src/Deepgram/Errors/UpdateError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

