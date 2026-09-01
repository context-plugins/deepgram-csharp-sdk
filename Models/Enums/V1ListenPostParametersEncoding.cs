using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersEncoding>))]
public sealed record V1ListenPostParametersEncoding : StringEnum<V1ListenPostParametersEncoding>
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

    public static V1ListenPostParametersEncoding FromValue(string value) => FromValueCore(value);
}
