using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - opus. High-compression audio format optimized for real-time communications.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersEncoding5>))]
public sealed record V2SpeakPostParametersEncoding5 : StringEnum<V2SpeakPostParametersEncoding5>
{
    private V2SpeakPostParametersEncoding5(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersEncoding5 Opus = new("opus");

    public static V2SpeakPostParametersEncoding5 FromValue(string value) => FromValueCore(value);
}
