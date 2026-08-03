using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - linear16. Supported container - wav (default), or no container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer1>))]
public sealed record V1SpeakPostParametersContainer1 : StringEnum<V1SpeakPostParametersContainer1>
{
    private V1SpeakPostParametersContainer1(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer1 Wav = new("wav");

    public static V1SpeakPostParametersContainer1 FromValue(string value) => FromValueCore(value);
}
