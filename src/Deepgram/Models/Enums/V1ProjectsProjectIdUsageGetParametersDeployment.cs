using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Deployment type for the requests
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageGetParametersDeployment>))]
public sealed record V1ProjectsProjectIdUsageGetParametersDeployment : OpenStringEnum<V1ProjectsProjectIdUsageGetParametersDeployment>
{
    private V1ProjectsProjectIdUsageGetParametersDeployment(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageGetParametersDeployment Hosted = new("hosted");

    public static readonly V1ProjectsProjectIdUsageGetParametersDeployment Beta = new("beta");

    public static readonly V1ProjectsProjectIdUsageGetParametersDeployment SelfHosted = new("self-hosted");

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
