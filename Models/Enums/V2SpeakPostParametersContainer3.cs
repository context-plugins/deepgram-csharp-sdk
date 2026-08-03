using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - alaw. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer3>))]
public sealed record V2SpeakPostParametersContainer3 : StringEnum<V2SpeakPostParametersContainer3>
{
    private V2SpeakPostParametersContainer3(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer3 Wav = new("wav");

    public static V2SpeakPostParametersContainer3 FromValue(string value) => FromValueCore(value);
}
