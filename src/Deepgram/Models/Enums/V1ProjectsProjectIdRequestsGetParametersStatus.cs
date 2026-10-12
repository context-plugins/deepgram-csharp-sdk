using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdRequestsGetParametersStatus>))]
public sealed record V1ProjectsProjectIdRequestsGetParametersStatus : OpenStringEnum<V1ProjectsProjectIdRequestsGetParametersStatus>
{
    private V1ProjectsProjectIdRequestsGetParametersStatus(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdRequestsGetParametersStatus Succeeded = new("succeeded");

    public static readonly V1ProjectsProjectIdRequestsGetParametersStatus Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onSucceeded, Func<TResult> onFailed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Succeeded => onSucceeded(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onSucceeded, Action onFailed, Action<string> otherwise)
    {
        if (this == Succeeded) onSucceeded();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
