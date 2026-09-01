using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record ListenV1ResponseMetadata
{
    [JsonPropertyName("transaction_key")]
    public string? TransactionKey { get; init; } = "deprecated";

    [JsonPropertyName("request_id")]
    public required Guid RequestId { get; init; }

    [JsonPropertyName("sha256")]
    public required string Sha256 { get; init; }

    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    [JsonPropertyName("channels")]
    public required int Channels { get; init; }

    [JsonPropertyName("models")]
    public required IReadOnlyList<string> Models { get; init; }

    [JsonPropertyName("model_info")]
    public required object ModelInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary_info")]
    public ListenV1ResponseMetadataSummaryInfo? SummaryInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment_info")]
    public ListenV1ResponseMetadataSentimentInfo? SentimentInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topics_info")]
    public ListenV1ResponseMetadataTopicsInfo? TopicsInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intents_info")]
    public ListenV1ResponseMetadataIntentsInfo? IntentsInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string>? Tags { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
