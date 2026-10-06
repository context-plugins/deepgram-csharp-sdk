using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersEncoding>))]
public sealed record V1ListenPostParametersEncoding : OpenStringEnum<V1ListenPostParametersEncoding>
{
    private V1ListenPostParametersEncoding(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersEncoding Linear16 = new("linear16");

    public static readonly V1ListenPostParametersEncoding Flac = new("flac");

    public static readonly V1ListenPostParametersEncoding Mulaw = new("mulaw");

    public static readonly V1ListenPostParametersEncoding AmrNb = new("amr-nb");

    public static readonly V1ListenPostParametersEncoding AmrWb = new("amr-wb");

    public static readonly V1ListenPostParametersEncoding Opus = new("opus");

    public static readonly V1ListenPostParametersEncoding Speex = new("speex");

    public static readonly V1ListenPostParametersEncoding G729 = new("g729");

    public TResult Match<TResult>(Func<TResult> onLinear16,
        Func<TResult> onFlac,
        Func<TResult> onMulaw,
        Func<TResult> onAmrNb,
        Func<TResult> onAmrWb,
        Func<TResult> onOpus,
        Func<TResult> onSpeex,
        Func<TResult> onG729,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Linear16 => onLinear16(),
            _ when this == Flac => onFlac(),
            _ when this == Mulaw => onMulaw(),
            _ when this == AmrNb => onAmrNb(),
            _ when this == AmrWb => onAmrWb(),
            _ when this == Opus => onOpus(),
            _ when this == Speex => onSpeex(),
            _ when this == G729 => onG729(),
            _ => otherwise(Value)
        };

    public void Match(Action onLinear16,
        Action onFlac,
        Action onMulaw,
        Action onAmrNb,
        Action onAmrWb,
        Action onOpus,
        Action onSpeex,
        Action onG729,
        Action<string> otherwise)
    {
        if (this == Linear16) onLinear16();
        else if (this == Flac) onFlac();
        else if (this == Mulaw) onMulaw();
        else if (this == AmrNb) onAmrNb();
        else if (this == AmrWb) onAmrWb();
        else if (this == Opus) onOpus();
        else if (this == Speex) onSpeex();
        else if (this == G729) onG729();
        else otherwise(Value);
    }
}
