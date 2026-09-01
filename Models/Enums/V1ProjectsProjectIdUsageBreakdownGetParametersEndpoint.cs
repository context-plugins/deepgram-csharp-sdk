using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint>))]
public sealed record V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint : StringEnum<V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint>
{
    private V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Listen = new("listen");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Read = new("read");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Speak = new("speak");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Agent = new("agent");

    public static V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint FromValue(string value) =>
        FromValueCore(value);
}
