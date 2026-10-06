using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersSummarize0>))]
public sealed record V1ListenPostParametersSummarize0 : OpenStringEnum<V1ListenPostParametersSummarize0>
{
    private V1ListenPostParametersSummarize0(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersSummarize0 V2 = new("v2");

    public TResult Match<TResult>(Func<TResult> onV2, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == V2 => onV2(),
            _ => otherwise(Value)
        };

    public void Match(Action onV2, Action<string> otherwise)
    {
        if (this == V2) onV2();
        else otherwise(Value);
    }
}
