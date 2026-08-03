using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding6>))]
public sealed record V1SpeakPostParametersEncoding6 : StringEnum<V1SpeakPostParametersEncoding6>
{
    private V1SpeakPostParametersEncoding6(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding6 Aac = new("aac");

    public static V1SpeakPostParametersEncoding6 FromValue(string value) => FromValueCore(value);
}
