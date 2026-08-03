using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectPurchasesV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orders")]
    public IReadOnlyList<ListProjectPurchasesV1ResponseOrdersItems>? Orders { get; init; }
}
