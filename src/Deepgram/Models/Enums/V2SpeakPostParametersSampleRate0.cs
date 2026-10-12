using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - linear16. Supported sample rates - 8000, 16000, 24000, 32000, 44100, 48000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersSampleRate0>))]
public sealed record V2SpeakPostParametersSampleRate0 : OpenStringEnum<V2SpeakPostParametersSampleRate0>
{
    private V2SpeakPostParametersSampleRate0(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersSampleRate0 _8000 = new("8000");

    public static readonly V2SpeakPostParametersSampleRate0 _16000 = new("16000");

    public static readonly V2SpeakPostParametersSampleRate0 _24000 = new("24000");

    public static readonly V2SpeakPostParametersSampleRate0 _32000 = new("32000");

    public static readonly V2SpeakPostParametersSampleRate0 _44100 = new("44100");

    public static readonly V2SpeakPostParametersSampleRate0 _48000 = new("48000");

    public TResult Match<TResult>(Func<TResult> on_8000,
        Func<TResult> on_16000,
        Func<TResult> on_24000,
        Func<TResult> on_32000,
        Func<TResult> on_44100,
        Func<TResult> on_48000,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _8000 => on_8000(),
            _ when this == _16000 => on_16000(),
            _ when this == _24000 => on_24000(),
            _ when this == _32000 => on_32000(),
            _ when this == _44100 => on_44100(),
            _ when this == _48000 => on_48000(),
            _ => otherwise(Value)
        };

    public void Match(Action on_8000,
        Action on_16000,
        Action on_24000,
        Action on_32000,
        Action on_44100,
        Action on_48000,
        Action<string> otherwise)
    {
        if (this == _8000) on_8000();
        else if (this == _16000) on_16000();
        else if (this == _24000) on_24000();
        else if (this == _32000) on_32000();
        else if (this == _44100) on_44100();
        else if (this == _48000) on_48000();
        else otherwise(Value);
    }
}
