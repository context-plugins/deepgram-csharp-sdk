using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectInvitesV1Response
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invites")]
    public IReadOnlyList<ListProjectInvitesV1ResponseInvitesItems>? Invites { get; init; }
}
