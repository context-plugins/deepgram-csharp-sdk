using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - linear16. Uncompressed, high-quality audio format often used for telephony or audio processing.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding0>))]
public sealed record V1SpeakPostParametersEncoding0 : StringEnum<V1SpeakPostParametersEncoding0>
{
    private V1SpeakPostParametersEncoding0(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding0 Linear16 = new("linear16");

    public static V1SpeakPostParametersEncoding0 FromValue(string value) => FromValueCore(value);
}
