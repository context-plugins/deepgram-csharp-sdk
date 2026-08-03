using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectInvitesV1ResponseInvitesItems
{
    /// <summary>
    /// The email address of the invitee
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The scope of the invitee
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scope")]
    public string? Scope { get; init; }
}
