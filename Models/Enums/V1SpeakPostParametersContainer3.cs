using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - alaw. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer3>))]
public sealed record V1SpeakPostParametersContainer3 : OpenStringEnum<V1SpeakPostParametersContainer3>
{
    private V1SpeakPostParametersContainer3(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer3 Wav = new("wav");

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
