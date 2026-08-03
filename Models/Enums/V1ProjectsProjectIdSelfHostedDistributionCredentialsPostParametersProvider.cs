using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider>))]
public sealed record V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider : StringEnum<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider>
{
    private V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider Quay = new("quay");

    public static V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider FromValue(string value) =>
        FromValueCore(value);
}
