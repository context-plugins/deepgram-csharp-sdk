using System.Text.Json.Serialization;

namespace RestApi.Models;

public record GrantV1Response
{
    /// <summary>
    /// JSON Web Token (JWT)
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// Time in seconds until the JWT expires
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_in")]
    public double? ExpiresIn { get; init; }
}
