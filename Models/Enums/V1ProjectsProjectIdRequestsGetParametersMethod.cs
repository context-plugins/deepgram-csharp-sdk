using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Method type for the request
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdRequestsGetParametersMethod>))]
public sealed record V1ProjectsProjectIdRequestsGetParametersMethod : OpenStringEnum<V1ProjectsProjectIdRequestsGetParametersMethod>
{
    private V1ProjectsProjectIdRequestsGetParametersMethod(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdRequestsGetParametersMethod Sync = new("sync");

    public static readonly V1ProjectsProjectIdRequestsGetParametersMethod Async = new("async");

    public static readonly V1ProjectsProjectIdRequestsGetParametersMethod Streaming = new("streaming");

    public TResult Match<TResult>(Func<TResult> onSync,
        Func<TResult> onAsync,
        Func<TResult> onStreaming,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sync => onSync(),
            _ when this == Async => onAsync(),
            _ when this == Streaming => onStreaming(),
            _ => otherwise(Value)
        };

    public void Match(Action onSync, Action onAsync, Action onStreaming, Action<string> otherwise)
    {
        if (this == Sync) onSync();
        else if (this == Async) onAsync();
        else if (this == Streaming) onStreaming();
        else otherwise(Value);
    }
}
