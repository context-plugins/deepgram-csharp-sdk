using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// The standard text response
/// </summary>
public record ReadV1Response
{
    [JsonPropertyName("metadata")]
    public required ReadV1ResponseMetadata Metadata { get; init; }

    [JsonPropertyName("results")]
    public required ReadV1ResponseResults Results { get; init; }
}
