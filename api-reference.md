# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [DeepgramClient](DeepgramClient.cs)

## AgentV1SettingsThinkModels

> Source: [AgentV1SettingsThinkModels](Api/AgentV1SettingsThinkModels.cs)

<details>
<summary><code>Task&lt;AgentThinkModelsV1Response&gt; List(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
catch (ApiException<ListError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentThinkModelsV1Response](Models/AgentThinkModelsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListError](Errors/ListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthV1Tokens

> Source: [AuthV1Tokens](Api/AuthV1Tokens.cs)

<details>
<summary><code>Task&lt;GrantV1Response&gt; Grant(GrantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.AuthV1Tokens.Grant(new GrantRequest());
    // TODO: Handle 'response' of type GrantV1Response
}
catch (ApiException<GrantError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GrantRequest](Requests/AuthV1Tokens/GrantRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantV1Response](Models/GrantV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GrantError](Errors/GrantError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ListenV1Media

> Source: [ListenV1Media](Api/ListenV1Media.cs)

<details>
<summary><code>Task&lt;ListenV1MediaTranscribeResponse200&gt; Transcribe(TranscribeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ListenV1Media.Transcribe(new TranscribeRequest());
    // TODO: Handle 'response' of type ListenV1MediaTranscribeResponse200
}
catch (ApiException<TranscribeError> ex)
{
    if (ex.Error.TryGetListenV1Response(out var error))
    {
        // TODO: Handle 'error' of type ListenV1Response
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TranscribeRequest](Requests/ListenV1Media/TranscribeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListenV1MediaTranscribeResponse200](Models/AnyOf/ListenV1MediaTranscribeResponse200.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[TranscribeError](Errors/TranscribeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1Models

> Source: [ManageV1Models](Api/ManageV1Models.cs)

<details>
<summary><code>Task&lt;GetModelV1Response&gt; Get5(Get5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1Models.Get5(new Get5Request { ModelId = "some example string" });
    // TODO: Handle 'response' of type GetModelV1Response
}
catch (ApiException<Get5Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get5Request](Requests/ManageV1Models/Get5Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetModelV1Response](Models/AnyOf/GetModelV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get5Error](Errors/Get5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListModelsV1Response&gt; List6(List6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1Models.List6(new List6Request());
    // TODO: Handle 'response' of type ListModelsV1Response
}
catch (ApiException<List6Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List6Request](Requests/ManageV1Models/List6Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListModelsV1Response](Models/ListModelsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List6Error](Errors/List6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1Projects

> Source: [ManageV1Projects](Api/ManageV1Projects.cs)

<details>
<summary><code>Task&lt;DeleteProjectV1Response&gt; Delete3(Delete3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1Projects.Delete3(new Delete3Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type DeleteProjectV1Response
}
catch (ApiException<Delete3Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Delete3Request](Requests/ManageV1Projects/Delete3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectV1Response](Models/DeleteProjectV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Delete3Error](Errors/Delete3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectV1Response&gt; Get3(Get3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1Projects.Get3(new Get3Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type GetProjectV1Response
}
catch (ApiException<Get3Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get3Request](Requests/ManageV1Projects/Get3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectV1Response](Models/GetProjectV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get3Error](Errors/Get3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LeaveProjectV1Response&gt; Leave(LeaveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1Projects.Leave(new LeaveRequest { ProjectId = "some example string" });
    // TODO: Handle 'response' of type LeaveProjectV1Response
}
catch (ApiException<LeaveError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LeaveRequest](Requests/ManageV1Projects/LeaveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LeaveProjectV1Response](Models/LeaveProjectV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[LeaveError](Errors/LeaveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectsV1Response&gt; List4(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1Projects.List4();
    // TODO: Handle 'response' of type ListProjectsV1Response
}
catch (ApiException<List4Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectsV1Response](Models/ListProjectsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List4Error](Errors/List4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateProjectV1Response&gt; Update3(Update3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1Projects.Update3(new Update3Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type UpdateProjectV1Response
}
catch (ApiException<Update3Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Update3Request](Requests/ManageV1Projects/Update3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateProjectV1Response](Models/UpdateProjectV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Update3Error](Errors/Update3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingBalances

> Source: [ManageV1ProjectsBillingBalances](Api/ManageV1ProjectsBillingBalances.cs)

<details>
<summary><code>Task&lt;GetProjectBalanceV1Response&gt; Get10(Get10Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsBillingBalances.Get10(new Get10Request
    {
        ProjectId = "some example string",
        BalanceId = "some example string",
    });
    // TODO: Handle 'response' of type GetProjectBalanceV1Response
}
catch (ApiException<Get10Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get10Request](Requests/ManageV1ProjectsBillingBalances/Get10Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectBalanceV1Response](Models/GetProjectBalanceV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get10Error](Errors/Get10Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectBalancesV1Response&gt; List13(List13Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsBillingBalances.List13(new List13Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type ListProjectBalancesV1Response
}
catch (ApiException<List13Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List13Request](Requests/ManageV1ProjectsBillingBalances/List13Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectBalancesV1Response](Models/ListProjectBalancesV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List13Error](Errors/List13Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingBreakdown

> Source: [ManageV1ProjectsBillingBreakdown](Api/ManageV1ProjectsBillingBreakdown.cs)

<details>
<summary><code>Task&lt;BillingBreakdownV1Response&gt; List14(List14Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsBillingBreakdown.List14(new List14Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type BillingBreakdownV1Response
}
catch (ApiException<List14Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List14Request](Requests/ManageV1ProjectsBillingBreakdown/List14Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingBreakdownV1Response](Models/BillingBreakdownV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List14Error](Errors/List14Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingFields

> Source: [ManageV1ProjectsBillingFields](Api/ManageV1ProjectsBillingFields.cs)

<details>
<summary><code>Task&lt;ListBillingFieldsV1Response&gt; List15(List15Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsBillingFields.List15(new List15Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type ListBillingFieldsV1Response
}
catch (ApiException<List15Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List15Request](Requests/ManageV1ProjectsBillingFields/List15Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBillingFieldsV1Response](Models/ListBillingFieldsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List15Error](Errors/List15Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsBillingPurchases

> Source: [ManageV1ProjectsBillingPurchases](Api/ManageV1ProjectsBillingPurchases.cs)

<details>
<summary><code>Task&lt;ListProjectPurchasesV1Response&gt; List16(List16Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsBillingPurchases.List16(new List16Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type ListProjectPurchasesV1Response
}
catch (ApiException<List16Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List16Request](Requests/ManageV1ProjectsBillingPurchases/List16Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectPurchasesV1Response](Models/ListProjectPurchasesV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List16Error](Errors/List16Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsKeys

> Source: [ManageV1ProjectsKeys](Api/ManageV1ProjectsKeys.cs)

<details>
<summary><code>Task&lt;CreateKeyV1Response&gt; Create3(Create3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsKeys.Create3(new Create3Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type CreateKeyV1Response
}
catch (ApiException<Create3Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Create3Request](Requests/ManageV1ProjectsKeys/Create3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateKeyV1Response](Models/CreateKeyV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Create3Error](Errors/Create3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteProjectKeyV1Response&gt; Delete4(Delete4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsKeys.Delete4(new Delete4Request
    {
        ProjectId = "some example string",
        KeyId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteProjectKeyV1Response
}
catch (ApiException<Delete4Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Delete4Request](Requests/ManageV1ProjectsKeys/Delete4Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectKeyV1Response](Models/DeleteProjectKeyV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Delete4Error](Errors/Delete4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectKeyV1Response&gt; Get6(Get6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsKeys.Get6(new Get6Request
    {
        ProjectId = "some example string",
        KeyId = "some example string",
    });
    // TODO: Handle 'response' of type GetProjectKeyV1Response
}
catch (ApiException<Get6Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get6Request](Requests/ManageV1ProjectsKeys/Get6Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectKeyV1Response](Models/GetProjectKeyV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get6Error](Errors/Get6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectKeysV1Response&gt; List7(List7Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsKeys.List7(new List7Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type ListProjectKeysV1Response
}
catch (ApiException<List7Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List7Request](Requests/ManageV1ProjectsKeys/List7Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectKeysV1Response](Models/ListProjectKeysV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List7Error](Errors/List7Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsMembers

> Source: [ManageV1ProjectsMembers](Api/ManageV1ProjectsMembers.cs)

<details>
<summary><code>Task&lt;DeleteProjectMemberV1Response&gt; Delete5(Delete5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsMembers.Delete5(new Delete5Request
    {
        ProjectId = "some example string",
        MemberId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteProjectMemberV1Response
}
catch (ApiException<Delete5Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Delete5Request](Requests/ManageV1ProjectsMembers/Delete5Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectMemberV1Response](Models/DeleteProjectMemberV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Delete5Error](Errors/Delete5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectMembersV1Response&gt; List8(List8Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsMembers.List8(new List8Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type ListProjectMembersV1Response
}
catch (ApiException<List8Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List8Request](Requests/ManageV1ProjectsMembers/List8Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectMembersV1Response](Models/ListProjectMembersV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List8Error](Errors/List8Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsMembersInvites

> Source: [ManageV1ProjectsMembersInvites](Api/ManageV1ProjectsMembersInvites.cs)

<details>
<summary><code>Task&lt;CreateProjectInviteV1Response&gt; Create4(Create4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsMembersInvites.Create4(new Create4Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type CreateProjectInviteV1Response
}
catch (ApiException<Create4Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Create4Request](Requests/ManageV1ProjectsMembersInvites/Create4Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateProjectInviteV1Response](Models/CreateProjectInviteV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Create4Error](Errors/Create4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteProjectInviteV1Response&gt; Delete6(Delete6Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsMembersInvites.Delete6(new Delete6Request
    {
        ProjectId = "some example string",
        Email = "some example string",
    });
    // TODO: Handle 'response' of type DeleteProjectInviteV1Response
}
catch (ApiException<Delete6Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Delete6Request](Requests/ManageV1ProjectsMembersInvites/Delete6Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteProjectInviteV1Response](Models/DeleteProjectInviteV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Delete6Error](Errors/Delete6Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectInvitesV1Response&gt; List10(List10Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsMembersInvites.List10(new List10Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type ListProjectInvitesV1Response
}
catch (ApiException<List10Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List10Request](Requests/ManageV1ProjectsMembersInvites/List10Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectInvitesV1Response](Models/ListProjectInvitesV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List10Error](Errors/List10Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsMembersScopes

> Source: [ManageV1ProjectsMembersScopes](Api/ManageV1ProjectsMembersScopes.cs)

<details>
<summary><code>Task&lt;ListProjectMemberScopesV1Response&gt; List9(List9Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsMembersScopes.List9(new List9Request
    {
        ProjectId = "some example string",
        MemberId = "some example string",
    });
    // TODO: Handle 'response' of type ListProjectMemberScopesV1Response
}
catch (ApiException<List9Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List9Request](Requests/ManageV1ProjectsMembersScopes/List9Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectMemberScopesV1Response](Models/ListProjectMemberScopesV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List9Error](Errors/List9Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateProjectMemberScopesV1Response&gt; Update4(Update4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsMembersScopes.Update4(new Update4Request
    {
        ProjectId = "some example string",
        MemberId = "some example string",
    });
    // TODO: Handle 'response' of type UpdateProjectMemberScopesV1Response
}
catch (ApiException<Update4Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Update4Request](Requests/ManageV1ProjectsMembersScopes/Update4Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateProjectMemberScopesV1Response](Models/UpdateProjectMemberScopesV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Update4Error](Errors/Update4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsModels

> Source: [ManageV1ProjectsModels](Api/ManageV1ProjectsModels.cs)

<details>
<summary><code>Task&lt;GetModelV1Response&gt; Get4(Get4Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsModels.Get4(new Get4Request
    {
        ProjectId = "some example string",
        ModelId = "some example string",
    });
    // TODO: Handle 'response' of type GetModelV1Response
}
catch (ApiException<Get4Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get4Request](Requests/ManageV1ProjectsModels/Get4Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetModelV1Response](Models/AnyOf/GetModelV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get4Error](Errors/Get4Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListModelsV1Response&gt; List5(List5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsModels.List5(new List5Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type ListModelsV1Response
}
catch (ApiException<List5Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List5Request](Requests/ManageV1ProjectsModels/List5Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListModelsV1Response](Models/ListModelsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List5Error](Errors/List5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsRequests

> Source: [ManageV1ProjectsRequests](Api/ManageV1ProjectsRequests.cs)

<details>
<summary><code>Task&lt;GetProjectRequestV1Response&gt; Get7(Get7Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsRequests.Get7(new Get7Request
    {
        ProjectId = "some example string",
        RequestId = "some example string",
    });
    // TODO: Handle 'response' of type GetProjectRequestV1Response
}
catch (ApiException<Get7Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get7Request](Requests/ManageV1ProjectsRequests/Get7Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectRequestV1Response](Models/GetProjectRequestV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get7Error](Errors/Get7Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectRequestsV1Response&gt; List11(List11Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsRequests.List11(new List11Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type ListProjectRequestsV1Response
}
catch (ApiException<List11Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List11Request](Requests/ManageV1ProjectsRequests/List11Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectRequestsV1Response](Models/ListProjectRequestsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List11Error](Errors/List11Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsUsage

> Source: [ManageV1ProjectsUsage](Api/ManageV1ProjectsUsage.cs)

<details>
<summary><code>Task&lt;UsageV1Response&gt; Get8(Get8Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsUsage.Get8(new Get8Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type UsageV1Response
}
catch (ApiException<Get8Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get8Request](Requests/ManageV1ProjectsUsage/Get8Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageV1Response](Models/UsageV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get8Error](Errors/Get8Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsUsageBreakdown

> Source: [ManageV1ProjectsUsageBreakdown](Api/ManageV1ProjectsUsageBreakdown.cs)

<details>
<summary><code>Task&lt;UsageBreakdownV1Response&gt; Get9(Get9Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsUsageBreakdown.Get9(new Get9Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type UsageBreakdownV1Response
}
catch (ApiException<Get9Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get9Request](Requests/ManageV1ProjectsUsageBreakdown/Get9Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageBreakdownV1Response](Models/UsageBreakdownV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get9Error](Errors/Get9Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageV1ProjectsUsageFields

> Source: [ManageV1ProjectsUsageFields](Api/ManageV1ProjectsUsageFields.cs)

<details>
<summary><code>Task&lt;UsageFieldsV1Response&gt; List12(List12Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ManageV1ProjectsUsageFields.List12(new List12Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type UsageFieldsV1Response
}
catch (ApiException<List12Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List12Request](Requests/ManageV1ProjectsUsageFields/List12Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UsageFieldsV1Response](Models/UsageFieldsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List12Error](Errors/List12Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ReadV1Text

> Source: [ReadV1Text](Api/ReadV1Text.cs)

<details>
<summary><code>Task&lt;ReadV1Response&gt; Analyze(AnalyzeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.ReadV1Text.Analyze(new AnalyzeRequest());
    // TODO: Handle 'response' of type ReadV1Response
}
catch (ApiException<AnalyzeError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AnalyzeRequest](Requests/ReadV1Text/AnalyzeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReadV1Response](Models/ReadV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AnalyzeError](Errors/AnalyzeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SelfHostedV1DistributionCredentials

> Source: [SelfHostedV1DistributionCredentials](Api/SelfHostedV1DistributionCredentials.cs)

<details>
<summary><code>Task&lt;CreateProjectDistributionCredentialsV1Response&gt; Create5(Create5Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SelfHostedV1DistributionCredentials.Create5(new Create5Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type CreateProjectDistributionCredentialsV1Response
}
catch (ApiException<Create5Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Create5Request](Requests/SelfHostedV1DistributionCredentials/Create5Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateProjectDistributionCredentialsV1Response](Models/CreateProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Create5Error](Errors/Create5Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectDistributionCredentialsV1Response&gt; Delete7(Delete7Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SelfHostedV1DistributionCredentials.Delete7(new Delete7Request
    {
        ProjectId = "some example string",
        DistributionCredentialsId = "some example string",
    });
    // TODO: Handle 'response' of type GetProjectDistributionCredentialsV1Response
}
catch (ApiException<Delete7Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Delete7Request](Requests/SelfHostedV1DistributionCredentials/Delete7Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectDistributionCredentialsV1Response](Models/GetProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Delete7Error](Errors/Delete7Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetProjectDistributionCredentialsV1Response&gt; Get11(Get11Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SelfHostedV1DistributionCredentials.Get11(new Get11Request
    {
        ProjectId = "some example string",
        DistributionCredentialsId = "some example string",
    });
    // TODO: Handle 'response' of type GetProjectDistributionCredentialsV1Response
}
catch (ApiException<Get11Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get11Request](Requests/SelfHostedV1DistributionCredentials/Get11Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetProjectDistributionCredentialsV1Response](Models/GetProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get11Error](Errors/Get11Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListProjectDistributionCredentialsV1Response&gt; List17(List17Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SelfHostedV1DistributionCredentials.List17(new List17Request
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type ListProjectDistributionCredentialsV1Response
}
catch (ApiException<List17Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List17Request](Requests/SelfHostedV1DistributionCredentials/List17Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListProjectDistributionCredentialsV1Response](Models/ListProjectDistributionCredentialsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List17Error](Errors/List17Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SpeakV1Audio

> Source: [SpeakV1Audio](Api/SpeakV1Audio.cs)

<details>
<summary><code>Task&lt;object&gt; Generate(GenerateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SpeakV1Audio.Generate(new GenerateRequest());
    // TODO: Handle 'response' of type object
}
catch (ApiException<GenerateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateRequest](Requests/SpeakV1Audio/GenerateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GenerateError](Errors/GenerateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SpeakV2Audio

> Source: [SpeakV2Audio](Api/SpeakV2Audio.cs)

<details>
<summary><code>Task&lt;SpeakV2AcceptedResponse&gt; Generate2(Generate2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.SpeakV2Audio.Generate2(new Generate2Request { Model = "some example string" });
    // TODO: Handle 'response' of type SpeakV2AcceptedResponse
}
catch (ApiException<Generate2Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Generate2Request](Requests/SpeakV2Audio/Generate2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SpeakV2AcceptedResponse](Models/SpeakV2AcceptedResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Generate2Error](Errors/Generate2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VoiceAgentConfigurations

> Source: [VoiceAgentConfigurations](Api/VoiceAgentConfigurations.cs)

<details>
<summary><code>Task&lt;CreateAgentConfigurationV1Response&gt; Create(CreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentConfigurations.Create(new CreateRequest
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type CreateAgentConfigurationV1Response
}
catch (ApiException<CreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateRequest](Requests/VoiceAgentConfigurations/CreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateAgentConfigurationV1Response](Models/CreateAgentConfigurationV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateError](Errors/CreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; Delete(DeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentConfigurations.Delete(new DeleteRequest
    {
        ProjectId = "some example string",
        AgentId = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<DeleteError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteRequest](Requests/VoiceAgentConfigurations/DeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteError](Errors/DeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentConfigurationV1&gt; Get(GetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentConfigurations.Get(new GetRequest
    {
        ProjectId = "some example string",
        AgentId = "some example string",
    });
    // TODO: Handle 'response' of type AgentConfigurationV1
}
catch (ApiException<GetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRequest](Requests/VoiceAgentConfigurations/GetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentConfigurationV1](Models/AgentConfigurationV1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetError](Errors/GetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListAgentConfigurationsV1Response&gt; List2(List2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentConfigurations.List2(new List2Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type ListAgentConfigurationsV1Response
}
catch (ApiException<List2Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List2Request](Requests/VoiceAgentConfigurations/List2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListAgentConfigurationsV1Response](Models/ListAgentConfigurationsV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List2Error](Errors/List2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentConfigurationV1&gt; Update(UpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentConfigurations.Update(new UpdateRequest
    {
        ProjectId = "some example string",
        AgentId = "some example string",
    });
    // TODO: Handle 'response' of type AgentConfigurationV1
}
catch (ApiException<UpdateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateRequest](Requests/VoiceAgentConfigurations/UpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentConfigurationV1](Models/AgentConfigurationV1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateError](Errors/UpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VoiceAgentVariables

> Source: [VoiceAgentVariables](Api/VoiceAgentVariables.cs)

<details>
<summary><code>Task&lt;AgentVariableV1&gt; Create2(Create2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentVariables.Create2(new Create2Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type AgentVariableV1
}
catch (ApiException<Create2Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Create2Request](Requests/VoiceAgentVariables/Create2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentVariableV1](Models/AgentVariableV1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Create2Error](Errors/Create2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; Delete2(Delete2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentVariables.Delete2(new Delete2Request
    {
        ProjectId = "some example string",
        VariableId = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<Delete2Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Delete2Request](Requests/VoiceAgentVariables/Delete2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Delete2Error](Errors/Delete2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentVariableV1&gt; Get2(Get2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentVariables.Get2(new Get2Request
    {
        ProjectId = "some example string",
        VariableId = "some example string",
    });
    // TODO: Handle 'response' of type AgentVariableV1
}
catch (ApiException<Get2Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Get2Request](Requests/VoiceAgentVariables/Get2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentVariableV1](Models/AgentVariableV1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Get2Error](Errors/Get2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListAgentVariablesV1Response&gt; List3(List3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentVariables.List3(new List3Request { ProjectId = "some example string" });
    // TODO: Handle 'response' of type ListAgentVariablesV1Response
}
catch (ApiException<List3Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[List3Request](Requests/VoiceAgentVariables/List3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListAgentVariablesV1Response](Models/ListAgentVariablesV1Response.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[List3Error](Errors/List3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AgentVariableV1&gt; Update2(Update2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

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
    var response = await client.VoiceAgentVariables.Update2(new Update2Request
    {
        ProjectId = "some example string",
        VariableId = "some example string",
    });
    // TODO: Handle 'response' of type AgentVariableV1
}
catch (ApiException<Update2Error> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[Update2Request](Requests/VoiceAgentVariables/Update2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AgentVariableV1](Models/AgentVariableV1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[Update2Error](Errors/Update2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

