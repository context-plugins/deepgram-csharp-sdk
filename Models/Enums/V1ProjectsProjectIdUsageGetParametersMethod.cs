using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Method type for the request
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageGetParametersMethod>))]
public sealed record V1ProjectsProjectIdUsageGetParametersMethod : StringEnum<V1ProjectsProjectIdUsageGetParametersMethod>
{
    private V1ProjectsProjectIdUsageGetParametersMethod(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageGetParametersMethod Sync = new("sync");

    public static readonly V1ProjectsProjectIdUsageGetParametersMethod Async = new("async");

    public static readonly V1ProjectsProjectIdUsageGetParametersMethod Streaming = new("streaming");

    public static V1ProjectsProjectIdUsageGetParametersMethod FromValue(string value) => FromValueCore(value);
}
