using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersModel>))]
public sealed record V1SpeakPostParametersModel : OpenStringEnum<V1SpeakPostParametersModel>
{
    private V1SpeakPostParametersModel(string value) : base(value)
    {
    }

    public static readonly V1SpeakPostParametersModel AuraAngusEn = new("aura-angus-en");

    public static readonly V1SpeakPostParametersModel AuraArcasEn = new("aura-arcas-en");

    public static readonly V1SpeakPostParametersModel AuraAsteriaEn = new("aura-asteria-en");

    public static readonly V1SpeakPostParametersModel AuraAthenaEn = new("aura-athena-en");

    public static readonly V1SpeakPostParametersModel AuraHeliosEn = new("aura-helios-en");

    public static readonly V1SpeakPostParametersModel AuraHeraEn = new("aura-hera-en");

    public static readonly V1SpeakPostParametersModel AuraLunaEn = new("aura-luna-en");

    public static readonly V1SpeakPostParametersModel AuraOrionEn = new("aura-orion-en");

    public static readonly V1SpeakPostParametersModel AuraOrpheusEn = new("aura-orpheus-en");

    public static readonly V1SpeakPostParametersModel AuraPerseusEn = new("aura-perseus-en");

    public static readonly V1SpeakPostParametersModel AuraStellaEn = new("aura-stella-en");

    public static readonly V1SpeakPostParametersModel AuraZeusEn = new("aura-zeus-en");

    public static readonly V1SpeakPostParametersModel Aura2AmaltheaEn = new("aura-2-amalthea-en");

    public static readonly V1SpeakPostParametersModel Aura2AndromedaEn = new("aura-2-andromeda-en");

    public static readonly V1SpeakPostParametersModel Aura2ApolloEn = new("aura-2-apollo-en");

    public static readonly V1SpeakPostParametersModel Aura2ArcasEn = new("aura-2-arcas-en");

    public static readonly V1SpeakPostParametersModel Aura2AriesEn = new("aura-2-aries-en");

    public static readonly V1SpeakPostParametersModel Aura2AsteriaEn = new("aura-2-asteria-en");

    public static readonly V1SpeakPostParametersModel Aura2AthenaEn = new("aura-2-athena-en");

    public static readonly V1SpeakPostParametersModel Aura2AtlasEn = new("aura-2-atlas-en");

    public static readonly V1SpeakPostParametersModel Aura2AuroraEn = new("aura-2-aurora-en");

    public static readonly V1SpeakPostParametersModel Aura2CallistaEn = new("aura-2-callista-en");

    public static readonly V1SpeakPostParametersModel Aura2CoraEn = new("aura-2-cora-en");

    public static readonly V1SpeakPostParametersModel Aura2CordeliaEn = new("aura-2-cordelia-en");

    public static readonly V1SpeakPostParametersModel Aura2DeliaEn = new("aura-2-delia-en");

    public static readonly V1SpeakPostParametersModel Aura2DracoEn = new("aura-2-draco-en");

    public static readonly V1SpeakPostParametersModel Aura2ElectraEn = new("aura-2-electra-en");

    public static readonly V1SpeakPostParametersModel Aura2HarmoniaEn = new("aura-2-harmonia-en");

    public static readonly V1SpeakPostParametersModel Aura2HelenaEn = new("aura-2-helena-en");

    public static readonly V1SpeakPostParametersModel Aura2HeraEn = new("aura-2-hera-en");

    public static readonly V1SpeakPostParametersModel Aura2HermesEn = new("aura-2-hermes-en");

    public static readonly V1SpeakPostParametersModel Aura2HyperionEn = new("aura-2-hyperion-en");

    public static readonly V1SpeakPostParametersModel Aura2IrisEn = new("aura-2-iris-en");

    public static readonly V1SpeakPostParametersModel Aura2JanusEn = new("aura-2-janus-en");

    public static readonly V1SpeakPostParametersModel Aura2JunoEn = new("aura-2-juno-en");

    public static readonly V1SpeakPostParametersModel Aura2JupiterEn = new("aura-2-jupiter-en");

    public static readonly V1SpeakPostParametersModel Aura2LunaEn = new("aura-2-luna-en");

    public static readonly V1SpeakPostParametersModel Aura2MarsEn = new("aura-2-mars-en");

    public static readonly V1SpeakPostParametersModel Aura2MinervaEn = new("aura-2-minerva-en");

    public static readonly V1SpeakPostParametersModel Aura2NeptuneEn = new("aura-2-neptune-en");

    public static readonly V1SpeakPostParametersModel Aura2OdysseusEn = new("aura-2-odysseus-en");

    public static readonly V1SpeakPostParametersModel Aura2OpheliaEn = new("aura-2-ophelia-en");

    public static readonly V1SpeakPostParametersModel Aura2OrionEn = new("aura-2-orion-en");

    public static readonly V1SpeakPostParametersModel Aura2OrpheusEn = new("aura-2-orpheus-en");

    public static readonly V1SpeakPostParametersModel Aura2PandoraEn = new("aura-2-pandora-en");

    public static readonly V1SpeakPostParametersModel Aura2PhoebeEn = new("aura-2-phoebe-en");

    public static readonly V1SpeakPostParametersModel Aura2PlutoEn = new("aura-2-pluto-en");

    public static readonly V1SpeakPostParametersModel Aura2SaturnEn = new("aura-2-saturn-en");

    public static readonly V1SpeakPostParametersModel Aura2SeleneEn = new("aura-2-selene-en");

    public static readonly V1SpeakPostParametersModel Aura2ThaliaEn = new("aura-2-thalia-en");

    public static readonly V1SpeakPostParametersModel Aura2TheiaEn = new("aura-2-theia-en");

    public static readonly V1SpeakPostParametersModel Aura2VestaEn = new("aura-2-vesta-en");

    public static readonly V1SpeakPostParametersModel Aura2ZeusEn = new("aura-2-zeus-en");

    public static readonly V1SpeakPostParametersModel Aura2AgustinaEs = new("aura-2-agustina-es");

    public static readonly V1SpeakPostParametersModel Aura2AlvaroEs = new("aura-2-alvaro-es");

    public static readonly V1SpeakPostParametersModel Aura2AntoniaEs = new("aura-2-antonia-es");

    public static readonly V1SpeakPostParametersModel Aura2AquilaEs = new("aura-2-aquila-es");

    public static readonly V1SpeakPostParametersModel Aura2CarinaEs = new("aura-2-carina-es");

    public static readonly V1SpeakPostParametersModel Aura2CelesteEs = new("aura-2-celeste-es");

    public static readonly V1SpeakPostParametersModel Aura2DianaEs = new("aura-2-diana-es");

    public static readonly V1SpeakPostParametersModel Aura2EstrellaEs = new("aura-2-estrella-es");

    public static readonly V1SpeakPostParametersModel Aura2GloriaEs = new("aura-2-gloria-es");

    public static readonly V1SpeakPostParametersModel Aura2JavierEs = new("aura-2-javier-es");

    public static readonly V1SpeakPostParametersModel Aura2LucianoEs = new("aura-2-luciano-es");

    public static readonly V1SpeakPostParametersModel Aura2NestorEs = new("aura-2-nestor-es");

    public static readonly V1SpeakPostParametersModel Aura2OliviaEs = new("aura-2-olivia-es");

    public static readonly V1SpeakPostParametersModel Aura2SelenaEs = new("aura-2-selena-es");

    public static readonly V1SpeakPostParametersModel Aura2SilviaEs = new("aura-2-silvia-es");

    public static readonly V1SpeakPostParametersModel Aura2SirioEs = new("aura-2-sirio-es");

    public static readonly V1SpeakPostParametersModel Aura2ValerioEs = new("aura-2-valerio-es");

    public static readonly V1SpeakPostParametersModel Aura2AureliaDe = new("aura-2-aurelia-de");

    public static readonly V1SpeakPostParametersModel Aura2ElaraDe = new("aura-2-elara-de");

    public static readonly V1SpeakPostParametersModel Aura2FabianDe = new("aura-2-fabian-de");

    public static readonly V1SpeakPostParametersModel Aura2JuliusDe = new("aura-2-julius-de");

    public static readonly V1SpeakPostParametersModel Aura2KaraDe = new("aura-2-kara-de");

    public static readonly V1SpeakPostParametersModel Aura2LaraDe = new("aura-2-lara-de");

    public static readonly V1SpeakPostParametersModel Aura2ViktoriaDe = new("aura-2-viktoria-de");

    public static readonly V1SpeakPostParametersModel Aura2BeatrixNl = new("aura-2-beatrix-nl");

    public static readonly V1SpeakPostParametersModel Aura2CorneliaNl = new("aura-2-cornelia-nl");

    public static readonly V1SpeakPostParametersModel Aura2DaphneNl = new("aura-2-daphne-nl");

    public static readonly V1SpeakPostParametersModel Aura2HestiaNl = new("aura-2-hestia-nl");

    public static readonly V1SpeakPostParametersModel Aura2LarsNl = new("aura-2-lars-nl");

    public static readonly V1SpeakPostParametersModel Aura2LedaNl = new("aura-2-leda-nl");

    public static readonly V1SpeakPostParametersModel Aura2RheaNl = new("aura-2-rhea-nl");

    public static readonly V1SpeakPostParametersModel Aura2RomanNl = new("aura-2-roman-nl");

    public static readonly V1SpeakPostParametersModel Aura2SanderNl = new("aura-2-sander-nl");

    public static readonly V1SpeakPostParametersModel Aura2AgatheFr = new("aura-2-agathe-fr");

    public static readonly V1SpeakPostParametersModel Aura2HectorFr = new("aura-2-hector-fr");

    public static readonly V1SpeakPostParametersModel Aura2CesareIt = new("aura-2-cesare-it");

    public static readonly V1SpeakPostParametersModel Aura2CinziaIt = new("aura-2-cinzia-it");

    public static readonly V1SpeakPostParametersModel Aura2DemetraIt = new("aura-2-demetra-it");

    public static readonly V1SpeakPostParametersModel Aura2DionisioIt = new("aura-2-dionisio-it");

    public static readonly V1SpeakPostParametersModel Aura2ElioIt = new("aura-2-elio-it");

    public static readonly V1SpeakPostParametersModel Aura2FlavioIt = new("aura-2-flavio-it");

    public static readonly V1SpeakPostParametersModel Aura2LiviaIt = new("aura-2-livia-it");

    public static readonly V1SpeakPostParametersModel Aura2MaiaIt = new("aura-2-maia-it");

    public static readonly V1SpeakPostParametersModel Aura2MeliaIt = new("aura-2-melia-it");

    public static readonly V1SpeakPostParametersModel Aura2PerseoIt = new("aura-2-perseo-it");

    public static readonly V1SpeakPostParametersModel Aura2AmaJa = new("aura-2-ama-ja");

    public static readonly V1SpeakPostParametersModel Aura2EbisuJa = new("aura-2-ebisu-ja");

    public static readonly V1SpeakPostParametersModel Aura2FujinJa = new("aura-2-fujin-ja");

    public static readonly V1SpeakPostParametersModel Aura2IzanamiJa = new("aura-2-izanami-ja");

    public static readonly V1SpeakPostParametersModel Aura2UzumeJa = new("aura-2-uzume-ja");

    public TResult Match<TResult>(Func<TResult> onAuraAngusEn,
        Func<TResult> onAuraArcasEn,
        Func<TResult> onAuraAsteriaEn,
        Func<TResult> onAuraAthenaEn,
        Func<TResult> onAuraHeliosEn,
        Func<TResult> onAuraHeraEn,
        Func<TResult> onAuraLunaEn,
        Func<TResult> onAuraOrionEn,
        Func<TResult> onAuraOrpheusEn,
        Func<TResult> onAuraPerseusEn,
        Func<TResult> onAuraStellaEn,
        Func<TResult> onAuraZeusEn,
        Func<TResult> onAura2AmaltheaEn,
        Func<TResult> onAura2AndromedaEn,
        Func<TResult> onAura2ApolloEn,
        Func<TResult> onAura2ArcasEn,
        Func<TResult> onAura2AriesEn,
        Func<TResult> onAura2AsteriaEn,
        Func<TResult> onAura2AthenaEn,
        Func<TResult> onAura2AtlasEn,
        Func<TResult> onAura2AuroraEn,
        Func<TResult> onAura2CallistaEn,
        Func<TResult> onAura2CoraEn,
        Func<TResult> onAura2CordeliaEn,
        Func<TResult> onAura2DeliaEn,
        Func<TResult> onAura2DracoEn,
        Func<TResult> onAura2ElectraEn,
        Func<TResult> onAura2HarmoniaEn,
        Func<TResult> onAura2HelenaEn,
        Func<TResult> onAura2HeraEn,
        Func<TResult> onAura2HermesEn,
        Func<TResult> onAura2HyperionEn,
        Func<TResult> onAura2IrisEn,
        Func<TResult> onAura2JanusEn,
        Func<TResult> onAura2JunoEn,
        Func<TResult> onAura2JupiterEn,
        Func<TResult> onAura2LunaEn,
        Func<TResult> onAura2MarsEn,
        Func<TResult> onAura2MinervaEn,
        Func<TResult> onAura2NeptuneEn,
        Func<TResult> onAura2OdysseusEn,
        Func<TResult> onAura2OpheliaEn,
        Func<TResult> onAura2OrionEn,
        Func<TResult> onAura2OrpheusEn,
        Func<TResult> onAura2PandoraEn,
        Func<TResult> onAura2PhoebeEn,
        Func<TResult> onAura2PlutoEn,
        Func<TResult> onAura2SaturnEn,
        Func<TResult> onAura2SeleneEn,
        Func<TResult> onAura2ThaliaEn,
        Func<TResult> onAura2TheiaEn,
        Func<TResult> onAura2VestaEn,
        Func<TResult> onAura2ZeusEn,
        Func<TResult> onAura2AgustinaEs,
        Func<TResult> onAura2AlvaroEs,
        Func<TResult> onAura2AntoniaEs,
        Func<TResult> onAura2AquilaEs,
        Func<TResult> onAura2CarinaEs,
        Func<TResult> onAura2CelesteEs,
        Func<TResult> onAura2DianaEs,
        Func<TResult> onAura2EstrellaEs,
        Func<TResult> onAura2GloriaEs,
        Func<TResult> onAura2JavierEs,
        Func<TResult> onAura2LucianoEs,
        Func<TResult> onAura2NestorEs,
        Func<TResult> onAura2OliviaEs,
        Func<TResult> onAura2SelenaEs,
        Func<TResult> onAura2SilviaEs,
        Func<TResult> onAura2SirioEs,
        Func<TResult> onAura2ValerioEs,
        Func<TResult> onAura2AureliaDe,
        Func<TResult> onAura2ElaraDe,
        Func<TResult> onAura2FabianDe,
        Func<TResult> onAura2JuliusDe,
        Func<TResult> onAura2KaraDe,
        Func<TResult> onAura2LaraDe,
        Func<TResult> onAura2ViktoriaDe,
        Func<TResult> onAura2BeatrixNl,
        Func<TResult> onAura2CorneliaNl,
        Func<TResult> onAura2DaphneNl,
        Func<TResult> onAura2HestiaNl,
        Func<TResult> onAura2LarsNl,
        Func<TResult> onAura2LedaNl,
        Func<TResult> onAura2RheaNl,
        Func<TResult> onAura2RomanNl,
        Func<TResult> onAura2SanderNl,
        Func<TResult> onAura2AgatheFr,
        Func<TResult> onAura2HectorFr,
        Func<TResult> onAura2CesareIt,
        Func<TResult> onAura2CinziaIt,
        Func<TResult> onAura2DemetraIt,
        Func<TResult> onAura2DionisioIt,
        Func<TResult> onAura2ElioIt,
        Func<TResult> onAura2FlavioIt,
        Func<TResult> onAura2LiviaIt,
        Func<TResult> onAura2MaiaIt,
        Func<TResult> onAura2MeliaIt,
        Func<TResult> onAura2PerseoIt,
        Func<TResult> onAura2AmaJa,
        Func<TResult> onAura2EbisuJa,
        Func<TResult> onAura2FujinJa,
        Func<TResult> onAura2IzanamiJa,
        Func<TResult> onAura2UzumeJa,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AuraAngusEn => onAuraAngusEn(),
            _ when this == AuraArcasEn => onAuraArcasEn(),
            _ when this == AuraAsteriaEn => onAuraAsteriaEn(),
            _ when this == AuraAthenaEn => onAuraAthenaEn(),
            _ when this == AuraHeliosEn => onAuraHeliosEn(),
            _ when this == AuraHeraEn => onAuraHeraEn(),
            _ when this == AuraLunaEn => onAuraLunaEn(),
            _ when this == AuraOrionEn => onAuraOrionEn(),
            _ when this == AuraOrpheusEn => onAuraOrpheusEn(),
            _ when this == AuraPerseusEn => onAuraPerseusEn(),
            _ when this == AuraStellaEn => onAuraStellaEn(),
            _ when this == AuraZeusEn => onAuraZeusEn(),
            _ when this == Aura2AmaltheaEn => onAura2AmaltheaEn(),
            _ when this == Aura2AndromedaEn => onAura2AndromedaEn(),
            _ when this == Aura2ApolloEn => onAura2ApolloEn(),
            _ when this == Aura2ArcasEn => onAura2ArcasEn(),
            _ when this == Aura2AriesEn => onAura2AriesEn(),
            _ when this == Aura2AsteriaEn => onAura2AsteriaEn(),
            _ when this == Aura2AthenaEn => onAura2AthenaEn(),
            _ when this == Aura2AtlasEn => onAura2AtlasEn(),
            _ when this == Aura2AuroraEn => onAura2AuroraEn(),
            _ when this == Aura2CallistaEn => onAura2CallistaEn(),
            _ when this == Aura2CoraEn => onAura2CoraEn(),
            _ when this == Aura2CordeliaEn => onAura2CordeliaEn(),
            _ when this == Aura2DeliaEn => onAura2DeliaEn(),
            _ when this == Aura2DracoEn => onAura2DracoEn(),
            _ when this == Aura2ElectraEn => onAura2ElectraEn(),
            _ when this == Aura2HarmoniaEn => onAura2HarmoniaEn(),
            _ when this == Aura2HelenaEn => onAura2HelenaEn(),
            _ when this == Aura2HeraEn => onAura2HeraEn(),
            _ when this == Aura2HermesEn => onAura2HermesEn(),
            _ when this == Aura2HyperionEn => onAura2HyperionEn(),
            _ when this == Aura2IrisEn => onAura2IrisEn(),
            _ when this == Aura2JanusEn => onAura2JanusEn(),
            _ when this == Aura2JunoEn => onAura2JunoEn(),
            _ when this == Aura2JupiterEn => onAura2JupiterEn(),
            _ when this == Aura2LunaEn => onAura2LunaEn(),
            _ when this == Aura2MarsEn => onAura2MarsEn(),
            _ when this == Aura2MinervaEn => onAura2MinervaEn(),
            _ when this == Aura2NeptuneEn => onAura2NeptuneEn(),
            _ when this == Aura2OdysseusEn => onAura2OdysseusEn(),
            _ when this == Aura2OpheliaEn => onAura2OpheliaEn(),
            _ when this == Aura2OrionEn => onAura2OrionEn(),
            _ when this == Aura2OrpheusEn => onAura2OrpheusEn(),
            _ when this == Aura2PandoraEn => onAura2PandoraEn(),
            _ when this == Aura2PhoebeEn => onAura2PhoebeEn(),
            _ when this == Aura2PlutoEn => onAura2PlutoEn(),
            _ when this == Aura2SaturnEn => onAura2SaturnEn(),
            _ when this == Aura2SeleneEn => onAura2SeleneEn(),
            _ when this == Aura2ThaliaEn => onAura2ThaliaEn(),
            _ when this == Aura2TheiaEn => onAura2TheiaEn(),
            _ when this == Aura2VestaEn => onAura2VestaEn(),
            _ when this == Aura2ZeusEn => onAura2ZeusEn(),
            _ when this == Aura2AgustinaEs => onAura2AgustinaEs(),
            _ when this == Aura2AlvaroEs => onAura2AlvaroEs(),
            _ when this == Aura2AntoniaEs => onAura2AntoniaEs(),
            _ when this == Aura2AquilaEs => onAura2AquilaEs(),
            _ when this == Aura2CarinaEs => onAura2CarinaEs(),
            _ when this == Aura2CelesteEs => onAura2CelesteEs(),
            _ when this == Aura2DianaEs => onAura2DianaEs(),
            _ when this == Aura2EstrellaEs => onAura2EstrellaEs(),
            _ when this == Aura2GloriaEs => onAura2GloriaEs(),
            _ when this == Aura2JavierEs => onAura2JavierEs(),
            _ when this == Aura2LucianoEs => onAura2LucianoEs(),
            _ when this == Aura2NestorEs => onAura2NestorEs(),
            _ when this == Aura2OliviaEs => onAura2OliviaEs(),
            _ when this == Aura2SelenaEs => onAura2SelenaEs(),
            _ when this == Aura2SilviaEs => onAura2SilviaEs(),
            _ when this == Aura2SirioEs => onAura2SirioEs(),
            _ when this == Aura2ValerioEs => onAura2ValerioEs(),
            _ when this == Aura2AureliaDe => onAura2AureliaDe(),
            _ when this == Aura2ElaraDe => onAura2ElaraDe(),
            _ when this == Aura2FabianDe => onAura2FabianDe(),
            _ when this == Aura2JuliusDe => onAura2JuliusDe(),
            _ when this == Aura2KaraDe => onAura2KaraDe(),
            _ when this == Aura2LaraDe => onAura2LaraDe(),
            _ when this == Aura2ViktoriaDe => onAura2ViktoriaDe(),
            _ when this == Aura2BeatrixNl => onAura2BeatrixNl(),
            _ when this == Aura2CorneliaNl => onAura2CorneliaNl(),
            _ when this == Aura2DaphneNl => onAura2DaphneNl(),
            _ when this == Aura2HestiaNl => onAura2HestiaNl(),
            _ when this == Aura2LarsNl => onAura2LarsNl(),
            _ when this == Aura2LedaNl => onAura2LedaNl(),
            _ when this == Aura2RheaNl => onAura2RheaNl(),
            _ when this == Aura2RomanNl => onAura2RomanNl(),
            _ when this == Aura2SanderNl => onAura2SanderNl(),
            _ when this == Aura2AgatheFr => onAura2AgatheFr(),
            _ when this == Aura2HectorFr => onAura2HectorFr(),
            _ when this == Aura2CesareIt => onAura2CesareIt(),
            _ when this == Aura2CinziaIt => onAura2CinziaIt(),
            _ when this == Aura2DemetraIt => onAura2DemetraIt(),
            _ when this == Aura2DionisioIt => onAura2DionisioIt(),
            _ when this == Aura2ElioIt => onAura2ElioIt(),
            _ when this == Aura2FlavioIt => onAura2FlavioIt(),
            _ when this == Aura2LiviaIt => onAura2LiviaIt(),
            _ when this == Aura2MaiaIt => onAura2MaiaIt(),
            _ when this == Aura2MeliaIt => onAura2MeliaIt(),
            _ when this == Aura2PerseoIt => onAura2PerseoIt(),
            _ when this == Aura2AmaJa => onAura2AmaJa(),
            _ when this == Aura2EbisuJa => onAura2EbisuJa(),
            _ when this == Aura2FujinJa => onAura2FujinJa(),
            _ when this == Aura2IzanamiJa => onAura2IzanamiJa(),
            _ when this == Aura2UzumeJa => onAura2UzumeJa(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuraAngusEn,
        Action onAuraArcasEn,
        Action onAuraAsteriaEn,
        Action onAuraAthenaEn,
        Action onAuraHeliosEn,
        Action onAuraHeraEn,
        Action onAuraLunaEn,
        Action onAuraOrionEn,
        Action onAuraOrpheusEn,
        Action onAuraPerseusEn,
        Action onAuraStellaEn,
        Action onAuraZeusEn,
        Action onAura2AmaltheaEn,
        Action onAura2AndromedaEn,
        Action onAura2ApolloEn,
        Action onAura2ArcasEn,
        Action onAura2AriesEn,
        Action onAura2AsteriaEn,
        Action onAura2AthenaEn,
        Action onAura2AtlasEn,
        Action onAura2AuroraEn,
        Action onAura2CallistaEn,
        Action onAura2CoraEn,
        Action onAura2CordeliaEn,
        Action onAura2DeliaEn,
        Action onAura2DracoEn,
        Action onAura2ElectraEn,
        Action onAura2HarmoniaEn,
        Action onAura2HelenaEn,
        Action onAura2HeraEn,
        Action onAura2HermesEn,
        Action onAura2HyperionEn,
        Action onAura2IrisEn,
        Action onAura2JanusEn,
        Action onAura2JunoEn,
        Action onAura2JupiterEn,
        Action onAura2LunaEn,
        Action onAura2MarsEn,
        Action onAura2MinervaEn,
        Action onAura2NeptuneEn,
        Action onAura2OdysseusEn,
        Action onAura2OpheliaEn,
        Action onAura2OrionEn,
        Action onAura2OrpheusEn,
        Action onAura2PandoraEn,
        Action onAura2PhoebeEn,
        Action onAura2PlutoEn,
        Action onAura2SaturnEn,
        Action onAura2SeleneEn,
        Action onAura2ThaliaEn,
        Action onAura2TheiaEn,
        Action onAura2VestaEn,
        Action onAura2ZeusEn,
        Action onAura2AgustinaEs,
        Action onAura2AlvaroEs,
        Action onAura2AntoniaEs,
        Action onAura2AquilaEs,
        Action onAura2CarinaEs,
        Action onAura2CelesteEs,
        Action onAura2DianaEs,
        Action onAura2EstrellaEs,
        Action onAura2GloriaEs,
        Action onAura2JavierEs,
        Action onAura2LucianoEs,
        Action onAura2NestorEs,
        Action onAura2OliviaEs,
        Action onAura2SelenaEs,
        Action onAura2SilviaEs,
        Action onAura2SirioEs,
        Action onAura2ValerioEs,
        Action onAura2AureliaDe,
        Action onAura2ElaraDe,
        Action onAura2FabianDe,
        Action onAura2JuliusDe,
        Action onAura2KaraDe,
        Action onAura2LaraDe,
        Action onAura2ViktoriaDe,
        Action onAura2BeatrixNl,
        Action onAura2CorneliaNl,
        Action onAura2DaphneNl,
        Action onAura2HestiaNl,
        Action onAura2LarsNl,
        Action onAura2LedaNl,
        Action onAura2RheaNl,
        Action onAura2RomanNl,
        Action onAura2SanderNl,
        Action onAura2AgatheFr,
        Action onAura2HectorFr,
        Action onAura2CesareIt,
        Action onAura2CinziaIt,
        Action onAura2DemetraIt,
        Action onAura2DionisioIt,
        Action onAura2ElioIt,
        Action onAura2FlavioIt,
        Action onAura2LiviaIt,
        Action onAura2MaiaIt,
        Action onAura2MeliaIt,
        Action onAura2PerseoIt,
        Action onAura2AmaJa,
        Action onAura2EbisuJa,
        Action onAura2FujinJa,
        Action onAura2IzanamiJa,
        Action onAura2UzumeJa,
        Action<string> otherwise)
    {
        if (this == AuraAngusEn) onAuraAngusEn();
        else if (this == AuraArcasEn) onAuraArcasEn();
        else if (this == AuraAsteriaEn) onAuraAsteriaEn();
        else if (this == AuraAthenaEn) onAuraAthenaEn();
        else if (this == AuraHeliosEn) onAuraHeliosEn();
        else if (this == AuraHeraEn) onAuraHeraEn();
        else if (this == AuraLunaEn) onAuraLunaEn();
        else if (this == AuraOrionEn) onAuraOrionEn();
        else if (this == AuraOrpheusEn) onAuraOrpheusEn();
        else if (this == AuraPerseusEn) onAuraPerseusEn();
        else if (this == AuraStellaEn) onAuraStellaEn();
        else if (this == AuraZeusEn) onAuraZeusEn();
        else if (this == Aura2AmaltheaEn) onAura2AmaltheaEn();
        else if (this == Aura2AndromedaEn) onAura2AndromedaEn();
        else if (this == Aura2ApolloEn) onAura2ApolloEn();
        else if (this == Aura2ArcasEn) onAura2ArcasEn();
        else if (this == Aura2AriesEn) onAura2AriesEn();
        else if (this == Aura2AsteriaEn) onAura2AsteriaEn();
        else if (this == Aura2AthenaEn) onAura2AthenaEn();
        else if (this == Aura2AtlasEn) onAura2AtlasEn();
        else if (this == Aura2AuroraEn) onAura2AuroraEn();
        else if (this == Aura2CallistaEn) onAura2CallistaEn();
        else if (this == Aura2CoraEn) onAura2CoraEn();
        else if (this == Aura2CordeliaEn) onAura2CordeliaEn();
        else if (this == Aura2DeliaEn) onAura2DeliaEn();
        else if (this == Aura2DracoEn) onAura2DracoEn();
        else if (this == Aura2ElectraEn) onAura2ElectraEn();
        else if (this == Aura2HarmoniaEn) onAura2HarmoniaEn();
        else if (this == Aura2HelenaEn) onAura2HelenaEn();
        else if (this == Aura2HeraEn) onAura2HeraEn();
        else if (this == Aura2HermesEn) onAura2HermesEn();
        else if (this == Aura2HyperionEn) onAura2HyperionEn();
        else if (this == Aura2IrisEn) onAura2IrisEn();
        else if (this == Aura2JanusEn) onAura2JanusEn();
        else if (this == Aura2JunoEn) onAura2JunoEn();
        else if (this == Aura2JupiterEn) onAura2JupiterEn();
        else if (this == Aura2LunaEn) onAura2LunaEn();
        else if (this == Aura2MarsEn) onAura2MarsEn();
        else if (this == Aura2MinervaEn) onAura2MinervaEn();
        else if (this == Aura2NeptuneEn) onAura2NeptuneEn();
        else if (this == Aura2OdysseusEn) onAura2OdysseusEn();
        else if (this == Aura2OpheliaEn) onAura2OpheliaEn();
        else if (this == Aura2OrionEn) onAura2OrionEn();
        else if (this == Aura2OrpheusEn) onAura2OrpheusEn();
        else if (this == Aura2PandoraEn) onAura2PandoraEn();
        else if (this == Aura2PhoebeEn) onAura2PhoebeEn();
        else if (this == Aura2PlutoEn) onAura2PlutoEn();
        else if (this == Aura2SaturnEn) onAura2SaturnEn();
        else if (this == Aura2SeleneEn) onAura2SeleneEn();
        else if (this == Aura2ThaliaEn) onAura2ThaliaEn();
        else if (this == Aura2TheiaEn) onAura2TheiaEn();
        else if (this == Aura2VestaEn) onAura2VestaEn();
        else if (this == Aura2ZeusEn) onAura2ZeusEn();
        else if (this == Aura2AgustinaEs) onAura2AgustinaEs();
        else if (this == Aura2AlvaroEs) onAura2AlvaroEs();
        else if (this == Aura2AntoniaEs) onAura2AntoniaEs();
        else if (this == Aura2AquilaEs) onAura2AquilaEs();
        else if (this == Aura2CarinaEs) onAura2CarinaEs();
        else if (this == Aura2CelesteEs) onAura2CelesteEs();
        else if (this == Aura2DianaEs) onAura2DianaEs();
        else if (this == Aura2EstrellaEs) onAura2EstrellaEs();
        else if (this == Aura2GloriaEs) onAura2GloriaEs();
        else if (this == Aura2JavierEs) onAura2JavierEs();
        else if (this == Aura2LucianoEs) onAura2LucianoEs();
        else if (this == Aura2NestorEs) onAura2NestorEs();
        else if (this == Aura2OliviaEs) onAura2OliviaEs();
        else if (this == Aura2SelenaEs) onAura2SelenaEs();
        else if (this == Aura2SilviaEs) onAura2SilviaEs();
        else if (this == Aura2SirioEs) onAura2SirioEs();
        else if (this == Aura2ValerioEs) onAura2ValerioEs();
        else if (this == Aura2AureliaDe) onAura2AureliaDe();
        else if (this == Aura2ElaraDe) onAura2ElaraDe();
        else if (this == Aura2FabianDe) onAura2FabianDe();
        else if (this == Aura2JuliusDe) onAura2JuliusDe();
        else if (this == Aura2KaraDe) onAura2KaraDe();
        else if (this == Aura2LaraDe) onAura2LaraDe();
        else if (this == Aura2ViktoriaDe) onAura2ViktoriaDe();
        else if (this == Aura2BeatrixNl) onAura2BeatrixNl();
        else if (this == Aura2CorneliaNl) onAura2CorneliaNl();
        else if (this == Aura2DaphneNl) onAura2DaphneNl();
        else if (this == Aura2HestiaNl) onAura2HestiaNl();
        else if (this == Aura2LarsNl) onAura2LarsNl();
        else if (this == Aura2LedaNl) onAura2LedaNl();
        else if (this == Aura2RheaNl) onAura2RheaNl();
        else if (this == Aura2RomanNl) onAura2RomanNl();
        else if (this == Aura2SanderNl) onAura2SanderNl();
        else if (this == Aura2AgatheFr) onAura2AgatheFr();
        else if (this == Aura2HectorFr) onAura2HectorFr();
        else if (this == Aura2CesareIt) onAura2CesareIt();
        else if (this == Aura2CinziaIt) onAura2CinziaIt();
        else if (this == Aura2DemetraIt) onAura2DemetraIt();
        else if (this == Aura2DionisioIt) onAura2DionisioIt();
        else if (this == Aura2ElioIt) onAura2ElioIt();
        else if (this == Aura2FlavioIt) onAura2FlavioIt();
        else if (this == Aura2LiviaIt) onAura2LiviaIt();
        else if (this == Aura2MaiaIt) onAura2MaiaIt();
        else if (this == Aura2MeliaIt) onAura2MeliaIt();
        else if (this == Aura2PerseoIt) onAura2PerseoIt();
        else if (this == Aura2AmaJa) onAura2AmaJa();
        else if (this == Aura2EbisuJa) onAura2EbisuJa();
        else if (this == Aura2FujinJa) onAura2FujinJa();
        else if (this == Aura2IzanamiJa) onAura2IzanamiJa();
        else if (this == Aura2UzumeJa) onAura2UzumeJa();
        else otherwise(Value);
    }
}
