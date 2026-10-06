using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>))]
public sealed record V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems : OpenStringEnum<V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>
{
    private V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProducts = new(
        "self-hosted:products");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductApi = new(
        "self-hosted:product:api");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductEngine = new(
        "self-hosted:product:engine");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductLicenseProxy = new(
        "self-hosted:product:license-proxy");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductDgtools = new(
        "self-hosted:product:dgtools");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductBilling = new(
        "self-hosted:product:billing");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductHotpepper = new(
        "self-hosted:product:hotpepper");

    public static readonly V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems SelfHostedProductMetricsServer = new(
        "self-hosted:product:metrics-server");

    public TResult Match<TResult>(Func<TResult> onSelfHostedProducts,
        Func<TResult> onSelfHostedProductApi,
        Func<TResult> onSelfHostedProductEngine,
        Func<TResult> onSelfHostedProductLicenseProxy,
        Func<TResult> onSelfHostedProductDgtools,
        Func<TResult> onSelfHostedProductBilling,
        Func<TResult> onSelfHostedProductHotpepper,
        Func<TResult> onSelfHostedProductMetricsServer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SelfHostedProducts => onSelfHostedProducts(),
            _ when this == SelfHostedProductApi => onSelfHostedProductApi(),
            _ when this == SelfHostedProductEngine => onSelfHostedProductEngine(),
            _ when this == SelfHostedProductLicenseProxy => onSelfHostedProductLicenseProxy(),
            _ when this == SelfHostedProductDgtools => onSelfHostedProductDgtools(),
            _ when this == SelfHostedProductBilling => onSelfHostedProductBilling(),
            _ when this == SelfHostedProductHotpepper => onSelfHostedProductHotpepper(),
            _ when this == SelfHostedProductMetricsServer => onSelfHostedProductMetricsServer(),
            _ => otherwise(Value)
        };

    public void Match(Action onSelfHostedProducts,
        Action onSelfHostedProductApi,
        Action onSelfHostedProductEngine,
        Action onSelfHostedProductLicenseProxy,
        Action onSelfHostedProductDgtools,
        Action onSelfHostedProductBilling,
        Action onSelfHostedProductHotpepper,
        Action onSelfHostedProductMetricsServer,
        Action<string> otherwise)
    {
        if (this == SelfHostedProducts) onSelfHostedProducts();
        else if (this == SelfHostedProductApi) onSelfHostedProductApi();
        else if (this == SelfHostedProductEngine) onSelfHostedProductEngine();
        else if (this == SelfHostedProductLicenseProxy) onSelfHostedProductLicenseProxy();
        else if (this == SelfHostedProductDgtools) onSelfHostedProductDgtools();
        else if (this == SelfHostedProductBilling) onSelfHostedProductBilling();
        else if (this == SelfHostedProductHotpepper) onSelfHostedProductHotpepper();
        else if (this == SelfHostedProductMetricsServer) onSelfHostedProductMetricsServer();
        else otherwise(Value);
    }
}
