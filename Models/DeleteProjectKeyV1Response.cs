using System.Text.Json.Serialization;

namespace RestApi.Models;

public record DeleteProjectKeyV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
