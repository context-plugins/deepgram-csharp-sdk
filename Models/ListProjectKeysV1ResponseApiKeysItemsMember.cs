using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectKeysV1ResponseApiKeysItemsMember
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("member_id")]
    public string? MemberId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }
}
