using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mp3(default). Supported bitrates - 32000, 48000(default) bps.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersBitRate0>))]
public sealed record V1SpeakPostParametersBitRate0 : OpenStringEnum<V1SpeakPostParametersBitRate0>
{
    private V1SpeakPostParametersBitRate0(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersBitRate0 _32000 = new("32000");

    public static readonly V1SpeakPostParametersBitRate0 _48000 = new("48000");

    public TResult Match<TResult>(Func<TResult> on_32000, Func<TResult> on_48000, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _32000 => on_32000(),
            _ when this == _48000 => on_48000(),
            _ => otherwise(Value)
        };

    public void Match(Action on_32000, Action on_48000, Action<string> otherwise)
    {
        if (this == _32000) on_32000();
        else if (this == _48000) on_48000();
        else otherwise(Value);
    }
}
