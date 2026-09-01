using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - alaw. Supported sample rates - 8000, 16000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate2>))]
public sealed record V1SpeakPostParametersSampleRate2 : StringEnum<V1SpeakPostParametersSampleRate2>
{
    private V1SpeakPostParametersSampleRate2(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate2 _8000 = new("8000");

    public static readonly V1SpeakPostParametersSampleRate2 _16000 = new("16000");

    public static V1SpeakPostParametersSampleRate2 FromValue(string value) => FromValueCore(value);
}
