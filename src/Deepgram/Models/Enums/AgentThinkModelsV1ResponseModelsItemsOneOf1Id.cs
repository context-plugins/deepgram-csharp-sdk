using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// The unique identifier of the Anthropic model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf1Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf1Id : OpenStringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf1Id>
{
    private AgentThinkModelsV1ResponseModelsItemsOneOf1Id(string value) : base(value)
    {
    }

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf1Id Claude35HaikuLatest = new(
        "claude-3-5-haiku-latest");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf1Id ClaudeSonnet420250514 = new(
        "claude-sonnet-4-20250514");

    public TResult Match<TResult>(Func<TResult> onClaude35HaikuLatest,
        Func<TResult> onClaudeSonnet420250514,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Claude35HaikuLatest => onClaude35HaikuLatest(),
            _ when this == ClaudeSonnet420250514 => onClaudeSonnet420250514(),
            _ => otherwise(Value)
        };

    public void Match(Action onClaude35HaikuLatest, Action onClaudeSonnet420250514, Action<string> otherwise)
    {
        if (this == Claude35HaikuLatest) onClaude35HaikuLatest();
        else if (this == ClaudeSonnet420250514) onClaudeSonnet420250514();
        else otherwise(Value);
    }
}
