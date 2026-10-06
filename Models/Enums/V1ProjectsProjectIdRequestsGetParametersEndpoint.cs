using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdRequestsGetParametersEndpoint>))]
public sealed record V1ProjectsProjectIdRequestsGetParametersEndpoint : OpenStringEnum<V1ProjectsProjectIdRequestsGetParametersEndpoint>
{
    private V1ProjectsProjectIdRequestsGetParametersEndpoint(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Listen = new("listen");

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Read = new("read");

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Speak = new("speak");

    public static readonly V1ProjectsProjectIdRequestsGetParametersEndpoint Agent = new("agent");

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
