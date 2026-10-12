using System.Collections.Generic;
using Deepgram.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.SelfHostedV1DistributionCredentials;

/// <summary>
/// The inputs of the Create5 operation.
/// </summary>
public sealed record Create5Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// List of permission scopes for the credentials
    /// </summary>
    public IReadOnlyList<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>? Scopes { get; init; }

    /// <summary>
    /// The provider of the distribution service
    /// </summary>
    public V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider Provider { get; init; } = V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider.Quay;

    /// <summary>
    /// The set of distribution credentials to create
    /// </summary>
    public CreateProjectDistributionCredentialsV1Request? Body { get; init; }
}
