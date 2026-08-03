using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestApi.Models;

public record BillingBreakdownV1ResponseResultsItemsGrouping
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
    /// Optional accessor identifier, null unless grouped by accessor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accessor")]
    public string? Accessor { get; init; }

    /// <summary>
    /// Optional deployment identifier, null unless grouped by deployment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deployment")]
    public string? Deployment { get; init; }

    /// <summary>
    /// Optional line item identifier, null unless grouped by line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_item")]
    public string? LineItem { get; init; }

    /// <summary>
    /// Optional list of tags, null unless grouped by tags.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string?>? Tags { get; init; }
}
