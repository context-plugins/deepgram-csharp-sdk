using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Use the latest version of a model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersVersion0>))]
public sealed record V1ListenPostParametersVersion0 : StringEnum<V1ListenPostParametersVersion0>
{
    private V1ListenPostParametersVersion0(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersVersion0 Latest = new("latest");

    public static V1ListenPostParametersVersion0 FromValue(string value) => FromValueCore(value);
}
