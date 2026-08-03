using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - flac. Supported sample rates - 8000, 16000, 22050, 32000, 48000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersSampleRate3>))]
public sealed record V2SpeakPostParametersSampleRate3 : StringEnum<V2SpeakPostParametersSampleRate3>
{
    private V2SpeakPostParametersSampleRate3(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersSampleRate3 _8000 = new("8000");

    public static readonly V2SpeakPostParametersSampleRate3 _16000 = new("16000");

    public static readonly V2SpeakPostParametersSampleRate3 _22050 = new("22050");

    public static readonly V2SpeakPostParametersSampleRate3 _32000 = new("32000");

    public static readonly V2SpeakPostParametersSampleRate3 _48000 = new("48000");

    public static V2SpeakPostParametersSampleRate3 FromValue(string value) => FromValueCore(value);
}
