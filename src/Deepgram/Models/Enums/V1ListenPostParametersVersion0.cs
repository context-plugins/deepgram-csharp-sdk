using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Use the latest version of a model
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersVersion0>))]
public sealed record V1ListenPostParametersVersion0 : OpenStringEnum<V1ListenPostParametersVersion0>
{
    private V1ListenPostParametersVersion0(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersVersion0 Latest = new("latest");

    public TResult Match<TResult>(Func<TResult> onLatest, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Latest => onLatest(),
            _ => otherwise(Value)
        };

    public void Match(Action onLatest, Action<string> otherwise)
    {
        if (this == Latest) onLatest();
        else otherwise(Value);
    }
}
