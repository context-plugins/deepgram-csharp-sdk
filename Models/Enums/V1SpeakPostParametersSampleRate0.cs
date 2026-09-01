using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - linear16. Supported sample rates - 8000, 16000, 24000, 32000, 48000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate0>))]
public sealed record V1SpeakPostParametersSampleRate0 : StringEnum<V1SpeakPostParametersSampleRate0>
{
    private V1SpeakPostParametersSampleRate0(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate0 _8000 = new("8000");

    public static readonly V1SpeakPostParametersSampleRate0 _16000 = new("16000");

    public static readonly V1SpeakPostParametersSampleRate0 _24000 = new("24000");

    public static readonly V1SpeakPostParametersSampleRate0 _32000 = new("32000");

    public static readonly V1SpeakPostParametersSampleRate0 _48000 = new("48000");

    public static V1SpeakPostParametersSampleRate0 FromValue(string value) => FromValueCore(value);
}
