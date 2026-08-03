using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// Request body for creating a project invite
/// </summary>
public record CreateProjectInviteV1Request
{
    /// <summary>
    /// The email address of the invitee
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The scope of the invitee
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; init; }
}
