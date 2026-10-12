using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ReadPostParametersCallbackMethod>))]
public sealed record V1ReadPostParametersCallbackMethod : OpenStringEnum<V1ReadPostParametersCallbackMethod>
{
    private V1ReadPostParametersCallbackMethod(string value) : base(value)
    {
    }

    public static readonly V1ReadPostParametersCallbackMethod Post = new("POST");

    public static readonly V1ReadPostParametersCallbackMethod Put = new("PUT");

    public TResult Match<TResult>(Func<TResult> onPost, Func<TResult> onPut, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Post => onPost(),
            _ when this == Put => onPut(),
            _ => otherwise(Value)
        };

    public void Match(Action onPost, Action onPut, Action<string> otherwise)
    {
        if (this == Post) onPost();
        else if (this == Put) onPut();
        else otherwise(Value);
    }
}
