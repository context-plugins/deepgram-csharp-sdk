using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ReadPostParametersSummarize0>))]
public sealed record V1ReadPostParametersSummarize0 : StringEnum<V1ReadPostParametersSummarize0>
{
    private V1ReadPostParametersSummarize0(string value) : base(value)
    {
    }

    public static readonly V1ReadPostParametersSummarize0 V2 = new("v2");

    public static V1ReadPostParametersSummarize0 FromValue(string value) => FromValueCore(value);
}
