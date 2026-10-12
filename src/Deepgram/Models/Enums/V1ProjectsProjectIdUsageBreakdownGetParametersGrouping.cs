using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageBreakdownGetParametersGrouping>))]
public sealed record V1ProjectsProjectIdUsageBreakdownGetParametersGrouping : OpenStringEnum<V1ProjectsProjectIdUsageBreakdownGetParametersGrouping>
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

    public TResult Match<TResult>(Func<TResult> onAccessor,
        Func<TResult> onEndpoint,
        Func<TResult> onFeatureSet,
        Func<TResult> onModels,
        Func<TResult> onMethod,
        Func<TResult> onTags,
        Func<TResult> onDeployment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Accessor => onAccessor(),
            _ when this == Endpoint => onEndpoint(),
            _ when this == FeatureSet => onFeatureSet(),
            _ when this == Models => onModels(),
            _ when this == Method => onMethod(),
            _ when this == Tags => onTags(),
            _ when this == Deployment => onDeployment(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccessor,
        Action onEndpoint,
        Action onFeatureSet,
        Action onModels,
        Action onMethod,
        Action onTags,
        Action onDeployment,
        Action<string> otherwise)
    {
        if (this == Accessor) onAccessor();
        else if (this == Endpoint) onEndpoint();
        else if (this == FeatureSet) onFeatureSet();
        else if (this == Models) onModels();
        else if (this == Method) onMethod();
        else if (this == Tags) onTags();
        else if (this == Deployment) onDeployment();
        else otherwise(Value);
    }
}
