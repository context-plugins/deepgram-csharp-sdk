using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersCustomTopicMode>))]
public sealed record V1ListenPostParametersCustomTopicMode : StringEnum<V1ListenPostParametersCustomTopicMode>
{
    private V1ListenPostParametersCustomTopicMode(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersCustomTopicMode Extended = new("extended");

    public static readonly V1ListenPostParametersCustomTopicMode Strict = new("strict");

    public static V1ListenPostParametersCustomTopicMode FromValue(string value) => FromValueCore(value);
}
