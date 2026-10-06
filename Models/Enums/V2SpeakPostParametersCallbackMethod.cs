using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersCallbackMethod>))]
public sealed record V2SpeakPostParametersCallbackMethod : OpenStringEnum<V2SpeakPostParametersCallbackMethod>
{
    private V2SpeakPostParametersCallbackMethod(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersCallbackMethod Post = new("POST");

    public static readonly V2SpeakPostParametersCallbackMethod Put = new("PUT");

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
