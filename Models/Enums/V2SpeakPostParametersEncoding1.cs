using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - flac. Lossless audio format for high-quality compression.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding1>))]
public sealed record V2SpeakPostParametersEncoding1 : StringEnum<V2SpeakPostParametersEncoding1>
{
    private V2SpeakPostParametersEncoding1(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding1 Flac = new("flac");

    public static V2SpeakPostParametersEncoding1 FromValue(string value) => FromValueCore(value);
}
