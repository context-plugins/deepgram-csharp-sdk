using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Deployment type for the requests
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdBillingBreakdownGetParametersDeployment>))]
public sealed record V1ProjectsProjectIdBillingBreakdownGetParametersDeployment : OpenStringEnum<V1ProjectsProjectIdBillingBreakdownGetParametersDeployment>
{
    private V1ProjectsProjectIdBillingBreakdownGetParametersDeployment(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersDeployment Hosted = new("hosted");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersDeployment Beta = new("beta");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersDeployment SelfHosted = new("self-hosted");

    public TResult Match<TResult>(Func<TResult> onHosted,
        Func<TResult> onBeta,
        Func<TResult> onSelfHosted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Hosted => onHosted(),
            _ when this == Beta => onBeta(),
            _ when this == SelfHosted => onSelfHosted(),
            _ => otherwise(Value)
        };

    public void Match(Action onHosted, Action onBeta, Action onSelfHosted, Action<string> otherwise)
    {
        if (this == Hosted) onHosted();
        else if (this == Beta) onBeta();
        else if (this == SelfHosted) onSelfHosted();
        else otherwise(Value);
    }
}
