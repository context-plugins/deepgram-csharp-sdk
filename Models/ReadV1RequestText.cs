using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ReadV1RequestText
{
    /// <summary>
    /// The plain text to analyze
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }
}
