using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// The unique identifier of the Groq model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf3Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf3Id : StringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf3Id>
{
    private AgentThinkModelsV1ResponseModelsItemsOneOf3Id(string value) : base(value)
    {
    }

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf3Id OpenaiGptOss20B = new("openai/gpt-oss-20b");

    public static AgentThinkModelsV1ResponseModelsItemsOneOf3Id FromValue(string value) => FromValueCore(value);
}
