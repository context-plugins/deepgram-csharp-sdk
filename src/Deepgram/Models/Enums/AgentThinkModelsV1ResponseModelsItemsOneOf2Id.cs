using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// The unique identifier of the Google model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf2Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf2Id : OpenStringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf2Id>
{
    private AgentThinkModelsV1ResponseModelsItemsOneOf2Id(string value) : base(value)
    {
    }

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf2Id Gemini25Flash = new("gemini-2.5-flash");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf2Id Gemini20Flash = new("gemini-2.0-flash");

    public static readonly AgentThinkModelsV1ResponseModelsItemsOneOf2Id Gemini20FlashLite = new(
        "gemini-2.0-flash-lite");

    public TResult Match<TResult>(Func<TResult> onGemini25Flash,
        Func<TResult> onGemini20Flash,
        Func<TResult> onGemini20FlashLite,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gemini25Flash => onGemini25Flash(),
            _ when this == Gemini20Flash => onGemini20Flash(),
            _ when this == Gemini20FlashLite => onGemini20FlashLite(),
            _ => otherwise(Value)
        };

    public void Match(Action onGemini25Flash,
        Action onGemini20Flash,
        Action onGemini20FlashLite,
        Action<string> otherwise)
    {
        if (this == Gemini25Flash) onGemini25Flash();
        else if (this == Gemini20Flash) onGemini20Flash();
        else if (this == Gemini20FlashLite) onGemini20FlashLite();
        else otherwise(Value);
    }
}
