using System.Text.Json.Serialization;

namespace RestApi.Models;

public record GrantV1Request
{
    /// <summary>
    /// Time to live in seconds for the token. Defaults to 30 seconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ttl_seconds")]
    public double? TtlSeconds { get; init; }
}
