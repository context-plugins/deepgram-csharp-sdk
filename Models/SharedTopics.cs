using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Output whenever <c>topics=true</c> is used
/// </summary>
public record SharedTopics
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public SharedTopicsResults? Results { get; init; }
}
