using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider>))]
public sealed record V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider : OpenStringEnum<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider>
{
    private V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider Quay = new(
        "quay");

    public TResult Match<TResult>(Func<TResult> onQuay, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Quay => onQuay(),
            _ => otherwise(Value)
        };

    public void Match(Action onQuay, Action<string> otherwise)
    {
        if (this == Quay) onQuay();
        else otherwise(Value);
    }
}
