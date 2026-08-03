using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ReadPostParametersCustomTopicMode>))]
public sealed record V1ReadPostParametersCustomTopicMode : StringEnum<V1ReadPostParametersCustomTopicMode>
{
    private V1ReadPostParametersCustomTopicMode(string value) : base(value)
    {
    }

    public static readonly V1ReadPostParametersCustomTopicMode Extended = new("extended");

    public static readonly V1ReadPostParametersCustomTopicMode Strict = new("strict");

    public static V1ReadPostParametersCustomTopicMode FromValue(string value) => FromValueCore(value);
}
