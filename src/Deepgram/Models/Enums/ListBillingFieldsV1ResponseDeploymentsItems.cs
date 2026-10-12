using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListBillingFieldsV1ResponseDeploymentsItems>))]
public sealed record ListBillingFieldsV1ResponseDeploymentsItems : OpenStringEnum<ListBillingFieldsV1ResponseDeploymentsItems>
{
    private ListBillingFieldsV1ResponseDeploymentsItems(string value) : base(value)
    {
    }

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems Hosted = new("hosted");

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems Beta = new("beta");

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems SelfHosted = new("self-hosted");

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems Dedicated = new("dedicated");

    public TResult Match<TResult>(Func<TResult> onHosted,
        Func<TResult> onBeta,
        Func<TResult> onSelfHosted,
        Func<TResult> onDedicated,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Hosted => onHosted(),
            _ when this == Beta => onBeta(),
            _ when this == SelfHosted => onSelfHosted(),
            _ when this == Dedicated => onDedicated(),
            _ => otherwise(Value)
        };

    public void Match(Action onHosted, Action onBeta, Action onSelfHosted, Action onDedicated, Action<string> otherwise)
    {
        if (this == Hosted) onHosted();
        else if (this == Beta) onBeta();
        else if (this == SelfHosted) onSelfHosted();
        else if (this == Dedicated) onDedicated();
        else otherwise(Value);
    }
}
