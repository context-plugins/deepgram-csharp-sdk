using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Encoding - linear16. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer1>))]
public sealed record V2SpeakPostParametersContainer1 : StringEnum<V2SpeakPostParametersContainer1>
{
    private V2SpeakPostParametersContainer1(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer1 Wav = new("wav");

    public static V2SpeakPostParametersContainer1 FromValue(string value) => FromValueCore(value);
}
