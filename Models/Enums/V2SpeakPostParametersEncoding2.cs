using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mulaw. Compressed audio format commonly used in telephony.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding2>))]
public sealed record V2SpeakPostParametersEncoding2 : StringEnum<V2SpeakPostParametersEncoding2>
{
    private V2SpeakPostParametersEncoding2(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding2 Mulaw = new("mulaw");

    public static V2SpeakPostParametersEncoding2 FromValue(string value) => FromValueCore(value);
}
