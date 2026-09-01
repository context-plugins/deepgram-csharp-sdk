using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Method type for the request
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdRequestsGetParametersMethod>))]
public sealed record V1ProjectsProjectIdRequestsGetParametersMethod : StringEnum<V1ProjectsProjectIdRequestsGetParametersMethod>
{
    private V1ProjectsProjectIdRequestsGetParametersMethod(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdRequestsGetParametersMethod Sync = new("sync");

    public static readonly V1ProjectsProjectIdRequestsGetParametersMethod Async = new("async");

    public static readonly V1ProjectsProjectIdRequestsGetParametersMethod Streaming = new("streaming");

    public static V1ProjectsProjectIdRequestsGetParametersMethod FromValue(string value) =>
        FromValueCore(value);
}
