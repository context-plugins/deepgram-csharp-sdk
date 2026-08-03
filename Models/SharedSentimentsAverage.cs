using System.Text.Json.Serialization;

namespace RestApi.Models;

public record SharedSentimentsAverage
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment")]
    public string? Sentiment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment_score")]
    public double? SentimentScore { get; init; }
}
