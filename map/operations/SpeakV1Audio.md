<!-- Generated file — do not edit; regenerated with the SDK. -->

# SpeakV1Audio — operations

Accessor: `client.SpeakV1Audio` · Source: `src/Deepgram/Api/SpeakV1Audio.cs` · 1 operation

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
| `GenerateRequest` | `src/Deepgram/Requests/SpeakV1Audio/GenerateRequest.cs` |
| `V1ListenPostParametersCallbackMethod` | `src/Deepgram/Models/Enums/V1ListenPostParametersCallbackMethod.cs` |
| `V1SpeakPostParametersTag` | `src/Deepgram/Models/AnyOf/V1SpeakPostParametersTag.cs` |
| `V1SpeakPostParametersBitRate` | `src/Deepgram/Models/AnyOf/V1SpeakPostParametersBitRate.cs` |
| `V1SpeakPostParametersContainer` | `src/Deepgram/Models/AnyOf/V1SpeakPostParametersContainer.cs` |
| `V1SpeakPostParametersEncoding` | `src/Deepgram/Models/AnyOf/V1SpeakPostParametersEncoding.cs` |
| `V1SpeakPostParametersModel` | `src/Deepgram/Models/Enums/V1SpeakPostParametersModel.cs` |
| `V1SpeakPostParametersSampleRate` | `src/Deepgram/Models/AnyOf/V1SpeakPostParametersSampleRate.cs` |
| `SpeakV1Request` | `src/Deepgram/Models/SpeakV1Request.cs` |
| `GenerateError` | `src/Deepgram/Errors/GenerateError.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

