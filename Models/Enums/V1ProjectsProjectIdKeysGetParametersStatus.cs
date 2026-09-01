using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ProjectsProjectIdKeysGetParametersStatus>))]
public sealed record V1ProjectsProjectIdKeysGetParametersStatus : StringEnum<V1ProjectsProjectIdKeysGetParametersStatus>
{
    private V1ProjectsProjectIdKeysGetParametersStatus(string value) : base(value)
    {
    }

    public static readonly V1ProjectsProjectIdKeysGetParametersStatus Active = new("active");

    public static readonly V1ProjectsProjectIdKeysGetParametersStatus Expired = new("expired");

    public static V1ProjectsProjectIdKeysGetParametersStatus FromValue(string value) => FromValueCore(value);
}
