<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsUsageFields — operations

Accessor: `client.ManageV1ProjectsUsageFields` · Source: `src/Deepgram/Api/ManageV1ProjectsUsageFields.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List12

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List12(List12Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `start` ← `Start`, `end` ← `End`
- **Returns**: `UsageFieldsV1Response`
- **Error**: `ApiException<List12Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List12Request` | `src/Deepgram/Requests/ManageV1ProjectsUsageFields/List12Request.cs` |
| `UsageFieldsV1Response` | `src/Deepgram/Models/UsageFieldsV1Response.cs` |
| `List12Error` | `src/Deepgram/Errors/List12Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

