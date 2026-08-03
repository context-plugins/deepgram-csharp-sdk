using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Output whenever <c>summary=true</c> is used
/// </summary>
public record ReadV1ResponseResultsSummary
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public ReadV1ResponseResultsSummaryResults? Results { get; init; }
}
