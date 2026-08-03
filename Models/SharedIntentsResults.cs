using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedIntentsResults
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intents")]
    public SharedIntentsResultsIntents? Intents { get; init; }
}
