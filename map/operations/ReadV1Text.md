<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReadV1Text — operations

Accessor: `client.ReadV1Text` · Source: `Api/ReadV1Text.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Analyze

- **Signature**: `Analyze(string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V1ReadPostParametersSummarize? summarize, V1ReadPostParametersTag? tag, V1ReadPostParametersCustomTopic? customTopic, V1ListenPostParametersCustomTopicMode? customTopicMode, V1ReadPostParametersCustomIntent? customIntent, V1ListenPostParametersCustomTopicMode? customIntentMode, ReadV1Request? body, bool? sentiment = false, bool? topics = false, bool? intents = false, string? language = "en", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`callback` … `body`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `sentiment` = `false`, `topics` = `false`, `intents` = `false`, `language` = `"en"`
- **Query params (wire ← C#)**: `callback` ← `callback`, `callback_method` ← `callbackMethod`, `sentiment` ← `sentiment`, `summarize` ← `summarize`, `tag` ← `tag`, `topics` ← `topics`, `custom_topic` ← `customTopic`, `custom_topic_mode` ← `customTopicMode`, `intents` ← `intents`, `custom_intent` ← `customIntent`, `custom_intent_mode` ← `customIntentMode`, `language` ← `language`
- **Returns**: `ReadV1Response`
- **Error**: `SdkException<AnalyzeError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ListenPostParametersCallbackMethod` | `Models/Enums/V1ListenPostParametersCallbackMethod.cs` |
| `V1ReadPostParametersSummarize` | `Models/AnyOf/V1ReadPostParametersSummarize.cs` |
| `V1ReadPostParametersTag` | `Models/AnyOf/V1ReadPostParametersTag.cs` |
| `V1ReadPostParametersCustomTopic` | `Models/AnyOf/V1ReadPostParametersCustomTopic.cs` |
| `V1ListenPostParametersCustomTopicMode` | `Models/Enums/V1ListenPostParametersCustomTopicMode.cs` |
| `V1ReadPostParametersCustomIntent` | `Models/AnyOf/V1ReadPostParametersCustomIntent.cs` |
| `ReadV1Request` | `Models/AnyOf/ReadV1Request.cs` |
| `ReadV1Response` | `Models/ReadV1Response.cs` |
| `AnalyzeError` | `Errors/AnalyzeError.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

