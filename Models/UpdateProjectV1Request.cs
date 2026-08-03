using System.Text.Json.Serialization;

namespace RestApi.Models;

public record UpdateProjectV1Request
{
    /// <summary>
    /// The name of the project
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
