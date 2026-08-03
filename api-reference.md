# Reference

> Source: [RestApiClient](RestApiClient.cs)

## AgentV1SettingsThinkModels

> Source: [AgentV1SettingsThinkModels](Api/AgentV1SettingsThinkModels.cs)

<details>
<summary><code>Task&lt;AgentThinkModelsV1Response&gt; List(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the available think models that can be used for AI agent processing

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AgentV1SettingsThinkModels.List();
    // TODO: Handle 'response' of type AgentThinkModelsV1Response
}
catch (SdkException<ListError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ListError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentThinkModelsV1Response](Models/AgentThinkModelsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListError](Errors/ListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthV1Tokens

> Source: [AuthV1Tokens](Api/AuthV1Tokens.cs)

<details>
<summary><code>Task&lt;GrantV1Response&gt; Grant(string authorization, GrantV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a temporary JSON Web Token (JWT) with a 30-second (by default) TTL and usage::write permission for core voice APIs, requiring an API key with Member or higher authorization. Tokens created with this endpoint will not work with the Manage APIs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthV1Tokens.Grant(authorization, body);
    // TODO: Handle 'response' of type GrantV1Response
}
catch (SdkException<GrantError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GrantError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[GrantV1Request?](Models/GrantV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantV1Response](Models/GrantV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GrantError](Errors/GrantError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ListenV1Media

> Source: [ListenV1Media](Api/ListenV1Media.cs)

<details>
<summary><code>Task&lt;ListenV1MediaTranscribeResponse200&gt; Transcribe(string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V1ListenPostParametersExtra? extra, V1ListenPostParametersSummarize? summarize, V1ListenPostParametersTag? tag, V1ListenPostParametersCustomTopic? customTopic, V1ListenPostParametersCustomTopicMode? customTopicMode, V1ListenPostParametersCustomIntent? customIntent, V1ListenPostParametersCustomTopicMode? customIntentMode, V1ListenPostParametersDetectLanguage? detectLanguage, V1ListenPostParametersDiarizeModel? diarizeModel, V1ListenPostParametersEncoding? encoding, IReadOnlyList&lt;string&gt;? keyterm, V1ListenPostParametersKeywords? keywords, V1ListenPostParametersModel? model, V1ListenPostParametersRedact? redact, V1ListenPostParametersReplace? replace, V1ListenPostParametersSearch? search, V1ListenPostParametersVersion? version, string authorization, ListenV1RequestUrl? body, bool? sentiment = false, bool? topics = false, bool? intents = false, bool? detectEntities = false, bool? diarize = false, bool? dictation = false, bool? fillerWords = false, string? language = "en", bool? measurements = false, bool? multichannel = false, bool? numerals = false, bool? paragraphs = false, bool? profanityFilter = false, bool? punctuate = false, bool? smartFormat = false, bool? utterances = false, double? uttSplit = 0.8d, bool? mipOptOut = false, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Transcribe audio and video using Deepgram's speech-to-text REST API

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ListenV1Media.Transcribe(callback,
        callbackMethod,
        extra,
        summarize,
        tag,
        customTopic,
        customTopicMode,
        customIntent,
        customIntentMode,
        detectLanguage,
        diarizeModel,
        encoding,
        keyterm,
        keywords,
        model,
        redact,
        replace,
        search,
        version,
        authorization,
        body);
    // TODO: Handle 'response' of type ListenV1MediaTranscribeResponse200
}
catch (SdkException<TranscribeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type TranscribeError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>callback</code> | <code>string?</code> | URL to which we'll make the callback request |
| <code>callbackMethod</code> | <code>[V1ListenPostParametersCallbackMethod?](Models/Enums/V1ListenPostParametersCallbackMethod.cs)</code> | HTTP method by which the callback request will be made |
| <code>extra</code> | <code>[V1ListenPostParametersExtra?](Models/AnyOf/V1ListenPostParametersExtra.cs)</code> | Arbitrary key-value pairs that are attached to the API response for usage in downstream processing |
| <code>summarize</code> | <code>[V1ListenPostParametersSummarize?](Models/AnyOf/V1ListenPostParametersSummarize.cs)</code> | Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only. |
| <code>tag</code> | <code>[V1ListenPostParametersTag?](Models/AnyOf/V1ListenPostParametersTag.cs)</code> | Label your requests for the purpose of identification during usage reporting |
| <code>customTopic</code> | <code>[V1ListenPostParametersCustomTopic?](Models/AnyOf/V1ListenPostParametersCustomTopic.cs)</code> | Custom topics you want the model to detect within your input audio or text if present Submit up to `100`. |
| <code>customTopicMode</code> | <code>[V1ListenPostParametersCustomTopicMode?](Models/Enums/V1ListenPostParametersCustomTopicMode.cs)</code> | Sets how the model will interpret strings submitted to the `custom_topic` param. When `strict`, the model will only return topics submitted using the `custom_topic` param. When `extended`, the model will return its own detected topics in addition to those submitted using the `custom_topic` param |
| <code>customIntent</code> | <code>[V1ListenPostParametersCustomIntent?](Models/AnyOf/V1ListenPostParametersCustomIntent.cs)</code> | Custom intents you want the model to detect within your input audio if present |
| <code>customIntentMode</code> | <code>[V1ListenPostParametersCustomTopicMode?](Models/Enums/V1ListenPostParametersCustomTopicMode.cs)</code> | Sets how the model will interpret intents submitted to the `custom_intent` param. When `strict`, the model will only return intents submitted using the `custom_intent` param. When `extended`, the model will return its own detected intents in the `custom_intent` param. |
| <code>detectLanguage</code> | <code>[V1ListenPostParametersDetectLanguage?](Models/AnyOf/V1ListenPostParametersDetectLanguage.cs)</code> | Identifies the dominant language spoken in submitted audio |
| <code>diarizeModel</code> | <code>[V1ListenPostParametersDiarizeModel?](Models/Enums/V1ListenPostParametersDiarizeModel.cs)</code> | Select and enable a specific diarization model version. Specifying this parameter enables diarization and selects the model — you do not need to also set the deprecated `diarize=true` parameter. For batch, supported values are `latest` (currently v2), `v1`, and `v2`. For streaming, supported values are `latest` (currently v1) and `v1`; `v2` returns a validation error on streaming requests. |
| <code>encoding</code> | <code>[V1ListenPostParametersEncoding?](Models/Enums/V1ListenPostParametersEncoding.cs)</code> | Specify the expected encoding of your submitted audio |
| <code>keyterm</code> | <code>IReadOnlyList&lt;string&gt;?</code> | Key term prompting improves recognition of specialized terminology and brands. Only compatible with Nova-3.<br><br>`keyterm` accepts plain terms only. Unlike the legacy `keywords` feature, it does not support weights or intensifiers. Appending one (for example, `keyterm=term:0.15`) is not rejected—the weight is silently ignored and the entire value is treated as a literal keyterm.<br><br>To boost multiple separate keyterms, repeat the `keyterm` parameter (for example, `keyterm=term1&keyterm=term2`). To boost one multi-word phrase as a single keyterm, join the words with `%20` or `+` (for example, `keyterm=customer%20service`). Do not separate keyterms with commas, semicolons, or line breaks. |
| <code>keywords</code> | <code>[V1ListenPostParametersKeywords?](Models/AnyOf/V1ListenPostParametersKeywords.cs)</code> | Keywords can boost or suppress specialized terminology and brands |
| <code>model</code> | <code>[V1ListenPostParametersModel?](Models/AnyOf/V1ListenPostParametersModel.cs)</code> | AI model used to process submitted audio |
| <code>redact</code> | <code>[V1ListenPostParametersRedact?](Models/AnyOf/V1ListenPostParametersRedact.cs)</code> | Redaction removes sensitive information from your transcripts |
| <code>replace</code> | <code>[V1ListenPostParametersReplace?](Models/AnyOf/V1ListenPostParametersReplace.cs)</code> | Search for terms or phrases in submitted audio and replaces them |
| <code>search</code> | <code>[V1ListenPostParametersSearch?](Models/AnyOf/V1ListenPostParametersSearch.cs)</code> | Search for terms or phrases in submitted audio |
| <code>version</code> | <code>[V1ListenPostParametersVersion?](Models/AnyOf/V1ListenPostParametersVersion.cs)</code> | Version of an AI model to use |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[ListenV1RequestUrl?](Models/ListenV1RequestUrl.cs)</code> | - |
| <code>sentiment</code> | <code>bool?</code> | Recognizes the sentiment throughout a transcript or text<br>**Default**: false |
| <code>topics</code> | <code>bool?</code> | Detect topics throughout a transcript or text<br>**Default**: false |
| <code>intents</code> | <code>bool?</code> | Recognizes speaker intent throughout a transcript or text<br>**Default**: false |
| <code>detectEntities</code> | <code>bool?</code> | Identifies and extracts key entities from content in submitted audio<br>**Default**: false |
| <code>diarize</code> | <code>bool?</code> | Deprecated: use `diarize_model` instead. Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0.<br>**Default**: false |
| <code>dictation</code> | <code>bool?</code> | Dictation mode for controlling formatting with dictated speech<br>**Default**: false |
| <code>fillerWords</code> | <code>bool?</code> | Filler Words can help transcribe interruptions in your audio, like "uh" and "um"<br>**Default**: false |
| <code>language</code> | <code>string?</code> | The [BCP-47 language tag](https://tools.ietf.org/html/bcp47) that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available<br>**Default**: "en" |
| <code>measurements</code> | <code>bool?</code> | Spoken measurements will be converted to their corresponding abbreviations<br>**Default**: false |
| <code>multichannel</code> | <code>bool?</code> | Transcribe each audio channel independently<br>**Default**: false |
| <code>numerals</code> | <code>bool?</code> | Numerals converts numbers from written format to numerical format<br>**Default**: false |
| <code>paragraphs</code> | <code>bool?</code> | Splits audio into paragraphs to improve transcript readability<br>**Default**: false |
| <code>profanityFilter</code> | <code>bool?</code> | Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely<br>**Default**: false |
| <code>punctuate</code> | <code>bool?</code> | Add punctuation and capitalization to the transcript<br>**Default**: false |
| <code>smartFormat</code> | <code>bool?</code> | Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability<br>**Default**: false |
| <code>utterances</code> | <code>bool?</code> | Segments speech into meaningful semantic units<br>**Default**: false |
| <code>uttSplit</code> | <code>double?</code> | Seconds to wait before detecting a pause between words in submitted audio<br>**Default**: 0.8d |
| <code>mipOptOut</code> | <code>bool?</code> | Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip<br>**Default**: false |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListenV1MediaTranscribeResponse200](Models/AnyOf/ListenV1MediaTranscribeResponse200.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TranscribeError](Errors/TranscribeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1Models

> Source: [ManageV1Models](Api/ManageV1Models.cs)

<details>
<summary><code>Task&lt;GetModelV1Response&gt; Get5(string modelId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns metadata for a specific public model

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1Models.Get5(modelId, authorization);
    // TODO: Handle 'response' of type GetModelV1Response
}
catch (SdkException<Get5Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get5Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>modelId</code> | <code>string</code> | The specific UUID of the model |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetModelV1Response](Models/AnyOf/GetModelV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get5Error](Errors/Get5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListModelsV1Response&gt; List6(bool? includeOutdated, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns metadata on all the latest public models. To retrieve custom models, use Get Project Models.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1Models.List6(includeOutdated, authorization);
    // TODO: Handle 'response' of type ListModelsV1Response
}
catch (SdkException<List6Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List6Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeOutdated</code> | <code>bool?</code> | returns non-latest versions of models |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListModelsV1Response](Models/ListModelsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List6Error](Errors/List6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1Projects

> Source: [ManageV1Projects](Api/ManageV1Projects.cs)

<details>
<summary><code>Task&lt;DeleteProjectV1Response&gt; Delete3(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1Projects.Delete3(projectId, authorization);
    // TODO: Handle 'response' of type DeleteProjectV1Response
}
catch (SdkException<Delete3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Delete3Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectV1Response](Models/DeleteProjectV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Delete3Error](Errors/Delete3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectV1Response&gt; Get3(string projectId, double? page, string authorization, double? limit = 10d, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves information about the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1Projects.Get3(projectId, page, authorization);
    // TODO: Handle 'response' of type GetProjectV1Response
}
catch (SdkException<Get3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get3Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>page</code> | <code>double?</code> | Navigate and return the results to retrieve specific portions of information of the response |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>limit</code> | <code>double?</code> | Number of results to return per page. Default 10. Range [1,1000]<br>**Default**: 10d |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectV1Response](Models/GetProjectV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get3Error](Errors/Get3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LeaveProjectV1Response&gt; Leave(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the authenticated account from the specific project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1Projects.Leave(projectId, authorization);
    // TODO: Handle 'response' of type LeaveProjectV1Response
}
catch (SdkException<LeaveError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type LeaveError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LeaveProjectV1Response](Models/LeaveProjectV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[LeaveError](Errors/LeaveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectsV1Response&gt; List4(string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves basic information about the projects associated with the API key

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1Projects.List4(authorization);
    // TODO: Handle 'response' of type ListProjectsV1Response
}
catch (SdkException<List4Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List4Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectsV1Response](Models/ListProjectsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List4Error](Errors/List4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateProjectV1Response&gt; Update3(string projectId, string authorization, UpdateProjectV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the name or other properties of an existing project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1Projects.Update3(projectId, authorization, body);
    // TODO: Handle 'response' of type UpdateProjectV1Response
}
catch (SdkException<Update3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Update3Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[UpdateProjectV1Request?](Models/UpdateProjectV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateProjectV1Response](Models/UpdateProjectV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Update3Error](Errors/Update3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingBalances

> Source: [ManageV1ProjectsBillingBalances](Api/ManageV1ProjectsBillingBalances.cs)

<details>
<summary><code>Task&lt;GetProjectBalanceV1Response&gt; Get10(string projectId, string balanceId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details about the specified balance

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsBillingBalances.Get10(projectId, balanceId, authorization);
    // TODO: Handle 'response' of type GetProjectBalanceV1Response
}
catch (SdkException<Get10Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get10Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>balanceId</code> | <code>string</code> | The unique identifier of the balance |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectBalanceV1Response](Models/GetProjectBalanceV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get10Error](Errors/Get10Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectBalancesV1Response&gt; List13(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a list of outstanding balances for the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsBillingBalances.List13(projectId, authorization);
    // TODO: Handle 'response' of type ListProjectBalancesV1Response
}
catch (SdkException<List13Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List13Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectBalancesV1Response](Models/ListProjectBalancesV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List13Error](Errors/List13Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingBreakdown

> Source: [ManageV1ProjectsBillingBreakdown](Api/ManageV1ProjectsBillingBreakdown.cs)

<details>
<summary><code>Task&lt;BillingBreakdownV1Response&gt; List14(string projectId, DateTimeOffset? start, DateTimeOffset? end, string? accessor, V1ProjectsProjectIdBillingBreakdownGetParametersDeployment? deployment, string? tag, string? lineItem, IReadOnlyList&lt;V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems&gt;? grouping, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the billing summary for a specific project, with various filter options or by grouping options.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsBillingBreakdown.List14(projectId,
        start,
        end,
        accessor,
        deployment,
        tag,
        lineItem,
        grouping,
        authorization);
    // TODO: Handle 'response' of type BillingBreakdownV1Response
}
catch (SdkException<List14Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List14Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>start</code> | <code>DateTimeOffset?</code> | Start date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>end</code> | <code>DateTimeOffset?</code> | End date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>accessor</code> | <code>string?</code> | Filter for requests where a specific accessor was used |
| <code>deployment</code> | <code>[V1ProjectsProjectIdBillingBreakdownGetParametersDeployment?](Models/Enums/V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.cs)</code> | Filter for requests where a specific deployment was used |
| <code>tag</code> | <code>string?</code> | Filter for requests where a specific tag was used |
| <code>lineItem</code> | <code>string?</code> | Filter requests by line item (e.g. streaming::nova-3) |
| <code>grouping</code> | <code>IReadOnlyList&lt;[V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems](Models/Enums/V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.cs)&gt;?</code> | Group billing breakdown by one or more dimensions (accessor, deployment, line_item, tags) |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingBreakdownV1Response](Models/BillingBreakdownV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List14Error](Errors/List14Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingFields

> Source: [ManageV1ProjectsBillingFields](Api/ManageV1ProjectsBillingFields.cs)

<details>
<summary><code>Task&lt;ListBillingFieldsV1Response&gt; List15(string projectId, DateTimeOffset? start, DateTimeOffset? end, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the accessors, deployment types, tags, and line items used for billing data in the specified time period. Use this endpoint if you want to filter your results from the Billing Breakdown endpoint and want to know what filters are available.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsBillingFields.List15(projectId, start, end, authorization);
    // TODO: Handle 'response' of type ListBillingFieldsV1Response
}
catch (SdkException<List15Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List15Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>start</code> | <code>DateTimeOffset?</code> | Start date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>end</code> | <code>DateTimeOffset?</code> | End date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBillingFieldsV1Response](Models/ListBillingFieldsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List15Error](Errors/List15Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingPurchases

> Source: [ManageV1ProjectsBillingPurchases](Api/ManageV1ProjectsBillingPurchases.cs)

<details>
<summary><code>Task&lt;ListProjectPurchasesV1Response&gt; List16(string projectId, string authorization, double? limit = 10d, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the original purchased amount on an order transaction

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsBillingPurchases.List16(projectId, authorization);
    // TODO: Handle 'response' of type ListProjectPurchasesV1Response
}
catch (SdkException<List16Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List16Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>limit</code> | <code>double?</code> | Number of results to return per page. Default 10. Range [1,1000]<br>**Default**: 10d |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectPurchasesV1Response](Models/ListProjectPurchasesV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List16Error](Errors/List16Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsKeys

> Source: [ManageV1ProjectsKeys](Api/ManageV1ProjectsKeys.cs)

<details>
<summary><code>Task&lt;CreateKeyV1Response&gt; Create3(string projectId, string authorization, CreateKeyV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new API key with specified settings for the project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsKeys.Create3(projectId, authorization, body);
    // TODO: Handle 'response' of type CreateKeyV1Response
}
catch (SdkException<Create3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Create3Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[CreateKeyV1Request?](Models/AnyOf/CreateKeyV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateKeyV1Response](Models/CreateKeyV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Create3Error](Errors/Create3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteProjectKeyV1Response&gt; Delete4(string projectId, string keyId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an API key for a specific project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsKeys.Delete4(projectId, keyId, authorization);
    // TODO: Handle 'response' of type DeleteProjectKeyV1Response
}
catch (SdkException<Delete4Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Delete4Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>keyId</code> | <code>string</code> | The unique identifier of the API key |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectKeyV1Response](Models/DeleteProjectKeyV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Delete4Error](Errors/Delete4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectKeyV1Response&gt; Get6(string projectId, string keyId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves information about a specified API key

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsKeys.Get6(projectId, keyId, authorization);
    // TODO: Handle 'response' of type GetProjectKeyV1Response
}
catch (SdkException<Get6Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get6Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>keyId</code> | <code>string</code> | The unique identifier of the API key |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectKeyV1Response](Models/GetProjectKeyV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get6Error](Errors/Get6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectKeysV1Response&gt; List7(string projectId, V1ProjectsProjectIdKeysGetParametersStatus? status, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all API keys associated with the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsKeys.List7(projectId, status, authorization);
    // TODO: Handle 'response' of type ListProjectKeysV1Response
}
catch (SdkException<List7Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List7Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>status</code> | <code>[V1ProjectsProjectIdKeysGetParametersStatus?](Models/Enums/V1ProjectsProjectIdKeysGetParametersStatus.cs)</code> | Only return keys with a specific status |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectKeysV1Response](Models/ListProjectKeysV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List7Error](Errors/List7Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsMembers

> Source: [ManageV1ProjectsMembers](Api/ManageV1ProjectsMembers.cs)

<details>
<summary><code>Task&lt;DeleteProjectMemberV1Response&gt; Delete5(string projectId, string memberId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a member from the project using their unique member ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsMembers.Delete5(projectId, memberId, authorization);
    // TODO: Handle 'response' of type DeleteProjectMemberV1Response
}
catch (SdkException<Delete5Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Delete5Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>memberId</code> | <code>string</code> | The unique identifier of the Member |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectMemberV1Response](Models/DeleteProjectMemberV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Delete5Error](Errors/Delete5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectMembersV1Response&gt; List8(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of members for a given project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsMembers.List8(projectId, authorization);
    // TODO: Handle 'response' of type ListProjectMembersV1Response
}
catch (SdkException<List8Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List8Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectMembersV1Response](Models/ListProjectMembersV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List8Error](Errors/List8Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsMembersInvites

> Source: [ManageV1ProjectsMembersInvites](Api/ManageV1ProjectsMembersInvites.cs)

<details>
<summary><code>Task&lt;CreateProjectInviteV1Response&gt; Create4(string projectId, string authorization, CreateProjectInviteV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates an invite for a specific project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsMembersInvites.Create4(projectId, authorization, body);
    // TODO: Handle 'response' of type CreateProjectInviteV1Response
}
catch (SdkException<Create4Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Create4Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[CreateProjectInviteV1Request?](Models/CreateProjectInviteV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateProjectInviteV1Response](Models/CreateProjectInviteV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Create4Error](Errors/Create4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteProjectInviteV1Response&gt; Delete6(string projectId, string email, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an invite for a specific project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsMembersInvites.Delete6(projectId, email, authorization);
    // TODO: Handle 'response' of type DeleteProjectInviteV1Response
}
catch (SdkException<Delete6Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Delete6Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>email</code> | <code>string</code> | The email address of the member |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectInviteV1Response](Models/DeleteProjectInviteV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Delete6Error](Errors/Delete6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectInvitesV1Response&gt; List10(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a list of invites for a specific project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsMembersInvites.List10(projectId, authorization);
    // TODO: Handle 'response' of type ListProjectInvitesV1Response
}
catch (SdkException<List10Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List10Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectInvitesV1Response](Models/ListProjectInvitesV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List10Error](Errors/List10Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsMembersScopes

> Source: [ManageV1ProjectsMembersScopes](Api/ManageV1ProjectsMembersScopes.cs)

<details>
<summary><code>Task&lt;ListProjectMemberScopesV1Response&gt; List9(string projectId, string memberId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of scopes for a specific member

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsMembersScopes.List9(projectId, memberId, authorization);
    // TODO: Handle 'response' of type ListProjectMemberScopesV1Response
}
catch (SdkException<List9Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List9Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>memberId</code> | <code>string</code> | The unique identifier of the Member |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectMemberScopesV1Response](Models/ListProjectMemberScopesV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List9Error](Errors/List9Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateProjectMemberScopesV1Response&gt; Update4(string projectId, string memberId, string authorization, UpdateProjectMemberScopesV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the scopes for a specific member

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsMembersScopes.Update4(projectId, memberId, authorization, body);
    // TODO: Handle 'response' of type UpdateProjectMemberScopesV1Response
}
catch (SdkException<Update4Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Update4Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>memberId</code> | <code>string</code> | The unique identifier of the Member |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[UpdateProjectMemberScopesV1Request?](Models/UpdateProjectMemberScopesV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateProjectMemberScopesV1Response](Models/UpdateProjectMemberScopesV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Update4Error](Errors/Update4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsModels

> Source: [ManageV1ProjectsModels](Api/ManageV1ProjectsModels.cs)

<details>
<summary><code>Task&lt;GetModelV1Response&gt; Get4(string projectId, string modelId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns metadata for a specific model

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsModels.Get4(projectId, modelId, authorization);
    // TODO: Handle 'response' of type GetModelV1Response
}
catch (SdkException<Get4Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get4Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>modelId</code> | <code>string</code> | The specific UUID of the model |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetModelV1Response](Models/AnyOf/GetModelV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get4Error](Errors/Get4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListModelsV1Response&gt; List5(string projectId, bool? includeOutdated, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns metadata on all the latest models that a specific project has access to, including non-public models

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsModels.List5(projectId, includeOutdated, authorization);
    // TODO: Handle 'response' of type ListModelsV1Response
}
catch (SdkException<List5Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List5Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>includeOutdated</code> | <code>bool?</code> | returns non-latest versions of models |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListModelsV1Response](Models/ListModelsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List5Error](Errors/List5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsRequests

> Source: [ManageV1ProjectsRequests](Api/ManageV1ProjectsRequests.cs)

<details>
<summary><code>Task&lt;GetProjectRequestV1Response&gt; Get7(string projectId, string requestId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific request for a specific project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsRequests.Get7(projectId, requestId, authorization);
    // TODO: Handle 'response' of type GetProjectRequestV1Response
}
catch (SdkException<Get7Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get7Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>requestId</code> | <code>string</code> | The unique identifier of the request |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectRequestV1Response](Models/GetProjectRequestV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get7Error](Errors/Get7Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectRequestsV1Response&gt; List11(string projectId, DateTimeOffset? start, DateTimeOffset? end, double? page, string? accessor, string? requestId, V1ProjectsProjectIdRequestsGetParametersDeployment? deployment, V1ProjectsProjectIdRequestsGetParametersEndpoint? endpoint, V1ProjectsProjectIdRequestsGetParametersMethod? method, V1ProjectsProjectIdRequestsGetParametersStatus? status, string authorization, double? limit = 10d, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a list of requests for a specific project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsRequests.List11(projectId,
        start,
        end,
        page,
        accessor,
        requestId,
        deployment,
        endpoint,
        method,
        status,
        authorization);
    // TODO: Handle 'response' of type ListProjectRequestsV1Response
}
catch (SdkException<List11Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List11Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>start</code> | <code>DateTimeOffset?</code> | Start date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM |
| <code>end</code> | <code>DateTimeOffset?</code> | End date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM |
| <code>page</code> | <code>double?</code> | Navigate and return the results to retrieve specific portions of information of the response |
| <code>accessor</code> | <code>string?</code> | Filter for requests where a specific accessor was used |
| <code>requestId</code> | <code>string?</code> | Filter for a specific request id |
| <code>deployment</code> | <code>[V1ProjectsProjectIdRequestsGetParametersDeployment?](Models/Enums/V1ProjectsProjectIdRequestsGetParametersDeployment.cs)</code> | Filter for requests where a specific deployment was used |
| <code>endpoint</code> | <code>[V1ProjectsProjectIdRequestsGetParametersEndpoint?](Models/Enums/V1ProjectsProjectIdRequestsGetParametersEndpoint.cs)</code> | Filter for requests where a specific endpoint was used |
| <code>method</code> | <code>[V1ProjectsProjectIdRequestsGetParametersMethod?](Models/Enums/V1ProjectsProjectIdRequestsGetParametersMethod.cs)</code> | Filter for requests where a specific method was used |
| <code>status</code> | <code>[V1ProjectsProjectIdRequestsGetParametersStatus?](Models/Enums/V1ProjectsProjectIdRequestsGetParametersStatus.cs)</code> | Filter for requests that succeeded (status code < 300) or failed (status code >=400) |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>limit</code> | <code>double?</code> | Number of results to return per page. Default 10. Range [1,1000]<br>**Default**: 10d |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectRequestsV1Response](Models/ListProjectRequestsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List11Error](Errors/List11Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsUsage

> Source: [ManageV1ProjectsUsage](Api/ManageV1ProjectsUsage.cs)

<details>
<summary><code>Task&lt;UsageV1Response&gt; Get8(string projectId, DateTimeOffset? start, DateTimeOffset? end, string? accessor, bool? alternatives, bool? callbackMethod, bool? callback, bool? channels, bool? customIntentMode, bool? customIntent, bool? customTopicMode, bool? customTopic, V1ProjectsProjectIdUsageGetParametersDeployment? deployment, bool? detectEntities, bool? detectLanguage, bool? diarize, bool? dictation, bool? encoding, V1ProjectsProjectIdUsageGetParametersEndpoint? endpoint, bool? extra, bool? fillerWords, bool? intents, bool? keyterm, bool? keywords, bool? language, bool? measurements, V1ProjectsProjectIdUsageGetParametersMethod? method, string? model, bool? multichannel, bool? numerals, bool? paragraphs, bool? profanityFilter, bool? punctuate, bool? redact, bool? replace, bool? sampleRate, bool? search, bool? sentiment, bool? smartFormat, bool? summarize, string? tag, bool? topics, bool? uttSplit, bool? utterances, bool? version, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the usage for a specific project. Use Get Project Usage Breakdown for a more comprehensive usage summary.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsUsage.Get8(projectId,
        start,
        end,
        accessor,
        alternatives,
        callbackMethod,
        callback,
        channels,
        customIntentMode,
        customIntent,
        customTopicMode,
        customTopic,
        deployment,
        detectEntities,
        detectLanguage,
        diarize,
        dictation,
        encoding,
        endpoint,
        extra,
        fillerWords,
        intents,
        keyterm,
        keywords,
        language,
        measurements,
        method,
        model,
        multichannel,
        numerals,
        paragraphs,
        profanityFilter,
        punctuate,
        redact,
        replace,
        sampleRate,
        search,
        sentiment,
        smartFormat,
        summarize,
        tag,
        topics,
        uttSplit,
        utterances,
        version,
        authorization);
    // TODO: Handle 'response' of type UsageV1Response
}
catch (SdkException<Get8Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get8Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>start</code> | <code>DateTimeOffset?</code> | Start date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>end</code> | <code>DateTimeOffset?</code> | End date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>accessor</code> | <code>string?</code> | Filter for requests where a specific accessor was used |
| <code>alternatives</code> | <code>bool?</code> | Filter for requests where alternatives were used |
| <code>callbackMethod</code> | <code>bool?</code> | Filter for requests where callback method was used |
| <code>callback</code> | <code>bool?</code> | Filter for requests where callback was used |
| <code>channels</code> | <code>bool?</code> | Filter for requests where channels were used |
| <code>customIntentMode</code> | <code>bool?</code> | Filter for requests where custom intent mode was used |
| <code>customIntent</code> | <code>bool?</code> | Filter for requests where custom intent was used |
| <code>customTopicMode</code> | <code>bool?</code> | Filter for requests where custom topic mode was used |
| <code>customTopic</code> | <code>bool?</code> | Filter for requests where custom topic was used |
| <code>deployment</code> | <code>[V1ProjectsProjectIdUsageGetParametersDeployment?](Models/Enums/V1ProjectsProjectIdUsageGetParametersDeployment.cs)</code> | Filter for requests where a specific deployment was used |
| <code>detectEntities</code> | <code>bool?</code> | Filter for requests where detect entities was used |
| <code>detectLanguage</code> | <code>bool?</code> | Filter for requests where detect language was used |
| <code>diarize</code> | <code>bool?</code> | Filter for requests where diarize was used |
| <code>dictation</code> | <code>bool?</code> | Filter for requests where dictation was used |
| <code>encoding</code> | <code>bool?</code> | Filter for requests where encoding was used |
| <code>endpoint</code> | <code>[V1ProjectsProjectIdUsageGetParametersEndpoint?](Models/Enums/V1ProjectsProjectIdUsageGetParametersEndpoint.cs)</code> | Filter for requests where a specific endpoint was used |
| <code>extra</code> | <code>bool?</code> | Filter for requests where extra was used |
| <code>fillerWords</code> | <code>bool?</code> | Filter for requests where filler words was used |
| <code>intents</code> | <code>bool?</code> | Filter for requests where intents was used |
| <code>keyterm</code> | <code>bool?</code> | Filter for requests where keyterm was used |
| <code>keywords</code> | <code>bool?</code> | Filter for requests where keywords was used |
| <code>language</code> | <code>bool?</code> | Filter for requests where language was used |
| <code>measurements</code> | <code>bool?</code> | Filter for requests where measurements were used |
| <code>method</code> | <code>[V1ProjectsProjectIdUsageGetParametersMethod?](Models/Enums/V1ProjectsProjectIdUsageGetParametersMethod.cs)</code> | Filter for requests where a specific method was used |
| <code>model</code> | <code>string?</code> | Filter for requests where a specific model uuid was used |
| <code>multichannel</code> | <code>bool?</code> | Filter for requests where multichannel was used |
| <code>numerals</code> | <code>bool?</code> | Filter for requests where numerals were used |
| <code>paragraphs</code> | <code>bool?</code> | Filter for requests where paragraphs were used |
| <code>profanityFilter</code> | <code>bool?</code> | Filter for requests where profanity filter was used |
| <code>punctuate</code> | <code>bool?</code> | Filter for requests where punctuate was used |
| <code>redact</code> | <code>bool?</code> | Filter for requests where redact was used |
| <code>replace</code> | <code>bool?</code> | Filter for requests where replace was used |
| <code>sampleRate</code> | <code>bool?</code> | Filter for requests where sample rate was used |
| <code>search</code> | <code>bool?</code> | Filter for requests where search was used |
| <code>sentiment</code> | <code>bool?</code> | Filter for requests where sentiment was used |
| <code>smartFormat</code> | <code>bool?</code> | Filter for requests where smart format was used |
| <code>summarize</code> | <code>bool?</code> | Filter for requests where summarize was used |
| <code>tag</code> | <code>string?</code> | Filter for requests where a specific tag was used |
| <code>topics</code> | <code>bool?</code> | Filter for requests where topics was used |
| <code>uttSplit</code> | <code>bool?</code> | Filter for requests where utt split was used |
| <code>utterances</code> | <code>bool?</code> | Filter for requests where utterances was used |
| <code>version</code> | <code>bool?</code> | Filter for requests where version was used |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageV1Response](Models/UsageV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get8Error](Errors/Get8Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsUsageBreakdown

> Source: [ManageV1ProjectsUsageBreakdown](Api/ManageV1ProjectsUsageBreakdown.cs)

<details>
<summary><code>Task&lt;UsageBreakdownV1Response&gt; Get9(string projectId, DateTimeOffset? start, DateTimeOffset? end, V1ProjectsProjectIdUsageBreakdownGetParametersGrouping? grouping, string? accessor, bool? alternatives, bool? callbackMethod, bool? callback, bool? channels, bool? customIntentMode, bool? customIntent, bool? customTopicMode, bool? customTopic, V1ProjectsProjectIdUsageBreakdownGetParametersDeployment? deployment, bool? detectEntities, bool? detectLanguage, bool? diarize, bool? dictation, bool? encoding, V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint? endpoint, bool? extra, bool? fillerWords, bool? intents, bool? keyterm, bool? keywords, bool? language, bool? measurements, V1ProjectsProjectIdUsageBreakdownGetParametersMethod? method, string? model, bool? multichannel, bool? numerals, bool? paragraphs, bool? profanityFilter, bool? punctuate, bool? redact, bool? replace, bool? sampleRate, bool? search, bool? sentiment, bool? smartFormat, bool? summarize, string? tag, bool? topics, bool? uttSplit, bool? utterances, bool? version, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the usage breakdown for a specific project, with various filter options by API feature or by groupings. Setting a feature (e.g. diarize) to true includes requests that used that feature, while false excludes requests that used it. Multiple true filters are combined with OR logic, while false filters use AND logic.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsUsageBreakdown.Get9(projectId,
        start,
        end,
        grouping,
        accessor,
        alternatives,
        callbackMethod,
        callback,
        channels,
        customIntentMode,
        customIntent,
        customTopicMode,
        customTopic,
        deployment,
        detectEntities,
        detectLanguage,
        diarize,
        dictation,
        encoding,
        endpoint,
        extra,
        fillerWords,
        intents,
        keyterm,
        keywords,
        language,
        measurements,
        method,
        model,
        multichannel,
        numerals,
        paragraphs,
        profanityFilter,
        punctuate,
        redact,
        replace,
        sampleRate,
        search,
        sentiment,
        smartFormat,
        summarize,
        tag,
        topics,
        uttSplit,
        utterances,
        version,
        authorization);
    // TODO: Handle 'response' of type UsageBreakdownV1Response
}
catch (SdkException<Get9Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get9Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>start</code> | <code>DateTimeOffset?</code> | Start date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>end</code> | <code>DateTimeOffset?</code> | End date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>grouping</code> | <code>[V1ProjectsProjectIdUsageBreakdownGetParametersGrouping?](Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersGrouping.cs)</code> | Common usage grouping parameters |
| <code>accessor</code> | <code>string?</code> | Filter for requests where a specific accessor was used |
| <code>alternatives</code> | <code>bool?</code> | Filter for requests where alternatives were used |
| <code>callbackMethod</code> | <code>bool?</code> | Filter for requests where callback method was used |
| <code>callback</code> | <code>bool?</code> | Filter for requests where callback was used |
| <code>channels</code> | <code>bool?</code> | Filter for requests where channels were used |
| <code>customIntentMode</code> | <code>bool?</code> | Filter for requests where custom intent mode was used |
| <code>customIntent</code> | <code>bool?</code> | Filter for requests where custom intent was used |
| <code>customTopicMode</code> | <code>bool?</code> | Filter for requests where custom topic mode was used |
| <code>customTopic</code> | <code>bool?</code> | Filter for requests where custom topic was used |
| <code>deployment</code> | <code>[V1ProjectsProjectIdUsageBreakdownGetParametersDeployment?](Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersDeployment.cs)</code> | Filter for requests where a specific deployment was used |
| <code>detectEntities</code> | <code>bool?</code> | Filter for requests where detect entities was used |
| <code>detectLanguage</code> | <code>bool?</code> | Filter for requests where detect language was used |
| <code>diarize</code> | <code>bool?</code> | Filter for requests where diarize was used |
| <code>dictation</code> | <code>bool?</code> | Filter for requests where dictation was used |
| <code>encoding</code> | <code>bool?</code> | Filter for requests where encoding was used |
| <code>endpoint</code> | <code>[V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint?](Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint.cs)</code> | Filter for requests where a specific endpoint was used |
| <code>extra</code> | <code>bool?</code> | Filter for requests where extra was used |
| <code>fillerWords</code> | <code>bool?</code> | Filter for requests where filler words was used |
| <code>intents</code> | <code>bool?</code> | Filter for requests where intents was used |
| <code>keyterm</code> | <code>bool?</code> | Filter for requests where keyterm was used |
| <code>keywords</code> | <code>bool?</code> | Filter for requests where keywords was used |
| <code>language</code> | <code>bool?</code> | Filter for requests where language was used |
| <code>measurements</code> | <code>bool?</code> | Filter for requests where measurements were used |
| <code>method</code> | <code>[V1ProjectsProjectIdUsageBreakdownGetParametersMethod?](Models/Enums/V1ProjectsProjectIdUsageBreakdownGetParametersMethod.cs)</code> | Filter for requests where a specific method was used |
| <code>model</code> | <code>string?</code> | Filter for requests where a specific model uuid was used |
| <code>multichannel</code> | <code>bool?</code> | Filter for requests where multichannel was used |
| <code>numerals</code> | <code>bool?</code> | Filter for requests where numerals were used |
| <code>paragraphs</code> | <code>bool?</code> | Filter for requests where paragraphs were used |
| <code>profanityFilter</code> | <code>bool?</code> | Filter for requests where profanity filter was used |
| <code>punctuate</code> | <code>bool?</code> | Filter for requests where punctuate was used |
| <code>redact</code> | <code>bool?</code> | Filter for requests where redact was used |
| <code>replace</code> | <code>bool?</code> | Filter for requests where replace was used |
| <code>sampleRate</code> | <code>bool?</code> | Filter for requests where sample rate was used |
| <code>search</code> | <code>bool?</code> | Filter for requests where search was used |
| <code>sentiment</code> | <code>bool?</code> | Filter for requests where sentiment was used |
| <code>smartFormat</code> | <code>bool?</code> | Filter for requests where smart format was used |
| <code>summarize</code> | <code>bool?</code> | Filter for requests where summarize was used |
| <code>tag</code> | <code>string?</code> | Filter for requests where a specific tag was used |
| <code>topics</code> | <code>bool?</code> | Filter for requests where topics was used |
| <code>uttSplit</code> | <code>bool?</code> | Filter for requests where utt split was used |
| <code>utterances</code> | <code>bool?</code> | Filter for requests where utterances was used |
| <code>version</code> | <code>bool?</code> | Filter for requests where version was used |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageBreakdownV1Response](Models/UsageBreakdownV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get9Error](Errors/Get9Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsUsageFields

> Source: [ManageV1ProjectsUsageFields](Api/ManageV1ProjectsUsageFields.cs)

<details>
<summary><code>Task&lt;UsageFieldsV1Response&gt; List12(string projectId, DateTimeOffset? start, DateTimeOffset? end, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the features, models, tags, languages, and processing method used for requests in the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageV1ProjectsUsageFields.List12(projectId, start, end, authorization);
    // TODO: Handle 'response' of type UsageFieldsV1Response
}
catch (SdkException<List12Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List12Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>start</code> | <code>DateTimeOffset?</code> | Start date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>end</code> | <code>DateTimeOffset?</code> | End date of the requested date range. Format accepted is YYYY-MM-DD |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageFieldsV1Response](Models/UsageFieldsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List12Error](Errors/List12Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ReadV1Text

> Source: [ReadV1Text](Api/ReadV1Text.cs)

<details>
<summary><code>Task&lt;ReadV1Response&gt; Analyze(string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V1ReadPostParametersSummarize? summarize, V1ReadPostParametersTag? tag, V1ReadPostParametersCustomTopic? customTopic, V1ListenPostParametersCustomTopicMode? customTopicMode, V1ReadPostParametersCustomIntent? customIntent, V1ListenPostParametersCustomTopicMode? customIntentMode, string authorization, ReadV1Request? body, bool? sentiment = false, bool? topics = false, bool? intents = false, string? language = "en", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Analyze text content using Deepgrams text analysis API

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ReadV1Text.Analyze(callback,
        callbackMethod,
        summarize,
        tag,
        customTopic,
        customTopicMode,
        customIntent,
        customIntentMode,
        authorization,
        body);
    // TODO: Handle 'response' of type ReadV1Response
}
catch (SdkException<AnalyzeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AnalyzeError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>callback</code> | <code>string?</code> | URL to which we'll make the callback request |
| <code>callbackMethod</code> | <code>[V1ListenPostParametersCallbackMethod?](Models/Enums/V1ListenPostParametersCallbackMethod.cs)</code> | HTTP method by which the callback request will be made |
| <code>summarize</code> | <code>[V1ReadPostParametersSummarize?](Models/AnyOf/V1ReadPostParametersSummarize.cs)</code> | Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only. |
| <code>tag</code> | <code>[V1ReadPostParametersTag?](Models/AnyOf/V1ReadPostParametersTag.cs)</code> | Label your requests for the purpose of identification during usage reporting |
| <code>customTopic</code> | <code>[V1ReadPostParametersCustomTopic?](Models/AnyOf/V1ReadPostParametersCustomTopic.cs)</code> | Custom topics you want the model to detect within your input audio or text if present Submit up to `100`. |
| <code>customTopicMode</code> | <code>[V1ListenPostParametersCustomTopicMode?](Models/Enums/V1ListenPostParametersCustomTopicMode.cs)</code> | Sets how the model will interpret strings submitted to the `custom_topic` param. When `strict`, the model will only return topics submitted using the `custom_topic` param. When `extended`, the model will return its own detected topics in addition to those submitted using the `custom_topic` param |
| <code>customIntent</code> | <code>[V1ReadPostParametersCustomIntent?](Models/AnyOf/V1ReadPostParametersCustomIntent.cs)</code> | Custom intents you want the model to detect within your input audio if present |
| <code>customIntentMode</code> | <code>[V1ListenPostParametersCustomTopicMode?](Models/Enums/V1ListenPostParametersCustomTopicMode.cs)</code> | Sets how the model will interpret intents submitted to the `custom_intent` param. When `strict`, the model will only return intents submitted using the `custom_intent` param. When `extended`, the model will return its own detected intents in the `custom_intent` param. |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[ReadV1Request?](Models/AnyOf/ReadV1Request.cs)</code> | - |
| <code>sentiment</code> | <code>bool?</code> | Recognizes the sentiment throughout a transcript or text<br>**Default**: false |
| <code>topics</code> | <code>bool?</code> | Detect topics throughout a transcript or text<br>**Default**: false |
| <code>intents</code> | <code>bool?</code> | Recognizes speaker intent throughout a transcript or text<br>**Default**: false |
| <code>language</code> | <code>string?</code> | The [BCP-47 language tag](https://tools.ietf.org/html/bcp47) that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available<br>**Default**: "en" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReadV1Response](Models/ReadV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AnalyzeError](Errors/AnalyzeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SelfHostedV1DistributionCredentials

> Source: [SelfHostedV1DistributionCredentials](Api/SelfHostedV1DistributionCredentials.cs)

<details>
<summary><code>Task&lt;CreateProjectDistributionCredentialsV1Response&gt; Create5(string projectId, IReadOnlyList&lt;V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems&gt;? scopes, V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider? provider, string authorization, CreateProjectDistributionCredentialsV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a set of distribution credentials for the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SelfHostedV1DistributionCredentials.Create5(projectId,
        scopes,
        provider,
        authorization,
        body);
    // TODO: Handle 'response' of type CreateProjectDistributionCredentialsV1Response
}
catch (SdkException<Create5Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Create5Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>scopes</code> | <code>IReadOnlyList&lt;[V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems](Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems.cs)&gt;?</code> | List of permission scopes for the credentials |
| <code>provider</code> | <code>[V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider?](Models/Enums/V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider.cs)</code> | The provider of the distribution service |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[CreateProjectDistributionCredentialsV1Request?](Models/CreateProjectDistributionCredentialsV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateProjectDistributionCredentialsV1Response](Models/CreateProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Create5Error](Errors/Create5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectDistributionCredentialsV1Response&gt; Delete7(string projectId, string distributionCredentialsId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a set of distribution credentials for the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SelfHostedV1DistributionCredentials.Delete7(projectId,
        distributionCredentialsId,
        authorization);
    // TODO: Handle 'response' of type GetProjectDistributionCredentialsV1Response
}
catch (SdkException<Delete7Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Delete7Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>distributionCredentialsId</code> | <code>string</code> | The UUID of the distribution credentials |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectDistributionCredentialsV1Response](Models/GetProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Delete7Error](Errors/Delete7Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectDistributionCredentialsV1Response&gt; Get11(string projectId, string distributionCredentialsId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a set of distribution credentials for the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SelfHostedV1DistributionCredentials.Get11(projectId,
        distributionCredentialsId,
        authorization);
    // TODO: Handle 'response' of type GetProjectDistributionCredentialsV1Response
}
catch (SdkException<Get11Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get11Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>distributionCredentialsId</code> | <code>string</code> | The UUID of the distribution credentials |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectDistributionCredentialsV1Response](Models/GetProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get11Error](Errors/Get11Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectDistributionCredentialsV1Response&gt; List17(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists sets of distribution credentials for the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SelfHostedV1DistributionCredentials.List17(projectId, authorization);
    // TODO: Handle 'response' of type ListProjectDistributionCredentialsV1Response
}
catch (SdkException<List17Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List17Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectDistributionCredentialsV1Response](Models/ListProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List17Error](Errors/List17Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SpeakV1Audio

> Source: [SpeakV1Audio](Api/SpeakV1Audio.cs)

<details>
<summary><code>Task&lt;object&gt; Generate(string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V1SpeakPostParametersTag? tag, V1SpeakPostParametersBitRate? bitRate, V1SpeakPostParametersContainer? container, V1SpeakPostParametersEncoding? encoding, V1SpeakPostParametersModel? model, V1SpeakPostParametersSampleRate? sampleRate, string authorization, SpeakV1Request? body, bool? mipOptOut = false, double? speed = 1d, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Convert text into natural-sounding speech using Deepgram's TTS REST API

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SpeakV1Audio.Generate(callback,
        callbackMethod,
        tag,
        bitRate,
        container,
        encoding,
        model,
        sampleRate,
        authorization,
        body);
    // TODO: Handle 'response' of type object
}
catch (SdkException<GenerateError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GenerateError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>callback</code> | <code>string?</code> | URL to which we'll make the callback request |
| <code>callbackMethod</code> | <code>[V1ListenPostParametersCallbackMethod?](Models/Enums/V1ListenPostParametersCallbackMethod.cs)</code> | HTTP method by which the callback request will be made |
| <code>tag</code> | <code>[V1SpeakPostParametersTag?](Models/AnyOf/V1SpeakPostParametersTag.cs)</code> | Label your requests for the purpose of identification during usage reporting |
| <code>bitRate</code> | <code>[V1SpeakPostParametersBitRate?](Models/AnyOf/V1SpeakPostParametersBitRate.cs)</code> | The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type. |
| <code>container</code> | <code>[V1SpeakPostParametersContainer?](Models/AnyOf/V1SpeakPostParametersContainer.cs)</code> | Container specifies the file format wrapper for the output audio. The available options depend on the encoding type. |
| <code>encoding</code> | <code>[V1SpeakPostParametersEncoding?](Models/AnyOf/V1SpeakPostParametersEncoding.cs)</code> | Encoding allows you to specify the expected encoding of your audio output |
| <code>model</code> | <code>[V1SpeakPostParametersModel?](Models/Enums/V1SpeakPostParametersModel.cs)</code> | AI model used to process submitted text |
| <code>sampleRate</code> | <code>[V1SpeakPostParametersSampleRate?](Models/AnyOf/V1SpeakPostParametersSampleRate.cs)</code> | Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[SpeakV1Request?](Models/SpeakV1Request.cs)</code> | - |
| <code>mipOptOut</code> | <code>bool?</code> | Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip<br>**Default**: false |
| <code>speed</code> | <code>double?</code> | Speaking rate multiplier that adjusts the pace of generated speech while preserving natural prosody and voice quality. Not yet supported in all languages.<br>**Default**: 1d |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GenerateError](Errors/GenerateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SpeakV2Audio

> Source: [SpeakV2Audio](Api/SpeakV2Audio.cs)

<details>
<summary><code>Task&lt;SpeakV2AcceptedResponse&gt; Generate2(string model, string? callback, V1ListenPostParametersCallbackMethod? callbackMethod, V2SpeakPostParametersTag? tag, V2SpeakPostParametersBitRate? bitRate, V2SpeakPostParametersContainer? container, V2SpeakPostParametersEncoding? encoding, V2SpeakPostParametersSampleRate? sampleRate, V2SpeakPostParametersPriority? priority, string authorization, SpeakV2Request? body, bool? mipOptOut = false, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SpeakV2Audio.Generate2(model,
        callback,
        callbackMethod,
        tag,
        bitRate,
        container,
        encoding,
        sampleRate,
        priority,
        authorization,
        body);
    // TODO: Handle 'response' of type SpeakV2AcceptedResponse
}
catch (SdkException<Generate2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Generate2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>model</code> | <code>string</code> | Flux TTS model used to synthesize the submitted text, in the form `flux-{voice}-{language}` (for example, `flux-alexis-en`). Required; unlike the v1 (Aura) endpoint there is no default and only flux models are accepted. English-only at launch. |
| <code>callback</code> | <code>string?</code> | URL to which we'll make the callback request |
| <code>callbackMethod</code> | <code>[V1ListenPostParametersCallbackMethod?](Models/Enums/V1ListenPostParametersCallbackMethod.cs)</code> | HTTP method by which the callback request will be made |
| <code>tag</code> | <code>[V2SpeakPostParametersTag?](Models/AnyOf/V2SpeakPostParametersTag.cs)</code> | Label your requests for the purpose of identification during usage reporting |
| <code>bitRate</code> | <code>[V2SpeakPostParametersBitRate?](Models/AnyOf/V2SpeakPostParametersBitRate.cs)</code> | The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type. |
| <code>container</code> | <code>[V2SpeakPostParametersContainer?](Models/AnyOf/V2SpeakPostParametersContainer.cs)</code> | Container specifies the file format wrapper for the output audio. The available options depend on the encoding type. |
| <code>encoding</code> | <code>[V2SpeakPostParametersEncoding?](Models/AnyOf/V2SpeakPostParametersEncoding.cs)</code> | Encoding allows you to specify the expected encoding of your audio output |
| <code>sampleRate</code> | <code>[V2SpeakPostParametersSampleRate?](Models/AnyOf/V2SpeakPostParametersSampleRate.cs)</code> | Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable |
| <code>priority</code> | <code>[V2SpeakPostParametersPriority?](Models/Enums/V2SpeakPostParametersPriority.cs)</code> | Processing priority for asynchronous (callback) requests. The only supported value is low. |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[SpeakV2Request?](Models/SpeakV2Request.cs)</code> | - |
| <code>mipOptOut</code> | <code>bool?</code> | Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip<br>**Default**: false |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SpeakV2AcceptedResponse](Models/SpeakV2AcceptedResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Generate2Error](Errors/Generate2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VoiceAgentConfigurations

> Source: [VoiceAgentConfigurations](Api/VoiceAgentConfigurations.cs)

<details>
<summary><code>Task&lt;CreateAgentConfigurationV1Response&gt; Create(string projectId, string authorization, CreateAgentConfigurationV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new reusable agent configuration. The `config` field must be a valid JSON string representing the `agent` block of a Settings message. The returned `agent_id` can be passed in place of the full `agent` object in future Settings messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentConfigurations.Create(projectId, authorization, body);
    // TODO: Handle 'response' of type CreateAgentConfigurationV1Response
}
catch (SdkException<CreateError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[CreateAgentConfigurationV1Request?](Models/CreateAgentConfigurationV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateAgentConfigurationV1Response](Models/CreateAgentConfigurationV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateError](Errors/CreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; Delete(string projectId, string agentId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the specified agent configuration. Deleting an agent configuration can cause a production outage if your service references this agent UUID. Migrate all active sessions to a new configuration before deleting.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentConfigurations.Delete(projectId, agentId, authorization);
    // TODO: Handle 'response' of type object
}
catch (SdkException<DeleteError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>agentId</code> | <code>string</code> | The unique identifier of the agent configuration |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteError](Errors/DeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentConfigurationV1&gt; Get(string projectId, string agentId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the specified agent configuration in its uninterpolated form

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentConfigurations.Get(projectId, agentId, authorization);
    // TODO: Handle 'response' of type AgentConfigurationV1
}
catch (SdkException<GetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>agentId</code> | <code>string</code> | The unique identifier of the agent configuration |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentConfigurationV1](Models/AgentConfigurationV1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetError](Errors/GetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListAgentConfigurationsV1Response&gt; List2(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all agent configurations for the specified project. Configurations are returned in their uninterpolated form—template variable placeholders appear as-is rather than with their substituted values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentConfigurations.List2(projectId, authorization);
    // TODO: Handle 'response' of type ListAgentConfigurationsV1Response
}
catch (SdkException<List2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListAgentConfigurationsV1Response](Models/ListAgentConfigurationsV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List2Error](Errors/List2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentConfigurationV1&gt; Update(string projectId, string agentId, string authorization, UpdateAgentMetadataV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the metadata associated with an agent configuration. The config itself is immutable—to change the configuration, delete the existing agent and create a new one.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentConfigurations.Update(projectId, agentId, authorization, body);
    // TODO: Handle 'response' of type AgentConfigurationV1
}
catch (SdkException<UpdateError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>agentId</code> | <code>string</code> | The unique identifier of the agent configuration |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[UpdateAgentMetadataV1Request?](Models/UpdateAgentMetadataV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentConfigurationV1](Models/AgentConfigurationV1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateError](Errors/UpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VoiceAgentVariables

> Source: [VoiceAgentVariables](Api/VoiceAgentVariables.cs)

<details>
<summary><code>Task&lt;AgentVariableV1&gt; Create2(string projectId, string authorization, CreateAgentVariableV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new template variable. Variables follow the `DG_<VARIABLE_NAME>` naming format and can substitute any JSON value in an agent configuration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentVariables.Create2(projectId, authorization, body);
    // TODO: Handle 'response' of type AgentVariableV1
}
catch (SdkException<Create2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Create2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[CreateAgentVariableV1Request?](Models/CreateAgentVariableV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentVariableV1](Models/AgentVariableV1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Create2Error](Errors/Create2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; Delete2(string projectId, string variableId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the specified template variable

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentVariables.Delete2(projectId, variableId, authorization);
    // TODO: Handle 'response' of type object
}
catch (SdkException<Delete2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Delete2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>variableId</code> | <code>string</code> | The unique identifier of the agent variable |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Delete2Error](Errors/Delete2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentVariableV1&gt; Get2(string projectId, string variableId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the specified template variable

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentVariables.Get2(projectId, variableId, authorization);
    // TODO: Handle 'response' of type AgentVariableV1
}
catch (SdkException<Get2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Get2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>variableId</code> | <code>string</code> | The unique identifier of the agent variable |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentVariableV1](Models/AgentVariableV1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Get2Error](Errors/Get2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListAgentVariablesV1Response&gt; List3(string projectId, string authorization, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all template variables for the specified project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentVariables.List3(projectId, authorization);
    // TODO: Handle 'response' of type ListAgentVariablesV1Response
}
catch (SdkException<List3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type List3Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListAgentVariablesV1Response](Models/ListAgentVariablesV1Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[List3Error](Errors/List3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentVariableV1&gt; Update2(string projectId, string variableId, string authorization, UpdateAgentVariableV1Request? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the value of an existing template variable

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VoiceAgentVariables.Update2(projectId, variableId, authorization, body);
    // TODO: Handle 'response' of type AgentVariableV1
}
catch (SdkException<Update2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Update2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>string</code> | The unique identifier of the project |
| <code>variableId</code> | <code>string</code> | The unique identifier of the agent variable |
| <code>authorization</code> | <code>string</code> | Use `Authorization: Token <API_KEY>`<br>Example: `Authorization: Token 12345abcdef` |
| <code>body</code> | <code>[UpdateAgentVariableV1Request?](Models/UpdateAgentVariableV1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentVariableV1](Models/AgentVariableV1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[Update2Error](Errors/Update2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

