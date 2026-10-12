using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record CreateProjectDistributionCredentialsV1Response
{
    [JsonPropertyName("member")]
    public required CreateProjectDistributionCredentialsV1ResponseMember Member { get; init; }

    [JsonPropertyName("distribution_credentials")]
    public required CreateProjectDistributionCredentialsV1ResponseDistributionCredentials DistributionCredentials { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
