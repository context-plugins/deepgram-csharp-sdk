using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Output whenever <c>intents=true</c> is used
/// </summary>
public record SharedIntents
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public SharedIntentsResults? Results { get; init; }
}
