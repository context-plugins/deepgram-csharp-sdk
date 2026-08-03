using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectDistributionCredentialsV1Response
{
    /// <summary>
    /// Array of distribution credentials with associated member information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distribution_credentials")]
    public IReadOnlyList<ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems>? DistributionCredentials { get; init; }
}
