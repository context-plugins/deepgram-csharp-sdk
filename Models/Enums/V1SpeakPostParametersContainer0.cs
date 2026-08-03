using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// No container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer0>))]
public sealed record V1SpeakPostParametersContainer0 : StringEnum<V1SpeakPostParametersContainer0>
{
    private V1SpeakPostParametersContainer0(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer0 None = new("none");

    public static V1SpeakPostParametersContainer0 FromValue(string value) => FromValueCore(value);
}
