using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectMembersV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("members")]
    public IReadOnlyList<ListProjectMembersV1ResponseMembersItems>? Members { get; init; }
}
