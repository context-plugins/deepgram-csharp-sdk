using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// No container.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersContainer0>))]
public sealed record V2SpeakPostParametersContainer0 : OpenStringEnum<V2SpeakPostParametersContainer0>
{
    private V2SpeakPostParametersContainer0(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersContainer0 None = new("none");

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
