using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - alaw. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer3>))]
public sealed record V1SpeakPostParametersContainer3 : StringEnum<V1SpeakPostParametersContainer3>
{
    private V1SpeakPostParametersContainer3(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer3 Wav = new("wav");

    public static V1SpeakPostParametersContainer3 FromValue(string value) => FromValueCore(value);
}
