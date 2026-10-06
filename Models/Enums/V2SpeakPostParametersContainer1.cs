using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - linear16. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer1>))]
public sealed record V2SpeakPostParametersContainer1 : OpenStringEnum<V2SpeakPostParametersContainer1>
{
    private V2SpeakPostParametersContainer1(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer1 Wav = new("wav");

    public TResult Match<TResult>(Func<TResult> onWav, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Wav => onWav(),
            _ => otherwise(Value)
        };

    public void Match(Action onWav, Action<string> otherwise)
    {
        if (this == Wav) onWav();
        else otherwise(Value);
    }
}
