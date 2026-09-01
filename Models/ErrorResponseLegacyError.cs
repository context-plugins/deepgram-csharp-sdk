using System.Text.Json.Serialization;
using Deepgram.Core.Models;

namespace Deepgram.Models;

public record ErrorResponseLegacyError
{
    /// <summary>
    /// The error code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("err_code")]
    public string? ErrCode { get; init; }

    /// <summary>
    /// The error message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("err_msg")]
    public string? ErrMsg { get; init; }

    /// <summary>
    /// The request ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
