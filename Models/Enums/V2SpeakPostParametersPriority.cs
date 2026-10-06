using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersPriority>))]
public sealed record V2SpeakPostParametersPriority : OpenStringEnum<V2SpeakPostParametersPriority>
{
    private V2SpeakPostParametersPriority(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersPriority Low = new("low");

    public TResult Match<TResult>(Func<TResult> onLow, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Low => onLow(),
            _ => otherwise(Value)
        };

    public void Match(Action onLow, Action<string> otherwise)
    {
        if (this == Low) onLow();
        else otherwise(Value);
    }
}
