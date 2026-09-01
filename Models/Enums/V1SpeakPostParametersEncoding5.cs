using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - opus. High-compression audio format optimized for real-time communications.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersEncoding5>))]
public sealed record V1SpeakPostParametersEncoding5 : StringEnum<V1SpeakPostParametersEncoding5>
{
    private V1SpeakPostParametersEncoding5(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersEncoding5 Opus = new("opus");

    public static V1SpeakPostParametersEncoding5 FromValue(string value) => FromValueCore(value);
}
