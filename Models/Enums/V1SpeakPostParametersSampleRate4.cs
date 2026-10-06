using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - opus. Sample rate is fixed at 48000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate4>))]
public sealed record V1SpeakPostParametersSampleRate4 : OpenStringEnum<V1SpeakPostParametersSampleRate4>
{
    private V1SpeakPostParametersSampleRate4(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate4 _48000 = new("48000");

    public TResult Match<TResult>(Func<TResult> on_48000, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _48000 => on_48000(),
            _ => otherwise(Value)
        };

    public void Match(Action on_48000, Action<string> otherwise)
    {
        if (this == _48000) on_48000();
        else otherwise(Value);
    }
}
