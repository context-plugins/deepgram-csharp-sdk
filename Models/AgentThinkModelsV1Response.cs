using System.Collections.Generic;
using System.Text.Json.Serialization;
using RestApi.Models.AnyOf;

namespace RestApi.Models;

public record AgentThinkModelsV1Response
{
    [JsonPropertyName("models")]
    public required IReadOnlyList<AgentThinkModelsV1ResponseModelsItems> Models { get; init; }
}
