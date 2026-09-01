using System.Collections.Generic;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;
using Deepgram.Models.AnyOf;

namespace Deepgram.Models;

public record AgentThinkModelsV1Response
{
    [JsonPropertyName("models")]
    public required IReadOnlyList<AgentThinkModelsV1ResponseModelsItems> Models { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
