using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListenV1ResponseResults
{
    [JsonPropertyName("channels")]
    public required IReadOnlyList<ListenV1ResponseResultsChannelsItems> Channels { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("utterances")]
    public IReadOnlyList<ListenV1ResponseResultsUtterancesItems>? Utterances { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public ListenV1ResponseResultsSummary? Summary { get; init; }

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
}
