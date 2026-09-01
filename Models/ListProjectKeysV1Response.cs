using System.Collections.Generic;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record ListProjectKeysV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_keys")]
    public IReadOnlyList<ListProjectKeysV1ResponseApiKeysItems>? ApiKeys { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
