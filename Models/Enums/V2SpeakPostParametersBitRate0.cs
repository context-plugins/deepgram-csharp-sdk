using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mp3(default). Supported bitrates - 8000, 16000, 24000, 32000, 40000, 48000(default) bps.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersBitRate0>))]
public sealed record V2SpeakPostParametersBitRate0 : StringEnum<V2SpeakPostParametersBitRate0>
{
    private V2SpeakPostParametersBitRate0(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersBitRate0 _8000 = new("8000");

    public static readonly V2SpeakPostParametersBitRate0 _16000 = new("16000");

    public static readonly V2SpeakPostParametersBitRate0 _24000 = new("24000");

    public static readonly V2SpeakPostParametersBitRate0 _32000 = new("32000");

    public static readonly V2SpeakPostParametersBitRate0 _40000 = new("40000");

    public static readonly V2SpeakPostParametersBitRate0 _48000 = new("48000");

    public static V2SpeakPostParametersBitRate0 FromValue(string value) => FromValueCore(value);
}
