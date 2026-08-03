using System.Text.Json.Serialization;

namespace RestApi.Models;

public record LeaveProjectV1Response
{
    /// <summary>
    /// confirmation message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
