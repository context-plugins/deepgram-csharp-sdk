using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - flac. Supported sample rates - 8000, 16000, 22050, 32000, 48000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersSampleRate3>))]
public sealed record V2SpeakPostParametersSampleRate3 : OpenStringEnum<V2SpeakPostParametersSampleRate3>
{
    private V2SpeakPostParametersSampleRate3(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersSampleRate3 _8000 = new("8000");

    public static readonly V2SpeakPostParametersSampleRate3 _16000 = new("16000");

    public static readonly V2SpeakPostParametersSampleRate3 _22050 = new("22050");

    public static readonly V2SpeakPostParametersSampleRate3 _32000 = new("32000");

    public static readonly V2SpeakPostParametersSampleRate3 _48000 = new("48000");

    public TResult Match<TResult>(Func<TResult> on_8000,
        Func<TResult> on_16000,
        Func<TResult> on_22050,
        Func<TResult> on_32000,
        Func<TResult> on_48000,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _8000 => on_8000(),
            _ when this == _16000 => on_16000(),
            _ when this == _22050 => on_22050(),
            _ when this == _32000 => on_32000(),
            _ when this == _48000 => on_48000(),
            _ => otherwise(Value)
        };

    public void Match(Action on_8000,
        Action on_16000,
        Action on_22050,
        Action on_32000,
        Action on_48000,
        Action<string> otherwise)
    {
        if (this == _8000) on_8000();
        else if (this == _16000) on_16000();
        else if (this == _22050) on_22050();
        else if (this == _32000) on_32000();
        else if (this == _48000) on_48000();
        else otherwise(Value);
    }
}
