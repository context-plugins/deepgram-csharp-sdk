using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - linear16. Uncompressed, high-quality audio format often used for telephony or audio processing.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding0>))]
public sealed record V2SpeakPostParametersEncoding0 : OpenStringEnum<V2SpeakPostParametersEncoding0>
{
    private V2SpeakPostParametersEncoding0(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding0 Linear16 = new("linear16");

    public TResult Match<TResult>(Func<TResult> onLinear16, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Linear16 => onLinear16(),
            _ => otherwise(Value)
        };

    public void Match(Action onLinear16, Action<string> otherwise)
    {
        if (this == Linear16) onLinear16();
        else otherwise(Value);
    }
}
