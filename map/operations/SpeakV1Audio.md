<!-- Generated file — do not edit; regenerated with the SDK. -->

# SpeakV1Audio — operations

Accessor: `client.SpeakV1Audio` · Source: `Api/SpeakV1Audio.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Generate

- **Signature**: `Generate(string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V1SpeakPostParametersTag? tag, V1SpeakPostParametersBitRate? bitRate, V1SpeakPostParametersContainer? container, V1SpeakPostParametersEncoding? encoding, V1SpeakPostParametersModel? model, V1SpeakPostParametersSampleRate? sampleRate, SpeakV1Request? body, bool? mipOptOut = false, double? speed = 1d, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`callback` … `body`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `mipOptOut` = `false`, `speed` = `1d`
- **Query params (wire ← C#)**: `callback` ← `callback`, `callback_method` ← `callbackMethod`, `mip_opt_out` ← `mipOptOut`, `tag` ← `tag`, `bit_rate` ← `bitRate`, `container` ← `container`, `encoding` ← `encoding`, `model` ← `model`, `sample_rate` ← `sampleRate`, `speed` ← `speed`
- **Returns**: `object`
- **Error**: `SdkException<GenerateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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

