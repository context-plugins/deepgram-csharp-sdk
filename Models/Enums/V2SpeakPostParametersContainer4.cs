using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Encoding - opus. Supported container - ogg (default).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer4>))]
public sealed record V2SpeakPostParametersContainer4 : StringEnum<V2SpeakPostParametersContainer4>
{
    private V2SpeakPostParametersContainer4(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer4 Ogg = new("ogg");

    public static V2SpeakPostParametersContainer4 FromValue(string value) => FromValueCore(value);
}
