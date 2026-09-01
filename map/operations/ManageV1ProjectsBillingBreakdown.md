<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageV1ProjectsBillingBreakdown — operations

Accessor: `client.ManageV1ProjectsBillingBreakdown` · Source: `Api/ManageV1ProjectsBillingBreakdown.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### List14

- **Signature**: `List14(string projectId, DateTimeOffset? start, DateTimeOffset? end, string? accessor, V1ProjectsProjectIdBillingBreakdownGetParametersDeployment? deployment, string? tag, string? lineItem, IReadOnlyList<V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>? grouping, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`start` … `grouping`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `start` ← `start`, `end` ← `end`, `accessor` ← `accessor`, `deployment` ← `deployment`, `tag` ← `tag`, `line_item` ← `lineItem`, `grouping` ← `grouping`
- **Returns**: `BillingBreakdownV1Response`
- **Error**: `SdkException<List14Error>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1ProjectsProjectIdBillingBreakdownGetParametersDeployment` | `Models/Enums/V1ProjectsProjectIdBillingBreakdownGetParametersDeployment.cs` |
| `V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems` | `Models/Enums/V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems.cs` |
| `BillingBreakdownV1Response` | `Models/BillingBreakdownV1Response.cs` |
| `List14Error` | `Errors/List14Error.cs` |
| `ErrorResponseModel` | `Models/AnyOf/ErrorResponseModel.cs` |

