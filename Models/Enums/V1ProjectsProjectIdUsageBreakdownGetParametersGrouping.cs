using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageBreakdownGetParametersGrouping>))]
public sealed record V1ProjectsProjectIdUsageBreakdownGetParametersGrouping : StringEnum<V1ProjectsProjectIdUsageBreakdownGetParametersGrouping>
{
    private V1ProjectsProjectIdUsageBreakdownGetParametersGrouping(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersGrouping Accessor = new("accessor");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersGrouping Endpoint = new("endpoint");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersGrouping FeatureSet = new("feature_set");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersGrouping Models = new("models");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersGrouping Method = new("method");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersGrouping Tags = new("tags");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersGrouping Deployment = new("deployment");

    public static V1ProjectsProjectIdUsageBreakdownGetParametersGrouping FromValue(string value) =>
        FromValueCore(value);
}
