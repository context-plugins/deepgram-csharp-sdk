<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReadV1Text — operations

Accessor: `client.ReadV1Text` · Source: `Api/ReadV1Text.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Analyze

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Analyze(AnalyzeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `callback` ← `Callback`, `callback_method` ← `CallbackMethod`, `sentiment` ← `Sentiment`, `summarize` ← `Summarize`, `tag` ← `Tag`, `topics` ← `Topics`, `custom_topic` ← `CustomTopic`, `custom_topic_mode` ← `CustomTopicMode`, `intents` ← `Intents`, `custom_intent` ← `CustomIntent`, `custom_intent_mode` ← `CustomIntentMode`, `language` ← `Language`
- **Returns**: `ReadV1Response`
- **Error**: `ApiException<AnalyzeError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AnalyzeRequest` | `Requests/ReadV1Text/AnalyzeRequest.cs` |
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

