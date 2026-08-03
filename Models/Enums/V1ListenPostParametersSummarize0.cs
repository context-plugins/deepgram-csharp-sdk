using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersSummarize0>))]
public sealed record V1ListenPostParametersSummarize0 : StringEnum<V1ListenPostParametersSummarize0>
{
    private V1ListenPostParametersSummarize0(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersSummarize0 V2 = new("v2");

    public static V1ListenPostParametersSummarize0 FromValue(string value) => FromValueCore(value);
}
