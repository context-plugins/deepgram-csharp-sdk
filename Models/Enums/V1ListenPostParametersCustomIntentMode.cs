using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersCustomIntentMode>))]
public sealed record V1ListenPostParametersCustomIntentMode : StringEnum<V1ListenPostParametersCustomIntentMode>
{
    private V1ListenPostParametersCustomIntentMode(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersCustomIntentMode Extended = new("extended");

    public static readonly V1ListenPostParametersCustomIntentMode Strict = new("strict");

    public static V1ListenPostParametersCustomIntentMode FromValue(string value) => FromValueCore(value);
}
