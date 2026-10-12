<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingBreakdown — operations

Accessor: `client.ManageV1ProjectsBillingBreakdown` · Source: `src/Deepgram/Api/ManageV1ProjectsBillingBreakdown.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List14

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `List14(List14Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `start` ← `Start`, `end` ← `End`, `accessor` ← `Accessor`, `deployment` ← `Deployment`, `tag` ← `Tag`, `line_item` ← `LineItem`, `grouping` ← `Grouping`
- **Returns**: `BillingBreakdownV1Response`
- **Error**: `ApiException<List14Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `List14Request` | `src/Deepgram/Requests/ManageV1ProjectsBillingBreakdown/List14Request.cs` |
| `V1ProjectsProjectIdBillingBreakdownGetParametersDeployment` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.cs` |
| `V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems` | `src/Deepgram/Models/Enums/V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.cs` |
| `BillingBreakdownV1Response` | `src/Deepgram/Models/BillingBreakdownV1Response.cs` |
| `List14Error` | `src/Deepgram/Errors/List14Error.cs` |
| `ErrorResponseModel` | `src/Deepgram/Models/AnyOf/ErrorResponseModel.cs` |

