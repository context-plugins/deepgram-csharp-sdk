using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Deployment type for the requests
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdBillingBreakdownGetParametersDeployment>))]
public sealed record V1ProjectsProjectIdBillingBreakdownGetParametersDeployment : StringEnum<V1ProjectsProjectIdBillingBreakdownGetParametersDeployment>
{
    private V1ProjectsProjectIdBillingBreakdownGetParametersDeployment(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersDeployment Hosted = new("hosted");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersDeployment Beta = new("beta");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersDeployment SelfHosted = new("self-hosted");

    public static V1ProjectsProjectIdBillingBreakdownGetParametersDeployment FromValue(string value) =>
        FromValueCore(value);
}
