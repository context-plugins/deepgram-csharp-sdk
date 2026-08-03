using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ReadV1ResponseResultsSummaryResultsSummary
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }
}
