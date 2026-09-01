using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record UpdateProjectMemberScopesV1Request
{
    /// <summary>
    /// A scope to update
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
