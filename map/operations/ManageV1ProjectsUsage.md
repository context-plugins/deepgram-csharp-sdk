<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsUsage — operations

Accessor: `client.ManageV1ProjectsUsage` · Source: `src/Deepgram/Api/ManageV1ProjectsUsage.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get8

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get8(Get8Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `start` ← `Start`, `end` ← `End`, `accessor` ← `Accessor`, `alternatives` ← `Alternatives`, `callback_method` ← `CallbackMethod`, `callback` ← `Callback`, `channels` ← `Channels`, `custom_intent_mode` ← `CustomIntentMode`, `custom_intent` ← `CustomIntent`, `custom_topic_mode` ← `CustomTopicMode`, `custom_topic` ← `CustomTopic`, `deployment` ← `Deployment`, `detect_entities` ← `DetectEntities`, `detect_language` ← `DetectLanguage`, `diarize` ← `Diarize`, `dictation` ← `Dictation`, `encoding` ← `Encoding`, `endpoint` ← `Endpoint`, `extra` ← `Extra`, `filler_words` ← `FillerWords`, `intents` ← `Intents`, `keyterm` ← `Keyterm`, `keywords` ← `Keywords`, `language` ← `Language`, `measurements` ← `Measurements`, `method` ← `Method`, `model` ← `Model`, `multichannel` ← `Multichannel`, `numerals` ← `Numerals`, `paragraphs` ← `Paragraphs`, `profanity_filter` ← `ProfanityFilter`, `punctuate` ← `Punctuate`, `redact` ← `Redact`, `replace` ← `Replace`, `sample_rate` ← `SampleRate`, `search` ← `Search`, `sentiment` ← `Sentiment`, `smart_format` ← `SmartFormat`, `summarize` ← `Summarize`, `tag` ← `Tag`, `topics` ← `Topics`, `utt_split` ← `UttSplit`, `utterances` ← `Utterances`, `version` ← `Version`
- **Returns**: `UsageV1Response`
- **Error**: `ApiException<Get8Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get8Request` | `src/Deepgram/Requests/ManageV1ProjectsUsage/Get8Request.cs` |
| `V1ProjectsProjectIdUsageGetParametersDeployment` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdUsageGetParametersDeployment.cs` |
| `V1ProjectsProjectIdUsageGetParametersEndpoint` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdUsageGetParametersEndpoint.cs` |
| `V1ProjectsProjectIdUsageGetParametersMethod` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdUsageGetParametersMethod.cs` |
| `UsageV1Response` | `src/Deepgram/Models/UsageV1Response.cs` |
| `Get8Error` | `src/Deepgram/Errors/Get8Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

