using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

/// <summary>
/// Our public models available to all accounts
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersModel0>))]
public sealed record V1ListenPostParametersModel0 : OpenStringEnum<V1ListenPostParametersModel0>
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

    public TResult Match<TResult>(Func<TResult> onNova3,
        Func<TResult> onNova3General,
        Func<TResult> onNova3Medical,
        Func<TResult> onNova2,
        Func<TResult> onNova2General,
        Func<TResult> onNova2Meeting,
        Func<TResult> onNova2Finance,
        Func<TResult> onNova2Conversationalai,
        Func<TResult> onNova2Voicemail,
        Func<TResult> onNova2Video,
        Func<TResult> onNova2Medical,
        Func<TResult> onNova2Drivethru,
        Func<TResult> onNova2Automotive,
        Func<TResult> onNova,
        Func<TResult> onNovaGeneral,
        Func<TResult> onNovaPhonecall,
        Func<TResult> onNovaMedical,
        Func<TResult> onEnhanced,
        Func<TResult> onEnhancedGeneral,
        Func<TResult> onEnhancedMeeting,
        Func<TResult> onEnhancedPhonecall,
        Func<TResult> onEnhancedFinance,
        Func<TResult> onBase,
        Func<TResult> onMeeting,
        Func<TResult> onPhonecall,
        Func<TResult> onFinance,
        Func<TResult> onConversationalai,
        Func<TResult> onVoicemail,
        Func<TResult> onVideo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Nova3 => onNova3(),
            _ when this == Nova3General => onNova3General(),
            _ when this == Nova3Medical => onNova3Medical(),
            _ when this == Nova2 => onNova2(),
            _ when this == Nova2General => onNova2General(),
            _ when this == Nova2Meeting => onNova2Meeting(),
            _ when this == Nova2Finance => onNova2Finance(),
            _ when this == Nova2Conversationalai => onNova2Conversationalai(),
            _ when this == Nova2Voicemail => onNova2Voicemail(),
            _ when this == Nova2Video => onNova2Video(),
            _ when this == Nova2Medical => onNova2Medical(),
            _ when this == Nova2Drivethru => onNova2Drivethru(),
            _ when this == Nova2Automotive => onNova2Automotive(),
            _ when this == Nova => onNova(),
            _ when this == NovaGeneral => onNovaGeneral(),
            _ when this == NovaPhonecall => onNovaPhonecall(),
            _ when this == NovaMedical => onNovaMedical(),
            _ when this == Enhanced => onEnhanced(),
            _ when this == EnhancedGeneral => onEnhancedGeneral(),
            _ when this == EnhancedMeeting => onEnhancedMeeting(),
            _ when this == EnhancedPhonecall => onEnhancedPhonecall(),
            _ when this == EnhancedFinance => onEnhancedFinance(),
            _ when this == Base => onBase(),
            _ when this == Meeting => onMeeting(),
            _ when this == Phonecall => onPhonecall(),
            _ when this == Finance => onFinance(),
            _ when this == Conversationalai => onConversationalai(),
            _ when this == Voicemail => onVoicemail(),
            _ when this == Video => onVideo(),
            _ => otherwise(Value)
        };

    public void Match(Action onNova3,
        Action onNova3General,
        Action onNova3Medical,
        Action onNova2,
        Action onNova2General,
        Action onNova2Meeting,
        Action onNova2Finance,
        Action onNova2Conversationalai,
        Action onNova2Voicemail,
        Action onNova2Video,
        Action onNova2Medical,
        Action onNova2Drivethru,
        Action onNova2Automotive,
        Action onNova,
        Action onNovaGeneral,
        Action onNovaPhonecall,
        Action onNovaMedical,
        Action onEnhanced,
        Action onEnhancedGeneral,
        Action onEnhancedMeeting,
        Action onEnhancedPhonecall,
        Action onEnhancedFinance,
        Action onBase,
        Action onMeeting,
        Action onPhonecall,
        Action onFinance,
        Action onConversationalai,
        Action onVoicemail,
        Action onVideo,
        Action<string> otherwise)
    {
        if (this == Nova3) onNova3();
        else if (this == Nova3General) onNova3General();
        else if (this == Nova3Medical) onNova3Medical();
        else if (this == Nova2) onNova2();
        else if (this == Nova2General) onNova2General();
        else if (this == Nova2Meeting) onNova2Meeting();
        else if (this == Nova2Finance) onNova2Finance();
        else if (this == Nova2Conversationalai) onNova2Conversationalai();
        else if (this == Nova2Voicemail) onNova2Voicemail();
        else if (this == Nova2Video) onNova2Video();
        else if (this == Nova2Medical) onNova2Medical();
        else if (this == Nova2Drivethru) onNova2Drivethru();
        else if (this == Nova2Automotive) onNova2Automotive();
        else if (this == Nova) onNova();
        else if (this == NovaGeneral) onNovaGeneral();
        else if (this == NovaPhonecall) onNovaPhonecall();
        else if (this == NovaMedical) onNovaMedical();
        else if (this == Enhanced) onEnhanced();
        else if (this == EnhancedGeneral) onEnhancedGeneral();
        else if (this == EnhancedMeeting) onEnhancedMeeting();
        else if (this == EnhancedPhonecall) onEnhancedPhonecall();
        else if (this == EnhancedFinance) onEnhancedFinance();
        else if (this == Base) onBase();
        else if (this == Meeting) onMeeting();
        else if (this == Phonecall) onPhonecall();
        else if (this == Finance) onFinance();
        else if (this == Conversationalai) onConversationalai();
        else if (this == Voicemail) onVoicemail();
        else if (this == Video) onVideo();
        else otherwise(Value);
    }
}
