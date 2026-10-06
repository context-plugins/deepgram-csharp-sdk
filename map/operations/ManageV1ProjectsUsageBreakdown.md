<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsUsageBreakdown — operations

Accessor: `client.ManageV1ProjectsUsageBreakdown` · Source: `Api/ManageV1ProjectsUsageBreakdown.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Get9

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Get9(Get9Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `start` ← `Start`, `end` ← `End`, `grouping` ← `Grouping`, `accessor` ← `Accessor`, `alternatives` ← `Alternatives`, `callback_method` ← `CallbackMethod`, `callback` ← `Callback`, `channels` ← `Channels`, `custom_intent_mode` ← `CustomIntentMode`, `custom_intent` ← `CustomIntent`, `custom_topic_mode` ← `CustomTopicMode`, `custom_topic` ← `CustomTopic`, `deployment` ← `Deployment`, `detect_entities` ← `DetectEntities`, `detect_language` ← `DetectLanguage`, `diarize` ← `Diarize`, `dictation` ← `Dictation`, `encoding` ← `Encoding`, `endpoint` ← `Endpoint`, `extra` ← `Extra`, `filler_words` ← `FillerWords`, `intents` ← `Intents`, `keyterm` ← `Keyterm`, `keywords` ← `Keywords`, `language` ← `Language`, `measurements` ← `Measurements`, `method` ← `Method`, `model` ← `Model`, `multichannel` ← `Multichannel`, `numerals` ← `Numerals`, `paragraphs` ← `Paragraphs`, `profanity_filter` ← `ProfanityFilter`, `punctuate` ← `Punctuate`, `redact` ← `Redact`, `replace` ← `Replace`, `sample_rate` ← `SampleRate`, `search` ← `Search`, `sentiment` ← `Sentiment`, `smart_format` ← `SmartFormat`, `summarize` ← `Summarize`, `tag` ← `Tag`, `topics` ← `Topics`, `utt_split` ← `UttSplit`, `utterances` ← `Utterances`, `version` ← `Version`
- **Returns**: `UsageBreakdownV1Response`
- **Error**: `ApiException<Get9Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Get9Request` | `Requests/ManageV1ProjectsUsageBreakdown/Get9Request.cs` |
| `V1ProjectsProjectIdUsageBreakdownGetParametersGrouping` | `Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.cs` |
| `V1ProjectsProjectIdUsageBreakdownGetParametersDeployment` | `Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.cs` |
| `V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint` | `Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.cs` |
| `V1ProjectsProjectIdUsageBreakdownGetParametersMethod` | `Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersMethod.cs` |
| `UsageBreakdownV1Response` | `Models/UsageBreakdownV1Response.cs` |
| `Get9Error` | `Errors/Get9Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

