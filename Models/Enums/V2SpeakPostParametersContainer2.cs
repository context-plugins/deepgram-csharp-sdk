using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - mulaw. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer2>))]
public sealed record V2SpeakPostParametersContainer2 : StringEnum<V2SpeakPostParametersContainer2>
{
    private V2SpeakPostParametersContainer2(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer2 Wav = new("wav");

    public static V2SpeakPostParametersContainer2 FromValue(string value) => FromValueCore(value);
}
