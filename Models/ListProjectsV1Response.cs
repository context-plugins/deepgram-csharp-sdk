using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectsV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("projects")]
    public IReadOnlyList<ListProjectsV1ResponseProjectsItems>? Projects { get; init; }
}
