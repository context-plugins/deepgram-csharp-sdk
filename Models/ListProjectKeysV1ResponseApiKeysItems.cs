using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectKeysV1ResponseApiKeysItems
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("member")]
    public ListProjectKeysV1ResponseApiKeysItemsMember? Member { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_key")]
    public ListProjectKeysV1ResponseApiKeysItemsApiKey? ApiKey { get; init; }
}
