using System.Text.Json.Serialization;

namespace RestApi.Models;

public record CreateProjectDistributionCredentialsV1Response
{
    [JsonPropertyName("member")]
    public required CreateProjectDistributionCredentialsV1ResponseMember Member { get; init; }

    [JsonPropertyName("distribution_credentials")]
    public required CreateProjectDistributionCredentialsV1ResponseDistributionCredentials DistributionCredentials { get; init; }
}
