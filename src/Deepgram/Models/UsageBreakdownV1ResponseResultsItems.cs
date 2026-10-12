using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record UsageBreakdownV1ResponseResultsItems
{
    /// <summary>
    /// Audio hours processed
    /// </summary>
    [JsonPropertyName("hours")]
    public required double Hours { get; init; }

    /// <summary>
    /// Total hours including all processing
    /// </summary>
    [JsonPropertyName("total_hours")]
    public required double TotalHours { get; init; }

    /// <summary>
    /// Agent hours used
    /// </summary>
    [JsonPropertyName("agent_hours")]
    public required double AgentHours { get; init; }

    /// <summary>
    /// Number of input tokens
    /// </summary>
    [JsonPropertyName("tokens_in")]
    public required double TokensIn { get; init; }

    /// <summary>
    /// Number of output tokens
    /// </summary>
    [JsonPropertyName("tokens_out")]
    public required double TokensOut { get; init; }

    /// <summary>
    /// Number of text-to-speech characters processed
    /// </summary>
    [JsonPropertyName("tts_characters")]
    public required double TtsCharacters { get; init; }

    /// <summary>
    /// Number of requests
    /// </summary>
    [JsonPropertyName("requests")]
    public required double Requests { get; init; }

    [JsonPropertyName("grouping")]
    public required UsageBreakdownV1ResponseResultsItemsGrouping Grouping { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
