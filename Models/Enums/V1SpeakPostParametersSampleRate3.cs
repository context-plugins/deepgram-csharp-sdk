using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - mp3. Sample rate is fixed and not configurable (22050 Hz).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersSampleRate3>))]
public sealed record V1SpeakPostParametersSampleRate3 : StringEnum<V1SpeakPostParametersSampleRate3>
{
    private V1SpeakPostParametersSampleRate3(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersSampleRate3 _22050 = new("22050");

    public static V1SpeakPostParametersSampleRate3 FromValue(string value) => FromValueCore(value);
}
