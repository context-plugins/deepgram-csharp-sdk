using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>))]
public sealed record V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems : StringEnum<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>
{
    private V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProducts = new("self-hosted:products");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductApi = new("self-hosted:product:api");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductEngine = new("self-hosted:product:engine");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductLicenseProxy = new("self-hosted:product:license-proxy");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductDgtools = new("self-hosted:product:dgtools");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductBilling = new("self-hosted:product:billing");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductHotpepper = new("self-hosted:product:hotpepper");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductMetricsServer = new("self-hosted:product:metrics-server");

    public static V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems FromValue(string value) =>
        FromValueCore(value);
}
