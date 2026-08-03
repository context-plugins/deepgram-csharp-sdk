using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ReadPostParametersCallbackMethod>))]
public sealed record V1ReadPostParametersCallbackMethod : StringEnum<V1ReadPostParametersCallbackMethod>
{
    private V1ReadPostParametersCallbackMethod(string value) : base(value)
    {
    }

    public static readonly V1ReadPostParametersCallbackMethod Post = new("POST");

    public static readonly V1ReadPostParametersCallbackMethod Put = new("PUT");

    public static V1ReadPostParametersCallbackMethod FromValue(string value) => FromValueCore(value);
}
