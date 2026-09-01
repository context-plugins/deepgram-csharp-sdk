<!-- Generated file — do not edit; regenerated with the SDK. -->

# ListenV1Media — operations

Accessor: `client.ListenV1Media` · Source: `Api/ListenV1Media.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Transcribe

- **Signature**: `Transcribe(string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V1ListenPostParametersExtra? extra, V1ListenPostParametersSummarize? summarize, V1ListenPostParametersTag? tag, V1ListenPostParametersCustomTopic? customTopic, V1ListenPostParametersCustomTopicMode? customTopicMode, V1ListenPostParametersCustomIntent? customIntent, V1ListenPostParametersCustomTopicMode? customIntentMode, V1ListenPostParametersDetectLanguage? detectLanguage, V1ListenPostParametersDiarizeModel? diarizeModel, V1ListenPostParametersEncoding? encoding, IReadOnlyList<string>? keyterm, V1ListenPostParametersKeywords? keywords, V1ListenPostParametersModel? model, V1ListenPostParametersRedact? redact, V1ListenPostParametersReplace? replace, V1ListenPostParametersSearch? search, V1ListenPostParametersVersion? version, ListenV1RequestUrl? body, bool? sentiment = false, bool? topics = false, bool? intents = false, bool? detectEntities = false, bool? diarize = false, bool? dictation = false, bool? fillerWords = false, string? language = "en", bool? measurements = false, bool? multichannel = false, bool? numerals = false, bool? paragraphs = false, bool? profanityFilter = false, bool? punctuate = false, bool? smartFormat = false, bool? utterances = false, double? uttSplit = 0.8d, bool? mipOptOut = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 20 params (`callback` … `body`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `sentiment` = `false`, `topics` = `false`, `intents` = `false`, `detectEntities` = `false`, `diarize` = `false`, `dictation` = `false`, `fillerWords` = `false`, `language` = `"en"`, `measurements` = `false`, `multichannel` = `false`, `numerals` = `false`, `paragraphs` = `false`, `profanityFilter` = `false`, `punctuate` = `false`, `smartFormat` = `false`, `utterances` = `false`, `uttSplit` = `0.8d`, `mipOptOut` = `false`
- **Query params (wire ← C#)**: `callback` ← `callback`, `callback_method` ← `callbackMethod`, `extra` ← `extra`, `sentiment` ← `sentiment`, `summarize` ← `summarize`, `tag` ← `tag`, `topics` ← `topics`, `custom_topic` ← `customTopic`, `custom_topic_mode` ← `customTopicMode`, `intents` ← `intents`, `custom_intent` ← `customIntent`, `custom_intent_mode` ← `customIntentMode`, `detect_entities` ← `detectEntities`, `detect_language` ← `detectLanguage`, `diarize` ← `diarize`, `diarize_model` ← `diarizeModel`, `dictation` ← `dictation`, `encoding` ← `encoding`, `filler_words` ← `fillerWords`, `keyterm` ← `keyterm`, `keywords` ← `keywords`, `language` ← `language`, `measurements` ← `measurements`, `model` ← `model`, `multichannel` ← `multichannel`, `numerals` ← `numerals`, `paragraphs` ← `paragraphs`, `profanity_filter` ← `profanityFilter`, `punctuate` ← `punctuate`, `redact` ← `redact`, `replace` ← `replace`, `search` ← `search`, `smart_format` ← `smartFormat`, `utterances` ← `utterances`, `utt_split` ← `uttSplit`, `version` ← `version`, `mip_opt_out` ← `mipOptOut`
- **Returns**: `ListenV1MediaTranscribeResponse200`
- **Error**: `SdkException<TranscribeError>` — **Case A (typed)**
- **Error accessors**: `TryGetListenV1Response(out ListenV1Response)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
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

