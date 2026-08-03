using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageGetParametersEndpoint>))]
public sealed record V1ProjectsProjectIdUsageGetParametersEndpoint : StringEnum<V1ProjectsProjectIdUsageGetParametersEndpoint>
{
    private V1ProjectsProjectIdUsageGetParametersEndpoint(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageGetParametersEndpoint Listen = new("listen");

    public static readonly V1ProjectsProjectIdUsageGetParametersEndpoint Read = new("read");

    public static readonly V1ProjectsProjectIdUsageGetParametersEndpoint Speak = new("speak");

    public static readonly V1ProjectsProjectIdUsageGetParametersEndpoint Agent = new("agent");

    public static V1ProjectsProjectIdUsageGetParametersEndpoint FromValue(string value) => FromValueCore(value);
}
