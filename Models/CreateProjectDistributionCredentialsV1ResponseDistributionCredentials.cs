using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record CreateProjectDistributionCredentialsV1ResponseDistributionCredentials
{
    /// <summary>
    /// Unique identifier for the distribution credentials
    /// </summary>
    [JsonPropertyName("distribution_credentials_id")]
    public required Guid DistributionCredentialsId { get; init; }

    /// <summary>
    /// The provider of the distribution service
    /// </summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; init; }

    /// <summary>
    /// Optional comment about the credentials
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comment")]
    public string? Comment { get; init; }

    /// <summary>
    /// List of permission scopes for the credentials
    /// </summary>
    [JsonPropertyName("scopes")]
    public required IReadOnlyList<string> Scopes { get; init; }

    /// <summary>
    /// Timestamp when the credentials were created
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }
}
