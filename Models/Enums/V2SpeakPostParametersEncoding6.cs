using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding6>))]
public sealed record V2SpeakPostParametersEncoding6 : StringEnum<V2SpeakPostParametersEncoding6>
{
    private V2SpeakPostParametersEncoding6(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding6 Aac = new("aac");

    public static V2SpeakPostParametersEncoding6 FromValue(string value) => FromValueCore(value);
}
