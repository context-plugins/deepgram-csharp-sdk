using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectBalancesV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balances")]
    public IReadOnlyList<ListProjectBalancesV1ResponseBalancesItems>? Balances { get; init; }
}
