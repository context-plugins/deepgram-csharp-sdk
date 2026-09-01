using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - linear16. Supported sample rates - 8000, 16000, 24000, 32000, 44100, 48000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersSampleRate0>))]
public sealed record V2SpeakPostParametersSampleRate0 : StringEnum<V2SpeakPostParametersSampleRate0>
{
    private V2SpeakPostParametersSampleRate0(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersSampleRate0 _8000 = new("8000");

    public static readonly V2SpeakPostParametersSampleRate0 _16000 = new("16000");

    public static readonly V2SpeakPostParametersSampleRate0 _24000 = new("24000");

    public static readonly V2SpeakPostParametersSampleRate0 _32000 = new("32000");

    public static readonly V2SpeakPostParametersSampleRate0 _44100 = new("44100");

    public static readonly V2SpeakPostParametersSampleRate0 _48000 = new("48000");

    public static V2SpeakPostParametersSampleRate0 FromValue(string value) => FromValueCore(value);
}
