using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - opus. Sample rate is fixed at 48000 Hz.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate4>))]
public sealed record V1SpeakPostParametersSampleRate4 : StringEnum<V1SpeakPostParametersSampleRate4>
{
    private V1SpeakPostParametersSampleRate4(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate4 _48000 = new("48000");

    public static V1SpeakPostParametersSampleRate4 FromValue(string value) => FromValueCore(value);
}
