using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Deployment type for the requests
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageBreakdownGetParametersDeployment>))]
public sealed record V1ProjectsProjectIdUsageBreakdownGetParametersDeployment : StringEnum<V1ProjectsProjectIdUsageBreakdownGetParametersDeployment>
{
    private V1ProjectsProjectIdUsageBreakdownGetParametersDeployment(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersDeployment Hosted = new("hosted");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersDeployment Beta = new("beta");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersDeployment SelfHosted = new("self-hosted");

    public static V1ProjectsProjectIdUsageBreakdownGetParametersDeployment FromValue(string value) =>
        FromValueCore(value);
}
