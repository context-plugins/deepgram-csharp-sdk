using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// The standard transcription response
/// </summary>
public record ListenV1Response
{
    [JsonPropertyName("metadata")]
    public required ListenV1ResponseMetadata Metadata { get; init; }

    [JsonPropertyName("results")]
    public required ListenV1ResponseResults Results { get; init; }
}
