using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;
using Deepgram.Core.Validation;
using Deepgram.Core.Validation.Attributes;

namespace Deepgram.Models;

public record GetProjectDistributionCredentialsV1ResponseMember
{
    /// <summary>
    /// Unique identifier for the member
    /// </summary>
    [JsonPropertyName("member_id")]
    public required Guid MemberId { get; init; }

    /// <summary>
    /// Email address of the member
    /// </summary>
    [JsonPropertyName("email")]
    [Format(FormatKind.Email)]
    public required string Email { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
