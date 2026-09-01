using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

/// <summary>
/// Request body for creating distribution credentials
/// </summary>
public record CreateProjectDistributionCredentialsV1Request
{
    /// <summary>
    /// Optional comment about the credentials
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comment")]
    public string? Comment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
