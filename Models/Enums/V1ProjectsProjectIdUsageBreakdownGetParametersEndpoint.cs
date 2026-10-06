using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint>))]
public sealed record V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint : OpenStringEnum<V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint>
{
    private V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Listen = new("listen");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Read = new("read");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Speak = new("speak");

    public static readonly V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint Agent = new("agent");

    public TResult Match<TResult>(Func<TResult> onListen,
        Func<TResult> onRead,
        Func<TResult> onSpeak,
        Func<TResult> onAgent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Listen => onListen(),
            _ when this == Read => onRead(),
            _ when this == Speak => onSpeak(),
            _ when this == Agent => onAgent(),
            _ => otherwise(Value)
        };

    public void Match(Action onListen, Action onRead, Action onSpeak, Action onAgent, Action<string> otherwise)
    {
        if (this == Listen) onListen();
        else if (this == Read) onRead();
        else if (this == Speak) onSpeak();
        else if (this == Agent) onAgent();
        else otherwise(Value);
    }
}
