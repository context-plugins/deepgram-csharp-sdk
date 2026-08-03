using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Deployment type for the requests
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageGetParametersDeployment>))]
public sealed record V1ProjectsProjectIdUsageGetParametersDeployment : StringEnum<V1ProjectsProjectIdUsageGetParametersDeployment>
{
    private V1ProjectsProjectIdUsageGetParametersDeployment(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageGetParametersDeployment Hosted = new("hosted");

    public static readonly V1ProjectsProjectIdUsageGetParametersDeployment Beta = new("beta");

    public static readonly V1ProjectsProjectIdUsageGetParametersDeployment SelfHosted = new("self-hosted");

    public static V1ProjectsProjectIdUsageGetParametersDeployment FromValue(string value) =>
        FromValueCore(value);
}
