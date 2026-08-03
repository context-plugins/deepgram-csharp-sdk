using System.Text.Json.Serialization;

namespace RestApi.Models;

public record GetProjectDistributionCredentialsV1Response
{
    [JsonPropertyName("member")]
    public required GetProjectDistributionCredentialsV1ResponseMember Member { get; init; }

    [JsonPropertyName("distribution_credentials")]
    public required GetProjectDistributionCredentialsV1ResponseDistributionCredentials DistributionCredentials { get; init; }
}
