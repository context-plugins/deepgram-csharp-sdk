using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>))]
public sealed record V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems : StringEnum<V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>
{
    private V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems Accessor = new("accessor");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems Deployment = new("deployment");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems LineItem = new("line_item");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems Tags = new("tags");

    public static V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems FromValue(string value) =>
        FromValueCore(value);
}
