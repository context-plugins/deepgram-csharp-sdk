using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Our public models available to all accounts
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersModel0>))]
public sealed record V1ListenPostParametersModel0 : StringEnum<V1ListenPostParametersModel0>
{
    private V1ListenPostParametersModel0(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersModel0 Nova3 = new("nova-3");

    public static readonly V1ListenPostParametersModel0 Nova3General = new("nova-3-general");

    public static readonly V1ListenPostParametersModel0 Nova3Medical = new("nova-3-medical");

    public static readonly V1ListenPostParametersModel0 Nova2 = new("nova-2");

    public static readonly V1ListenPostParametersModel0 Nova2General = new("nova-2-general");

    public static readonly V1ListenPostParametersModel0 Nova2Meeting = new("nova-2-meeting");

    public static readonly V1ListenPostParametersModel0 Nova2Finance = new("nova-2-finance");

    public static readonly V1ListenPostParametersModel0 Nova2Conversationalai = new("nova-2-conversationalai");

    public static readonly V1ListenPostParametersModel0 Nova2Voicemail = new("nova-2-voicemail");

    public static readonly V1ListenPostParametersModel0 Nova2Video = new("nova-2-video");

    public static readonly V1ListenPostParametersModel0 Nova2Medical = new("nova-2-medical");

    public static readonly V1ListenPostParametersModel0 Nova2Drivethru = new("nova-2-drivethru");

    public static readonly V1ListenPostParametersModel0 Nova2Automotive = new("nova-2-automotive");

    public static readonly V1ListenPostParametersModel0 Nova = new("nova");

    public static readonly V1ListenPostParametersModel0 NovaGeneral = new("nova-general");

    public static readonly V1ListenPostParametersModel0 NovaPhonecall = new("nova-phonecall");

    public static readonly V1ListenPostParametersModel0 NovaMedical = new("nova-medical");

    public static readonly V1ListenPostParametersModel0 Enhanced = new("enhanced");

    public static readonly V1ListenPostParametersModel0 EnhancedGeneral = new("enhanced-general");

    public static readonly V1ListenPostParametersModel0 EnhancedMeeting = new("enhanced-meeting");

    public static readonly V1ListenPostParametersModel0 EnhancedPhonecall = new("enhanced-phonecall");

    public static readonly V1ListenPostParametersModel0 EnhancedFinance = new("enhanced-finance");

    public static readonly V1ListenPostParametersModel0 Base = new("base");

    public static readonly V1ListenPostParametersModel0 Meeting = new("meeting");

    public static readonly V1ListenPostParametersModel0 Phonecall = new("phonecall");

    public static readonly V1ListenPostParametersModel0 Finance = new("finance");

    public static readonly V1ListenPostParametersModel0 Conversationalai = new("conversationalai");

    public static readonly V1ListenPostParametersModel0 Voicemail = new("voicemail");

    public static readonly V1ListenPostParametersModel0 Video = new("video");

    public static V1ListenPostParametersModel0 FromValue(string value) => FromValueCore(value);
}
