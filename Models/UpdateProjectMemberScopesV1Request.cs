using System.Text.Json.Serialization;

namespace RestApi.Models;

public record UpdateProjectMemberScopesV1Request
{
    /// <summary>
    /// A scope to update
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; init; }
}
