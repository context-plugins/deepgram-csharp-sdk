using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

/// <summary>
/// Method type for the request
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageBreakdownGetParametersMethod>))]
public sealed record V1ProjectsProjectIdUsageBreakdownGetParametersMethod : StringEnum<V1ProjectsProjectIdUsageBreakdownGetParametersMethod>
{
    private V1ProjectsProjectIdUsageBreakdownGetParametersMethod(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersMethod Sync = new("sync");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersMethod Async = new("async");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersMethod Streaming = new("streaming");

    public static V1ProjectsProjectIdUsageBreakdownGetParametersMethod FromValue(string value) =>
        FromValueCore(value);
}
