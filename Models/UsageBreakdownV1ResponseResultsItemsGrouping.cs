using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record UsageBreakdownV1ResponseResultsItemsGrouping
{
    /// <summary>
    /// Start date for this group
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public DateTimeOffset? Start { get; init; }

    /// <summary>
    /// End date for this group
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end")]
    public DateTimeOffset? End { get; init; }

    /// <summary>
    /// Optional accessor identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accessor")]
    public string? Accessor { get; init; }

    /// <summary>
    /// Optional endpoint identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; init; }

    /// <summary>
    /// Optional feature set identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feature_set")]
    public string? FeatureSet { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("models")]
    public IReadOnlyList<string>? Models { get; init; }

    /// <summary>
    /// Optional method identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public string? Method { get; init; }

    /// <summary>
    /// Optional list of tags, null unless grouped by tags.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string?>? Tags { get; init; }

    /// <summary>
    /// Optional deployment identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deployment")]
    public string? Deployment { get; init; }
}
