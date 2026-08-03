using System.Text.Json.Serialization;

namespace RestApi.Models;

public record GetProjectKeyV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item")]
    public GetProjectKeyV1ResponseItem? Item { get; init; }
}
