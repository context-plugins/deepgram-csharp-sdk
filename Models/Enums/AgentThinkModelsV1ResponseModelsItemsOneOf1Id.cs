using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// The unique identifier of the Anthropic model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf1Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf1Id : StringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf1Id>
{
    private AgentThinkModelsV1ResponseModelsItemsOneOf1Id(string value) : base(value)
    {
    }

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf1Id Claude35HaikuLatest = new("claude-3-5-haiku-latest");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf1Id ClaudeSonnet420250514 = new("claude-sonnet-4-20250514");

    public static AgentThinkModelsV1ResponseModelsItemsOneOf1Id FromValue(string value) => FromValueCore(value);
}
