using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ReadPostParametersCustomIntentMode>))]
public sealed record V1ReadPostParametersCustomIntentMode : StringEnum<V1ReadPostParametersCustomIntentMode>
{
    private V1ReadPostParametersCustomIntentMode(string value) : base(value)
    {
    }

    public static readonly V1ReadPostParametersCustomIntentMode Extended = new("extended");

    public static readonly V1ReadPostParametersCustomIntentMode Strict = new("strict");

    public static V1ReadPostParametersCustomIntentMode FromValue(string value) => FromValueCore(value);
}
