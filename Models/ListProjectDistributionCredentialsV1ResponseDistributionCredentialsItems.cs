using System.Text.Json.Serialization;

namespace RestApi.Models;

public record ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems
{
    [JsonPropertyName("member")]
    public required ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember Member { get; init; }

    [JsonPropertyName("distribution_credentials")]
    public required ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsDistributionCredentials DistributionCredentials { get; init; }
}
