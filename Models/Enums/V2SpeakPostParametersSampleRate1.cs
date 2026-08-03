using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - mulaw. Supported sample rates - 8000, 16000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersSampleRate1>))]
public sealed record V2SpeakPostParametersSampleRate1 : StringEnum<V2SpeakPostParametersSampleRate1>
{
    private V2SpeakPostParametersSampleRate1(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersSampleRate1 _8000 = new("8000");

    public static readonly V2SpeakPostParametersSampleRate1 _16000 = new("16000");

    public static V2SpeakPostParametersSampleRate1 FromValue(string value) => FromValueCore(value);
}
