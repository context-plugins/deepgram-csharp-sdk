using System.Text.Json.Serialization;

namespace RestApi.Models;

public record DeleteProjectV1Response
{
    /// <summary>
    /// Confirmation message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
