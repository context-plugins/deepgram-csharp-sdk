using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mp3. Sample rate is fixed and not configurable (22050 Hz).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate3>))]
public sealed record V1SpeakPostParametersSampleRate3 : OpenStringEnum<V1SpeakPostParametersSampleRate3>
{
    private V1SpeakPostParametersSampleRate3(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate3 _22050 = new("22050");

    public TResult Match<TResult>(Func<TResult> on_22050, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _22050 => on_22050(),
            _ => otherwise(Value)
        };

    public void Match(Action on_22050, Action<string> otherwise)
    {
        if (this == _22050) on_22050();
        else otherwise(Value);
    }
}
