using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
