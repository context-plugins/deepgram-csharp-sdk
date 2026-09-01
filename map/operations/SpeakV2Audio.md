<!-- Generated file — do not edit; regenerated with the SDK. -->

# SpeakV2Audio — operations

Accessor: `client.SpeakV2Audio` · Source: `Api/SpeakV2Audio.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Generate2

- **Signature**: `Generate2(string model, string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V2SpeakPostParametersTag? tag, V2SpeakPostParametersBitRate? bitRate, V2SpeakPostParametersContainer? container, V2SpeakPostParametersEncoding? encoding, V2SpeakPostParametersSampleRate? sampleRate, V2SpeakPostParametersPriority? priority, SpeakV2Request? body, bool? mipOptOut = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`callback` … `body`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `mipOptOut` = `false`
- **Query params (wire ← C#)**: `model` ← `model`, `callback` ← `callback`, `callback_method` ← `callbackMethod`, `mip_opt_out` ← `mipOptOut`, `tag` ← `tag`, `bit_rate` ← `bitRate`, `container` ← `container`, `encoding` ← `encoding`, `sample_rate` ← `sampleRate`, `priority` ← `priority`
- **Returns**: `SpeakV2AcceptedResponse`
- **Error**: `SdkException<Generate2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ListenPostParametersCallbackMethod` | `Models/Enums/V1ListenPostParametersCallbackMethod.cs` |
| `V2SpeakPostParametersTag` | `Models/AnyOf/V2SpeakPostParametersTag.cs` |
| `V2SpeakPostParametersBitRate` | `Models/AnyOf/V2SpeakPostParametersBitRate.cs` |
| `V2SpeakPostParametersContainer` | `Models/AnyOf/V2SpeakPostParametersContainer.cs` |
| `V2SpeakPostParametersEncoding` | `Models/AnyOf/V2SpeakPostParametersEncoding.cs` |
| `V2SpeakPostParametersSampleRate` | `Models/AnyOf/V2SpeakPostParametersSampleRate.cs` |
| `V2SpeakPostParametersPriority` | `Models/Enums/V2SpeakPostParametersPriority.cs` |
| `SpeakV2Request` | `Models/SpeakV2Request.cs` |
| `SpeakV2AcceptedResponse` | `Models/SpeakV2AcceptedResponse.cs` |
| `Generate2Error` | `Errors/Generate2Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

