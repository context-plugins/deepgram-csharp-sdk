using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdRequestsGetParametersStatus>))]
public sealed record V1ProjectsProjectIdRequestsGetParametersStatus : StringEnum<V1ProjectsProjectIdRequestsGetParametersStatus>
{
    private V1ProjectsProjectIdRequestsGetParametersStatus(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdRequestsGetParametersStatus Succeeded = new("succeeded");

    public static readonly V1ProjectsProjectIdRequestsGetParametersStatus Failed = new("failed");

    public static V1ProjectsProjectIdRequestsGetParametersStatus FromValue(string value) =>
        FromValueCore(value);
}
