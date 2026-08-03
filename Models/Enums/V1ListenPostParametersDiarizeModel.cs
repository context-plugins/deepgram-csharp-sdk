using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersDiarizeModel>))]
public sealed record V1ListenPostParametersDiarizeModel : StringEnum<V1ListenPostParametersDiarizeModel>
{
    private V1ListenPostParametersDiarizeModel(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersDiarizeModel Latest = new("latest");

    public static readonly V1ListenPostParametersDiarizeModel V1 = new("v1");

    public static readonly V1ListenPostParametersDiarizeModel V2 = new("v2");

    public static V1ListenPostParametersDiarizeModel FromValue(string value) => FromValueCore(value);
}
