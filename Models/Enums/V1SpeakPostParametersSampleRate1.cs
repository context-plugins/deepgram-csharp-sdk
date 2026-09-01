using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mulaw. Supported sample rates - 8000, 16000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate1>))]
public sealed record V1SpeakPostParametersSampleRate1 : StringEnum<V1SpeakPostParametersSampleRate1>
{
    private V1SpeakPostParametersSampleRate1(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate1 _8000 = new("8000");

    public static readonly V1SpeakPostParametersSampleRate1 _16000 = new("16000");

    public static V1SpeakPostParametersSampleRate1 FromValue(string value) => FromValueCore(value);
}
