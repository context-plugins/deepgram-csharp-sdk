using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - opus. High-compression audio format optimized for real-time communications.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding5>))]
public sealed record V1SpeakPostParametersEncoding5 : OpenStringEnum<V1SpeakPostParametersEncoding5>
{
    private V1SpeakPostParametersEncoding5(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding5 Opus = new("opus");

    public TResult Match<TResult>(Func<TResult> onOpus, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Opus => onOpus(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpus, Action<string> otherwise)
    {
        if (this == Opus) onOpus();
        else otherwise(Value);
    }
}
