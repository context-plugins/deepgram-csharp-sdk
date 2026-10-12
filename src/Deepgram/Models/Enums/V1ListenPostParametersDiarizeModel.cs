using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersDiarizeModel>))]
public sealed record V1ListenPostParametersDiarizeModel : OpenStringEnum<V1ListenPostParametersDiarizeModel>
{
    private V1ListenPostParametersDiarizeModel(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersDiarizeModel Latest = new("latest");

    public static readonly V1ListenPostParametersDiarizeModel V1 = new("v1");

    public static readonly V1ListenPostParametersDiarizeModel V2 = new("v2");

    public TResult Match<TResult>(Func<TResult> onLatest,
        Func<TResult> onV1,
        Func<TResult> onV2,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Latest => onLatest(),
            _ when this == V1 => onV1(),
            _ when this == V2 => onV2(),
            _ => otherwise(Value)
        };

    public void Match(Action onLatest, Action onV1, Action onV2, Action<string> otherwise)
    {
        if (this == Latest) onLatest();
        else if (this == V1) onV1();
        else if (this == V2) onV2();
        else otherwise(Value);
    }
}
