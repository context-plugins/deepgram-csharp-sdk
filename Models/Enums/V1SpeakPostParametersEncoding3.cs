using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - alaw. Similar to mulaw but used in international telephony.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding3>))]
public sealed record V1SpeakPostParametersEncoding3 : StringEnum<V1SpeakPostParametersEncoding3>
{
    private V1SpeakPostParametersEncoding3(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding3 Alaw = new("alaw");

    public static V1SpeakPostParametersEncoding3 FromValue(string value) => FromValueCore(value);
}
