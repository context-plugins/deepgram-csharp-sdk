using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - mp3(default). Supported bitrates - 32000, 48000(default) bps.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersBitRate0>))]
public sealed record V1SpeakPostParametersBitRate0 : StringEnum<V1SpeakPostParametersBitRate0>
{
    private V1SpeakPostParametersBitRate0(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersBitRate0 _32000 = new("32000");

    public static readonly V1SpeakPostParametersBitRate0 _48000 = new("48000");

    public static V1SpeakPostParametersBitRate0 FromValue(string value) => FromValueCore(value);
}
