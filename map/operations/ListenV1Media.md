<!-- Generated file — do not edit; regenerated with the SDK. -->

# ListenV1Media — operations

Accessor: `client.ListenV1Media` · Source: `src/Deepgram/Api/ListenV1Media.cs` · 1 operation

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
| `TranscribeRequest` | `src/Deepgram/Requests/ListenV1Media/TranscribeRequest.cs` |
| `V1ListenPostParametersCallbackMethod` | `src/Deepgram/Models/Enums/V1ListenPostParametersCallbackMethod.cs` |
| `V1ListenPostParametersExtra` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersExtra.cs` |
| `V1ListenPostParametersSummarize` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersSummarize.cs` |
| `V1ListenPostParametersTag` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersTag.cs` |
| `V1ListenPostParametersCustomTopic` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersCustomTopic.cs` |
| `V1ListenPostParametersCustomTopicMode` | `src/Deepgram/Models/Enums/V1ListenPostParametersCustomTopicMode.cs` |
| `V1ListenPostParametersCustomIntent` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersCustomIntent.cs` |
| `V1ListenPostParametersDetectLanguage` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersDetectLanguage.cs` |
| `V1ListenPostParametersDiarizeModel` | `src/Deepgram/Models/Enums/V1ListenPostParametersDiarizeModel.cs` |
| `V1ListenPostParametersEncoding` | `src/Deepgram/Models/Enums/V1ListenPostParametersEncoding.cs` |
| `V1ListenPostParametersKeywords` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersKeywords.cs` |
| `V1ListenPostParametersModel` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersModel.cs` |
| `V1ListenPostParametersRedact` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersRedact.cs` |
| `V1ListenPostParametersReplace` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersReplace.cs` |
| `V1ListenPostParametersSearch` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersSearch.cs` |
| `V1ListenPostParametersVersion` | `src/Deepgram/Models/AnyOf/V1ListenPostParametersVersion.cs` |
| `ListenV1RequestUrl` | `src/Deepgram/Models/ListenV1RequestUrl.cs` |
| `ListenV1MediaTranscribeResponse200` | `src/Deepgram/Models/AnyOf/ListenV1MediaTranscribeResponse200.cs` |
| `TranscribeError` | `src/Deepgram/Errors/TranscribeError.cs` |
| `ListenV1Response` | `src/Deepgram/Models/ListenV1Response.cs` |

