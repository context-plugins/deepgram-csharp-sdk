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
        var auth = new AuthSchemes(options);
        AgentV1SettingsThinkModels = new AgentV1SettingsThinkModels(rawClient, server, auth);
        AuthV1Tokens = new AuthV1Tokens(rawClient, server, auth);
        ListenV1Media = new ListenV1Media(rawClient, server, auth);
        ManageV1Models = new ManageV1Models(rawClient, server, auth);
        ManageV1Projects = new ManageV1Projects(rawClient, server, auth);
        ManageV1ProjectsBillingBalances = new ManageV1ProjectsBillingBalances(rawClient, server, auth);
        ManageV1ProjectsBillingBreakdown = new ManageV1ProjectsBillingBreakdown(rawClient, server, auth);
        ManageV1ProjectsBillingFields = new ManageV1ProjectsBillingFields(rawClient, server, auth);
        ManageV1ProjectsBillingPurchases = new ManageV1ProjectsBillingPurchases(rawClient, server, auth);
        ManageV1ProjectsKeys = new ManageV1ProjectsKeys(rawClient, server, auth);
        ManageV1ProjectsMembers = new ManageV1ProjectsMembers(rawClient, server, auth);
        ManageV1ProjectsMembersInvites = new ManageV1ProjectsMembersInvites(rawClient, server, auth);
        ManageV1ProjectsMembersScopes = new ManageV1ProjectsMembersScopes(rawClient, server, auth);
        ManageV1ProjectsModels = new ManageV1ProjectsModels(rawClient, server, auth);
        ManageV1ProjectsRequests = new ManageV1ProjectsRequests(rawClient, server, auth);
        ManageV1ProjectsUsage = new ManageV1ProjectsUsage(rawClient, server, auth);
        ManageV1ProjectsUsageBreakdown = new ManageV1ProjectsUsageBreakdown(rawClient, server, auth);
        ManageV1ProjectsUsageFields = new ManageV1ProjectsUsageFields(rawClient, server, auth);
        ReadV1Text = new ReadV1Text(rawClient, server, auth);
        SelfHostedV1DistributionCredentials = new SelfHostedV1DistributionCredentials(rawClient, server, auth);
        SpeakV1Audio = new SpeakV1Audio(rawClient, server, auth);
        SpeakV2Audio = new SpeakV2Audio(rawClient, server, auth);
        VoiceAgentConfigurations = new VoiceAgentConfigurations(rawClient, server, auth);
        VoiceAgentVariables = new VoiceAgentVariables(rawClient, server, auth);
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
