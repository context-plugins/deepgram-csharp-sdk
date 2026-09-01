using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersCallbackMethod>))]
public sealed record V1ListenPostParametersCallbackMethod : StringEnum<V1ListenPostParametersCallbackMethod>
{
    private V1ListenPostParametersCallbackMethod(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersCallbackMethod Post = new("POST");

    public static readonly V1ListenPostParametersCallbackMethod Put = new("PUT");

    public static V1ListenPostParametersCallbackMethod FromValue(string value) => FromValueCore(value);
}
