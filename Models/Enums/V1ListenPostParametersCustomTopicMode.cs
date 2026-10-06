using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersCustomTopicMode>))]
public sealed record V1ListenPostParametersCustomTopicMode : OpenStringEnum<V1ListenPostParametersCustomTopicMode>
{
    private V1ListenPostParametersCustomTopicMode(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersCustomTopicMode Extended = new("extended");

    public static readonly V1ListenPostParametersCustomTopicMode Strict = new("strict");

    public TResult Match<TResult>(Func<TResult> onExtended, Func<TResult> onStrict, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Extended => onExtended(),
            _ when this == Strict => onStrict(),
            _ => otherwise(Value)
        };

    public void Match(Action onExtended, Action onStrict, Action<string> otherwise)
    {
        if (this == Extended) onExtended();
        else if (this == Strict) onStrict();
        else otherwise(Value);
    }
}
