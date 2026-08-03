using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedTopicsResults
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topics")]
    public SharedTopicsResultsTopics? Topics { get; init; }
}
