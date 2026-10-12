<!-- Generated file — do not edit; regenerated with the SDK. -->

# SpeakV2Audio — operations

Accessor: `client.SpeakV2Audio` · Source: `src/Deepgram/Api/SpeakV2Audio.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Generate2

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Generate2(Generate2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Model`
- **Query params (wire ← C#)**: `model` ← `Model`, `callback` ← `Callback`, `callback_method` ← `CallbackMethod`, `mip_opt_out` ← `MipOptOut`, `tag` ← `Tag`, `bit_rate` ← `BitRate`, `container` ← `Container`, `encoding` ← `Encoding`, `sample_rate` ← `SampleRate`, `priority` ← `Priority`
- **Returns**: `SpeakV2AcceptedResponse`
- **Error**: `ApiException<Generate2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Generate2Request` | `src/Deepgram/Requests/SpeakV2Audio/Generate2Request.cs` |
| `V1ListenPostParametersCallbackMethod` | `src/Deepgram/Models/Enums/V1ListenPostParametersCallbackMethod.cs` |
| `V2SpeakPostParametersTag` | `src/Deepgram/Models/AnyOf/V2SpeakPostParametersTag.cs` |
| `V2SpeakPostParametersBitRate` | `src/Deepgram/Models/AnyOf/V2SpeakPostParametersBitRate.cs` |
| `V2SpeakPostParametersContainer` | `src/Deepgram/Models/AnyOf/V2SpeakPostParametersContainer.cs` |
| `V2SpeakPostParametersEncoding` | `src/Deepgram/Models/AnyOf/V2SpeakPostParametersEncoding.cs` |
| `V2SpeakPostParametersSampleRate` | `src/Deepgram/Models/AnyOf/V2SpeakPostParametersSampleRate.cs` |
| `V2SpeakPostParametersPriority` | `src/Deepgram/Models/Enums/V2SpeakPostParametersPriority.cs` |
| `SpeakV2Request` | `src/Deepgram/Models/SpeakV2Request.cs` |
| `SpeakV2AcceptedResponse` | `src/Deepgram/Models/SpeakV2AcceptedResponse.cs` |
| `Generate2Error` | `src/Deepgram/Errors/Generate2Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

