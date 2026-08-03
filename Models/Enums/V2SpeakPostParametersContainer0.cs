using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// No container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer0>))]
public sealed record V2SpeakPostParametersContainer0 : StringEnum<V2SpeakPostParametersContainer0>
{
    private V2SpeakPostParametersContainer0(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer0 None = new("none");

    public static V2SpeakPostParametersContainer0 FromValue(string value) => FromValueCore(value);
}
