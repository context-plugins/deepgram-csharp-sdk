using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - alaw. Supported sample rates - 8000, 16000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate2>))]
public sealed record V1SpeakPostParametersSampleRate2 : OpenStringEnum<V1SpeakPostParametersSampleRate2>
{
    private V1SpeakPostParametersSampleRate2(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate2 _8000 = new("8000");

    public static readonly V1SpeakPostParametersSampleRate2 _16000 = new("16000");

    public TResult Match<TResult>(Func<TResult> on_8000, Func<TResult> on_16000, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _8000 => on_8000(),
            _ when this == _16000 => on_16000(),
            _ => otherwise(Value)
        };

    public void Match(Action on_8000, Action on_16000, Action<string> otherwise)
    {
        if (this == _8000) on_8000();
        else if (this == _16000) on_16000();
        else otherwise(Value);
    }
}
