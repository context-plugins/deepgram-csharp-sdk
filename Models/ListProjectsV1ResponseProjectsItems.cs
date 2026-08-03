using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectsV1ResponseProjectsItems
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("project_id")]
    public string? ProjectId { get; init; }

    /// <summary>
    /// The name of the project
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
