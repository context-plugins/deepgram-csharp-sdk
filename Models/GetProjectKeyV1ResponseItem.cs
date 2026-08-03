using System.Text.Json.Serialization;

namespace RestApi.Models;

public record GetProjectKeyV1ResponseItem
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("member")]
    public GetProjectKeyV1ResponseItemMember? Member { get; init; }
}
