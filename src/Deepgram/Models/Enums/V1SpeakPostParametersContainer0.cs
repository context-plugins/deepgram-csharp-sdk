using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// No container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersContainer0>))]
public sealed record V1SpeakPostParametersContainer0 : OpenStringEnum<V1SpeakPostParametersContainer0>
{
    private V1SpeakPostParametersContainer0(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersContainer0 None = new("none");

    public TResult Match<TResult>(Func<TResult> onNone, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == None => onNone(),
            _ => otherwise(Value)
        };

    public void Match(Action onNone, Action<string> otherwise)
    {
        if (this == None) onNone();
        else otherwise(Value);
    }
}
