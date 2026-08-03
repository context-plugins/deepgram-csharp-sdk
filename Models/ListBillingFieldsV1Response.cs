using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using RestApi.Models.Enums;

namespace RestApi.Models;

public record ListBillingFieldsV1Response
{
    /// <summary>
    /// List of accessor UUIDs for the time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accessors")]
    public IReadOnlyList<Guid>? Accessors { get; init; }

    /// <summary>
    /// List of deployment types for the time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deployments")]
    public IReadOnlyList<ListBillingFieldsV1ResponseDeploymentsItems>? Deployments { get; init; }

    /// <summary>
    /// List of tags for the time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string>? Tags { get; init; }

    /// <summary>
    /// Map of line item names to human-readable descriptions for the time period
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_items")]
    public IReadOnlyDictionary<string, string>? LineItems { get; init; }
}
