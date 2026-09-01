using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - opus. Supported container - ogg (default).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer4>))]
public sealed record V1SpeakPostParametersContainer4 : StringEnum<V1SpeakPostParametersContainer4>
{
    private V1SpeakPostParametersContainer4(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer4 Ogg = new("ogg");

    public static V1SpeakPostParametersContainer4 FromValue(string value) => FromValueCore(value);
}
