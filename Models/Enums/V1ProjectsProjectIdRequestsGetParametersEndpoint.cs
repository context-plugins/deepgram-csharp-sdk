using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdRequestsGetParametersEndpoint>))]
public sealed record V1ProjectsProjectIdRequestsGetParametersEndpoint : StringEnum<V1ProjectsProjectIdRequestsGetParametersEndpoint>
{
    private V1ProjectsProjectIdRequestsGetParametersEndpoint(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Listen = new("listen");

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Read = new("read");

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Speak = new("speak");

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Agent = new("agent");

    public static V1ProjectsProjectIdRequestsGetParametersEndpoint FromValue(string value) =>
        FromValueCore(value);
}
