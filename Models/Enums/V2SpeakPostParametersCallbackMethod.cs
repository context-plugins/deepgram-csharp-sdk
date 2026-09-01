using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V2SpeakPostParametersCallbackMethod>))]
public sealed record V2SpeakPostParametersCallbackMethod : StringEnum<V2SpeakPostParametersCallbackMethod>
{
    private V2SpeakPostParametersCallbackMethod(string value) : base(value)
    {
    }

    public static readonly V2SpeakPostParametersCallbackMethod Post = new("POST");

    public static readonly V2SpeakPostParametersCallbackMethod Put = new("PUT");

    public static V2SpeakPostParametersCallbackMethod FromValue(string value) => FromValueCore(value);
}
