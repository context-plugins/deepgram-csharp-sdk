using System;
using System.Text.Json.Serialization;

namespace RestApi.Models;

/// <summary>
/// A single request
/// </summary>
public record ProjectRequestResponse
{
    /// <summary>
    /// The unique identifier of the request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    /// <summary>
    /// The unique identifier of the project
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("project_uuid")]
    public string? ProjectUuid { get; init; }

    /// <summary>
    /// The date and time the request was created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created")]
    public DateTimeOffset? Created { get; init; }

    /// <summary>
    /// The API path of the request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("path")]
    public string? Path { get; init; }

    /// <summary>
    /// The unique identifier of the API key
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_key_id")]
    public string? ApiKeyId { get; init; }

    /// <summary>
    /// The response of the request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public object? Response { get; init; }

    /// <summary>
    /// The response code of the request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public double? Code { get; init; }

    /// <summary>
    /// The deployment type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deployment")]
    public string? Deployment { get; init; }

    /// <summary>
    /// The callback URL for the request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback")]
    public string? Callback { get; init; }
}
