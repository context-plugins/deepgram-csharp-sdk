using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// The unique identifier of the OpenAI model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgentThinkModelsV1ResponseModelsItemsOneOf0Id>))]
public sealed record AgentThinkModelsV1ResponseModelsItemsOneOf0Id : OpenStringEnum<AgentThinkModelsV1ResponseModelsItemsOneOf0Id>
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

    public TResult Match<TResult>(Func<TResult> onGpt5,
        Func<TResult> onGpt5Mini,
        Func<TResult> onGpt5Nano,
        Func<TResult> onGpt41,
        Func<TResult> onGpt41Mini,
        Func<TResult> onGpt41Nano,
        Func<TResult> onGpt4O,
        Func<TResult> onGpt4OMini,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gpt5 => onGpt5(),
            _ when this == Gpt5Mini => onGpt5Mini(),
            _ when this == Gpt5Nano => onGpt5Nano(),
            _ when this == Gpt41 => onGpt41(),
            _ when this == Gpt41Mini => onGpt41Mini(),
            _ when this == Gpt41Nano => onGpt41Nano(),
            _ when this == Gpt4O => onGpt4O(),
            _ when this == Gpt4OMini => onGpt4OMini(),
            _ => otherwise(Value)
        };

    public void Match(Action onGpt5,
        Action onGpt5Mini,
        Action onGpt5Nano,
        Action onGpt41,
        Action onGpt41Mini,
        Action onGpt41Nano,
        Action onGpt4O,
        Action onGpt4OMini,
        Action<string> otherwise)
    {
        if (this == Gpt5) onGpt5();
        else if (this == Gpt5Mini) onGpt5Mini();
        else if (this == Gpt5Nano) onGpt5Nano();
        else if (this == Gpt41) onGpt41();
        else if (this == Gpt41Mini) onGpt41Mini();
        else if (this == Gpt41Nano) onGpt41Nano();
        else if (this == Gpt4O) onGpt4O();
        else if (this == Gpt4OMini) onGpt4OMini();
        else otherwise(Value);
    }
}
