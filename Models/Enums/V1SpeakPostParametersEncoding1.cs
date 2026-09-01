using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - flac. Lossless audio format for high-quality compression.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding1>))]
public sealed record V1SpeakPostParametersEncoding1 : StringEnum<V1SpeakPostParametersEncoding1>
{
    private V1SpeakPostParametersEncoding1(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding1 Flac = new("flac");

    public static V1SpeakPostParametersEncoding1 FromValue(string value) => FromValueCore(value);
}
