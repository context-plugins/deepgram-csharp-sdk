using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mulaw. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer2>))]
public sealed record V1SpeakPostParametersContainer2 : OpenStringEnum<V1SpeakPostParametersContainer2>
{
    private V1SpeakPostParametersContainer2(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer2 Wav = new("wav");

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
