using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersPriority>))]
public sealed record V2SpeakPostParametersPriority : StringEnum<V2SpeakPostParametersPriority>
{
    private V2SpeakPostParametersPriority(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersPriority Low = new("low");

    public static V2SpeakPostParametersPriority FromValue(string value) => FromValueCore(value);
}
