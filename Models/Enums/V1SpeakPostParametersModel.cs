using System.Text.Json.Serialization;
using RestApi.Core.Enum;

namespace RestApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1SpeakPostParametersModel>))]
public sealed record V1SpeakPostParametersModel : StringEnum<V1SpeakPostParametersModel>
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

    public static V1SpeakPostParametersModel FromValue(string value) => FromValueCore(value);
}
