using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ReadV1ResponseMetadata
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public ReadV1ResponseMetadataMetadata? Metadata { get; init; }
}
