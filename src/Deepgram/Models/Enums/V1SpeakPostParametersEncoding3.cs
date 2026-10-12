using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - alaw. Similar to mulaw but used in international telephony.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding3>))]
public sealed record V1SpeakPostParametersEncoding3 : OpenStringEnum<V1SpeakPostParametersEncoding3>
{
    private V1SpeakPostParametersEncoding3(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding3 Alaw = new("alaw");

    public TResult Match<TResult>(Func<TResult> onAlaw, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Alaw => onAlaw(),
            _ => otherwise(Value)
        };

    public void Match(Action onAlaw, Action<string> otherwise)
    {
        if (this == Alaw) onAlaw();
        else otherwise(Value);
    }
}
