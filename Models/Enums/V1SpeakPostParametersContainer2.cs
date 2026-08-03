using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - mulaw. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer2>))]
public sealed record V1SpeakPostParametersContainer2 : StringEnum<V1SpeakPostParametersContainer2>
{
    private V1SpeakPostParametersContainer2(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer2 Wav = new("wav");

    public static V1SpeakPostParametersContainer2 FromValue(string value) => FromValueCore(value);
}
