using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListModelsV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stt")]
    public IReadOnlyList<ListModelsV1ResponseSttModels>? Stt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tts")]
    public IReadOnlyList<ListModelsV1ResponseTtsModels>? Tts { get; init; }
}
