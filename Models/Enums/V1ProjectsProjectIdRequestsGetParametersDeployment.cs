using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Deployment type for the requests
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdRequestsGetParametersDeployment>))]
public sealed record V1ProjectsProjectIdRequestsGetParametersDeployment : StringEnum<V1ProjectsProjectIdRequestsGetParametersDeployment>
{
    private V1ProjectsProjectIdRequestsGetParametersDeployment(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdRequestsGetParametersDeployment Hosted = new("hosted");

    public static readonly V1ProjectsProjectIdRequestsGetParametersDeployment Beta = new("beta");

    public static readonly V1ProjectsProjectIdRequestsGetParametersDeployment SelfHosted = new("self-hosted");

    public static V1ProjectsProjectIdRequestsGetParametersDeployment FromValue(string value) =>
        FromValueCore(value);
}
