using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - alaw. Supported sample rates - 8000, 16000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersSampleRate2>))]
public sealed record V2SpeakPostParametersSampleRate2 : StringEnum<V2SpeakPostParametersSampleRate2>
{
    private V2SpeakPostParametersSampleRate2(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersSampleRate2 _8000 = new("8000");

    public static readonly V2SpeakPostParametersSampleRate2 _16000 = new("16000");

    public static V2SpeakPostParametersSampleRate2 FromValue(string value) => FromValueCore(value);
}
