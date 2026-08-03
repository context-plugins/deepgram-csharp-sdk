using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// The unique identifier of the Google model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf2Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf2Id : StringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf2Id>
{
    private AgentThinkModelsV1ResponseModelsItemsOneOf2Id(string value) : base(value)
    {
    }

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf2Id Gemini25Flash = new("gemini-2.5-flash");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf2Id Gemini20Flash = new("gemini-2.0-flash");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf2Id Gemini20FlashLite = new("gemini-2.0-flash-lite");

    public static AgentThinkModelsV1ResponseModelsItemsOneOf2Id FromValue(string value) => FromValueCore(value);
}
