using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record ReadV1ResponseResults
{
    /// <summary>
    /// Output whenever <c>summary=true</c> is used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public ReadV1ResponseResultsSummary? Summary { get; init; }

    /// <summary>
    /// Output whenever <c>topics=true</c> is used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topics")]
    public SharedTopics? Topics { get; init; }

    /// <summary>
    /// Output whenever <c>intents=true</c> is used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intents")]
    public SharedIntents? Intents { get; init; }

    /// <summary>
    /// Output whenever <c>sentiment=true</c> is used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiments")]
    public SharedSentiments? Sentiments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
