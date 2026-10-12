using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mp3. Popular compressed audio format for music and streaming.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding4>))]
public sealed record V2SpeakPostParametersEncoding4 : OpenStringEnum<V2SpeakPostParametersEncoding4>
{
    private V2SpeakPostParametersEncoding4(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding4 Mp3 = new("mp3");

    public TResult Match<TResult>(Func<TResult> onMp3, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mp3 => onMp3(),
            _ => otherwise(Value)
        };

    public void Match(Action onMp3, Action<string> otherwise)
    {
        if (this == Mp3) onMp3();
        else otherwise(Value);
    }
}
