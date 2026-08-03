using System.Text.Json.Serialization;

namespace RestApi.Models;

public record GetProjectRequestV1Response
{
    /// <summary>
    /// A single request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request")]
    public ProjectRequestResponse? Request { get; init; }
}
