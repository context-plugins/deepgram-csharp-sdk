using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdKeysGetParametersStatus>))]
public sealed record V1ProjectsProjectIdKeysGetParametersStatus : OpenStringEnum<V1ProjectsProjectIdKeysGetParametersStatus>
{
    private V1ProjectsProjectIdKeysGetParametersStatus(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdKeysGetParametersStatus Active = new("active");

    public static readonly V1ProjectsProjectIdKeysGetParametersStatus Expired = new("expired");

    public TResult Match<TResult>(Func<TResult> onActive, Func<TResult> onExpired, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onExpired, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}
