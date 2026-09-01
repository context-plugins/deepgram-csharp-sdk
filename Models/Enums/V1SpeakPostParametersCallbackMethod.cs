using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersCallbackMethod>))]
public sealed record V1SpeakPostParametersCallbackMethod : StringEnum<V1SpeakPostParametersCallbackMethod>
{
    private V1SpeakPostParametersCallbackMethod(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersCallbackMethod Post = new("POST");

    public static readonly V1SpeakPostParametersCallbackMethod Put = new("PUT");

    public static V1SpeakPostParametersCallbackMethod FromValue(string value) => FromValueCore(value);
}
