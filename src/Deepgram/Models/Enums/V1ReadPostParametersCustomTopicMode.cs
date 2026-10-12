using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ReadPostParametersCustomTopicMode>))]
public sealed record V1ReadPostParametersCustomTopicMode : OpenStringEnum<V1ReadPostParametersCustomTopicMode>
{
    private V1ReadPostParametersCustomTopicMode(string value) : base(value)
    {
    }

    public static readonly V1ReadPostParametersCustomTopicMode Extended = new("extended");

    public static readonly V1ReadPostParametersCustomTopicMode Strict = new("strict");

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
