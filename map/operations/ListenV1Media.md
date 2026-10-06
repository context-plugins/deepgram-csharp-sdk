<!-- Generated file — do not edit; regenerated with the SDK. -->

# ListenV1Media — operations

Accessor: `client.ListenV1Media` · Source: `Api/ListenV1Media.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Transcribe

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Transcribe(TranscribeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `callback` ← `Callback`, `callback_method` ← `CallbackMethod`, `extra` ← `Extra`, `sentiment` ← `Sentiment`, `summarize` ← `Summarize`, `tag` ← `Tag`, `topics` ← `Topics`, `custom_topic` ← `CustomTopic`, `custom_topic_mode` ← `CustomTopicMode`, `intents` ← `Intents`, `custom_intent` ← `CustomIntent`, `custom_intent_mode` ← `CustomIntentMode`, `detect_entities` ← `DetectEntities`, `detect_language` ← `DetectLanguage`, `diarize` ← `Diarize`, `diarize_model` ← `DiarizeModel`, `dictation` ← `Dictation`, `encoding` ← `Encoding`, `filler_words` ← `FillerWords`, `keyterm` ← `Keyterm`, `keywords` ← `Keywords`, `language` ← `Language`, `measurements` ← `Measurements`, `model` ← `Model`, `multichannel` ← `Multichannel`, `numerals` ← `Numerals`, `paragraphs` ← `Paragraphs`, `profanity_filter` ← `ProfanityFilter`, `punctuate` ← `Punctuate`, `redact` ← `Redact`, `replace` ← `Replace`, `search` ← `Search`, `smart_format` ← `SmartFormat`, `utterances` ← `Utterances`, `utt_split` ← `UttSplit`, `version` ← `Version`, `mip_opt_out` ← `MipOptOut`
- **Returns**: `ListenV1MediaTranscribeResponse200`
- **Error**: `ApiException<TranscribeError>` — **Case A (typed)**
- **Error accessors**: `TryGetListenV1Response(out ListenV1Response)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TranscribeRequest` | `Requests/ListenV1Media/TranscribeRequest.cs` |
| `V1ListenPostParametersCallbackMethod` | `Models/Enums/V1ListenPostParametersCallbackMethod.cs` |
| `V1ListenPostParametersExtra` | `Models/AnyOf/V1ListenPostParametersExtra.cs` |
| `V1ListenPostParametersSummarize` | `Models/AnyOf/V1ListenPostParametersSummarize.cs` |
| `V1ListenPostParametersTag` | `Models/AnyOf/V1ListenPostParametersTag.cs` |
| `V1ListenPostParametersCustomTopic` | `Models/AnyOf/V1ListenPostParametersCustomTopic.cs` |
| `V1ListenPostParametersCustomTopicMode` | `Models/Enums/V1ListenPostParametersCustomTopicMode.cs` |
| `V1ListenPostParametersCustomIntent` | `Models/AnyOf/V1ListenPostParametersCustomIntent.cs` |
| `V1ListenPostParametersDetectLanguage` | `Models/AnyOf/V1ListenPostParametersDetectLanguage.cs` |
| `V1ListenPostParametersDiarizeModel` | `Models/Enums/V1ListenPostParametersDiarizeModel.cs` |
| `V1ListenPostParametersEncoding` | `Models/Enums/V1ListenPostParametersEncoding.cs` |
| `V1ListenPostParametersKeywords` | `Models/AnyOf/V1ListenPostParametersKeywords.cs` |
| `V1ListenPostParametersModel` | `Models/AnyOf/V1ListenPostParametersModel.cs` |
| `V1ListenPostParametersRedact` | `Models/AnyOf/V1ListenPostParametersRedact.cs` |
| `V1ListenPostParametersReplace` | `Models/AnyOf/V1ListenPostParametersReplace.cs` |
| `V1ListenPostParametersSearch` | `Models/AnyOf/V1ListenPostParametersSearch.cs` |
| `V1ListenPostParametersVersion` | `Models/AnyOf/V1ListenPostParametersVersion.cs` |
| `ListenV1RequestUrl` | `Models/ListenV1RequestUrl.cs` |
| `ListenV1MediaTranscribeResponse200` | `Models/AnyOf/ListenV1MediaTranscribeResponse200.cs` |
| `TranscribeError` | `Errors/TranscribeError.cs` |
| `ListenV1Response` | `Models/ListenV1Response.cs` |

