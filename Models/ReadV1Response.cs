using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

/// <summary>
/// The standard text response
/// </summary>
public record ReadV1Response
{
    [JsonPropertyName("metadata")]
    public required ReadV1ResponseMetadata Metadata { get; init; }

    [JsonPropertyName("results")]
    public required ReadV1ResponseResults Results { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
