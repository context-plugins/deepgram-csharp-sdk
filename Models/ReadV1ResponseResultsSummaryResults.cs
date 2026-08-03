using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ReadV1ResponseResultsSummaryResults
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public ReadV1ResponseResultsSummaryResultsSummary? Summary { get; init; }
}
