using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>))]
public sealed record V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems : OpenStringEnum<V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>
{
    private V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems Accessor = new(
        "accessor");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems Deployment = new(
        "deployment");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems LineItem = new(
        "line_item");

    public static readonly V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems Tags = new("tags");

    public TResult Match<TResult>(Func<TResult> onAccessor,
        Func<TResult> onDeployment,
        Func<TResult> onLineItem,
        Func<TResult> onTags,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Accessor => onAccessor(),
            _ when this == Deployment => onDeployment(),
            _ when this == LineItem => onLineItem(),
            _ when this == Tags => onTags(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccessor,
        Action onDeployment,
        Action onLineItem,
        Action onTags,
        Action<string> otherwise)
    {
        if (this == Accessor) onAccessor();
        else if (this == Deployment) onDeployment();
        else if (this == LineItem) onLineItem();
        else if (this == Tags) onTags();
        else otherwise(Value);
    }
}
