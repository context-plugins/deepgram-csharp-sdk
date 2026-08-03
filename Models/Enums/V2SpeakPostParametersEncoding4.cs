using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - mp3. Popular compressed audio format for music and streaming.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding4>))]
public sealed record V2SpeakPostParametersEncoding4 : StringEnum<V2SpeakPostParametersEncoding4>
{
    private V2SpeakPostParametersEncoding4(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding4 Mp3 = new("mp3");

    public static V2SpeakPostParametersEncoding4 FromValue(string value) => FromValueCore(value);
}
