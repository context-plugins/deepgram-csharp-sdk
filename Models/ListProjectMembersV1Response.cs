using System.Collections.Generic;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record ListProjectMembersV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("members")]
    public IReadOnlyList<ListProjectMembersV1ResponseMembersItems>? Members { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
