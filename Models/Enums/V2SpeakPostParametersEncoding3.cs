using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - alaw. Similar to mulaw but used in international telephony.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding3>))]
public sealed record V2SpeakPostParametersEncoding3 : StringEnum<V2SpeakPostParametersEncoding3>
{
    private V2SpeakPostParametersEncoding3(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding3 Alaw = new("alaw");

    public static V2SpeakPostParametersEncoding3 FromValue(string value) => FromValueCore(value);
}
