using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// The unique identifier of the OpenAI model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf0Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf0Id : StringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf0Id>
{
    private AgentThinkModelsV1ResponseModelsItemsOneOf0Id(string value) : base(value)
    {
    }

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt5 = new("gpt-5");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt5Mini = new("gpt-5-mini");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt5Nano = new("gpt-5-nano");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt41 = new("gpt-4.1");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt41Mini = new("gpt-4.1-mini");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt41Nano = new("gpt-4.1-nano");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt4O = new("gpt-4o");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf0Id Gpt4OMini = new("gpt-4o-mini");

    public static AgentThinkModelsV1ResponseModelsItemsOneOf0Id FromValue(string value) => FromValueCore(value);
}
