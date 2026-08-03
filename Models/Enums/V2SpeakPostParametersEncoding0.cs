using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - linear16. Uncompressed, high-quality audio format often used for telephony or audio processing.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding0>))]
public sealed record V2SpeakPostParametersEncoding0 : StringEnum<V2SpeakPostParametersEncoding0>
{
    private V2SpeakPostParametersEncoding0(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding0 Linear16 = new("linear16");

    public static V2SpeakPostParametersEncoding0 FromValue(string value) => FromValueCore(value);
}
