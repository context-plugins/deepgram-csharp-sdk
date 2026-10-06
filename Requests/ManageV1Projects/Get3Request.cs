namespace Deepgram.Requests.ManageV1Projects;

/// <summary>
/// The inputs of the Get3 operation.
/// </summary>
public sealed record Get3Request
{
    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    public required string ProjectId { get; init; }

    /// <summary>
    /// Number of results to return per page. Default 10. Range [1,1000]
    /// </summary>
    public double Limit { get; init; } = 10d;

    /// <summary>
    /// Navigate and return the results to retrieve specific portions of information of the response
    /// </summary>
    public double? Page { get; init; }
}
