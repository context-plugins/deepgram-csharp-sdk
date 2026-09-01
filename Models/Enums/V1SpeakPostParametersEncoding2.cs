using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mulaw. Compressed audio format commonly used in telephony.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding2>))]
public sealed record V1SpeakPostParametersEncoding2 : StringEnum<V1SpeakPostParametersEncoding2>
{
    private V1SpeakPostParametersEncoding2(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding2 Mulaw = new("mulaw");

    public static V1SpeakPostParametersEncoding2 FromValue(string value) => FromValueCore(value);
}
