<!-- Generated file — do not edit; regenerated with the SDK. -->

# SpeakV1Audio — operations

Accessor: `client.SpeakV1Audio` · Source: `Api/SpeakV1Audio.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Generate

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Generate(GenerateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `callback` ← `Callback`, `callback_method` ← `CallbackMethod`, `mip_opt_out` ← `MipOptOut`, `tag` ← `Tag`, `bit_rate` ← `BitRate`, `container` ← `Container`, `encoding` ← `Encoding`, `model` ← `Model`, `sample_rate` ← `SampleRate`, `speed` ← `Speed`
- **Returns**: `object`
- **Error**: `ApiException<GenerateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateRequest` | `Requests/SpeakV1Audio/GenerateRequest.cs` |
| `V1ListenPostParametersCallbackMethod` | `Models/Enums/V1ListenPostParametersCallbackMethod.cs` |
| `V1SpeakPostParametersTag` | `Models/AnyOf/V1SpeakPostParametersTag.cs` |
| `V1SpeakPostParametersBitRate` | `Models/AnyOf/V1SpeakPostParametersBitRate.cs` |
| `V1SpeakPostParametersContainer` | `Models/AnyOf/V1SpeakPostParametersContainer.cs` |
| `V1SpeakPostParametersEncoding` | `Models/AnyOf/V1SpeakPostParametersEncoding.cs` |
| `V1SpeakPostParametersModel` | `Models/Enums/V1SpeakPostParametersModel.cs` |
| `V1SpeakPostParametersSampleRate` | `Models/AnyOf/V1SpeakPostParametersSampleRate.cs` |
| `SpeakV1Request` | `Models/SpeakV1Request.cs` |
| `GenerateError` | `Errors/GenerateError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

