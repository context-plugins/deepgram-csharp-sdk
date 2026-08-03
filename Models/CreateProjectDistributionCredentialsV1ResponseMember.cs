using System;
using System.Text.Json.Serialization;
using RestApi.Core.Validation;
using RestApi.Core.Validation.Attributes;

namespace RestApi.Models;

public record CreateProjectDistributionCredentialsV1ResponseMember
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
}
