using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - opus. Supported container - ogg (default).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer4>))]
public sealed record V2SpeakPostParametersContainer4 : OpenStringEnum<V2SpeakPostParametersContainer4>
{
    private V2SpeakPostParametersContainer4(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer4 Ogg = new("ogg");

    public TResult Match<TResult>(Func<TResult> onOgg, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ogg => onOgg(),
            _ => otherwise(Value)
        };

    public void Match(Action onOgg, Action<string> otherwise)
    {
        if (this == Ogg) onOgg();
        else otherwise(Value);
    }
}
