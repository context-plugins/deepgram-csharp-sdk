using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding6>))]
public sealed record V2SpeakPostParametersEncoding6 : OpenStringEnum<V2SpeakPostParametersEncoding6>
{
    private V2SpeakPostParametersEncoding6(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding6 Aac = new("aac");

    public TResult Match<TResult>(Func<TResult> onAac, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Aac => onAac(),
            _ => otherwise(Value)
        };

    public void Match(Action onAac, Action<string> otherwise)
    {
        if (this == Aac) onAac();
        else otherwise(Value);
    }
}
