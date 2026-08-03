using System.Net.Http;
using RestApi.Api;
using RestApi.Core;
using RestApi.Core.Logging;
using RestApi.Core.Models;

namespace RestApi;

public sealed class RestApiClient
{
    public RestApiClient(HttpClient httpClient, RestApiClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "RestApiClient/1.0.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.0.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "RestApiClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        AgentV1SettingsThinkModels = new AgentV1SettingsThinkModels(rawClient, server);
        AuthV1Tokens = new AuthV1Tokens(rawClient, server);
        ListenV1Media = new ListenV1Media(rawClient, server);
        ManageV1Models = new ManageV1Models(rawClient, server);
        ManageV1Projects = new ManageV1Projects(rawClient, server);
        ManageV1ProjectsBillingBalances = new ManageV1ProjectsBillingBalances(rawClient, server);
        ManageV1ProjectsBillingBreakdown = new ManageV1ProjectsBillingBreakdown(rawClient, server);
        ManageV1ProjectsBillingFields = new ManageV1ProjectsBillingFields(rawClient, server);
        ManageV1ProjectsBillingPurchases = new ManageV1ProjectsBillingPurchases(rawClient, server);
        ManageV1ProjectsKeys = new ManageV1ProjectsKeys(rawClient, server);
        ManageV1ProjectsMembers = new ManageV1ProjectsMembers(rawClient, server);
        ManageV1ProjectsMembersInvites = new ManageV1ProjectsMembersInvites(rawClient, server);
        ManageV1ProjectsMembersScopes = new ManageV1ProjectsMembersScopes(rawClient, server);
        ManageV1ProjectsModels = new ManageV1ProjectsModels(rawClient, server);
        ManageV1ProjectsRequests = new ManageV1ProjectsRequests(rawClient, server);
        ManageV1ProjectsUsage = new ManageV1ProjectsUsage(rawClient, server);
        ManageV1ProjectsUsageBreakdown = new ManageV1ProjectsUsageBreakdown(rawClient, server);
        ManageV1ProjectsUsageFields = new ManageV1ProjectsUsageFields(rawClient, server);
        ReadV1Text = new ReadV1Text(rawClient, server);
        SelfHostedV1DistributionCredentials = new SelfHostedV1DistributionCredentials(rawClient, server);
        SpeakV1Audio = new SpeakV1Audio(rawClient, server);
        SpeakV2Audio = new SpeakV2Audio(rawClient, server);
        VoiceAgentConfigurations = new VoiceAgentConfigurations(rawClient, server);
        VoiceAgentVariables = new VoiceAgentVariables(rawClient, server);
    }

    public AgentV1SettingsThinkModels AgentV1SettingsThinkModels { get; }

    public AuthV1Tokens AuthV1Tokens { get; }

    public ListenV1Media ListenV1Media { get; }

    public ManageV1Models ManageV1Models { get; }

    public ManageV1Projects ManageV1Projects { get; }

    public ManageV1ProjectsBillingBalances ManageV1ProjectsBillingBalances { get; }

    public ManageV1ProjectsBillingBreakdown ManageV1ProjectsBillingBreakdown { get; }

    public ManageV1ProjectsBillingFields ManageV1ProjectsBillingFields { get; }

    public ManageV1ProjectsBillingPurchases ManageV1ProjectsBillingPurchases { get; }

    public ManageV1ProjectsKeys ManageV1ProjectsKeys { get; }

    public ManageV1ProjectsMembers ManageV1ProjectsMembers { get; }

    public ManageV1ProjectsMembersInvites ManageV1ProjectsMembersInvites { get; }

    public ManageV1ProjectsMembersScopes ManageV1ProjectsMembersScopes { get; }

    public ManageV1ProjectsModels ManageV1ProjectsModels { get; }

    public ManageV1ProjectsRequests ManageV1ProjectsRequests { get; }

    public ManageV1ProjectsUsage ManageV1ProjectsUsage { get; }

    public ManageV1ProjectsUsageBreakdown ManageV1ProjectsUsageBreakdown { get; }

    public ManageV1ProjectsUsageFields ManageV1ProjectsUsageFields { get; }

    public ReadV1Text ReadV1Text { get; }

    public SelfHostedV1DistributionCredentials SelfHostedV1DistributionCredentials { get; }

    public SpeakV1Audio SpeakV1Audio { get; }

    public SpeakV2Audio SpeakV2Audio { get; }

    public VoiceAgentConfigurations VoiceAgentConfigurations { get; }

    public VoiceAgentVariables VoiceAgentVariables { get; }
}
