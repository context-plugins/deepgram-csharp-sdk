using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// The unique identifier of the Groq model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf3Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf3Id : OpenStringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf3Id>
{
    private AgentThinkModelsV1ResponseModelsItemsOneOf3Id(string value) : base(value)
    {
    }

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf3Id OpenaiGptOss20B = new("openai/gpt-oss-20b");

    public TResult Match<TResult>(Func<TResult> onOpenaiGptOss20B, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OpenaiGptOss20B => onOpenaiGptOss20B(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpenaiGptOss20B, Action<string> otherwise)
    {
        if (this == OpenaiGptOss20B) onOpenaiGptOss20B();
        else otherwise(Value);
    }
}
