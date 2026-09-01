using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record ReadV1ResponseResultsSummaryResults
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public ReadV1ResponseResultsSummaryResultsSummary? Summary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
