using System.Net.Http;
using Deepgram.Api;
using Deepgram.Core;
using Deepgram.Core.Logging;
using Deepgram.Core.Models;

namespace Deepgram;

public sealed class DeepgramClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public DeepgramClient(HttpClient httpClient, DeepgramClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "DeepgramClient/1.0.0 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "1.0.0"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "DeepgramClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    public AgentV1SettingsThinkModels AgentV1SettingsThinkModels =>
        field ??= new AgentV1SettingsThinkModels(_rawClient, _server, _auth);

    public AuthV1Tokens AuthV1Tokens => field ??= new AuthV1Tokens(_rawClient, _server, _auth);

    public ListenV1Media ListenV1Media => field ??= new ListenV1Media(_rawClient, _server, _auth);

    public ManageV1Models ManageV1Models => field ??= new ManageV1Models(_rawClient, _server, _auth);

    public ManageV1Projects ManageV1Projects => field ??= new ManageV1Projects(_rawClient, _server, _auth);

    public ManageV1ProjectsBillingBalances ManageV1ProjectsBillingBalances =>
        field ??= new ManageV1ProjectsBillingBalances(_rawClient, _server, _auth);

    public ManageV1ProjectsBillingBreakdown ManageV1ProjectsBillingBreakdown =>
        field ??= new ManageV1ProjectsBillingBreakdown(_rawClient, _server, _auth);

    public ManageV1ProjectsBillingFields ManageV1ProjectsBillingFields =>
        field ??= new ManageV1ProjectsBillingFields(_rawClient, _server, _auth);

    public ManageV1ProjectsBillingPurchases ManageV1ProjectsBillingPurchases =>
        field ??= new ManageV1ProjectsBillingPurchases(_rawClient, _server, _auth);

    public ManageV1ProjectsKeys ManageV1ProjectsKeys => field ??= new ManageV1ProjectsKeys(_rawClient, _server, _auth);

    public ManageV1ProjectsMembers ManageV1ProjectsMembers =>
        field ??= new ManageV1ProjectsMembers(_rawClient, _server, _auth);

    public ManageV1ProjectsMembersInvites ManageV1ProjectsMembersInvites =>
        field ??= new ManageV1ProjectsMembersInvites(_rawClient, _server, _auth);

    public ManageV1ProjectsMembersScopes ManageV1ProjectsMembersScopes =>
        field ??= new ManageV1ProjectsMembersScopes(_rawClient, _server, _auth);

    public ManageV1ProjectsModels ManageV1ProjectsModels =>
        field ??= new ManageV1ProjectsModels(_rawClient, _server, _auth);

    public ManageV1ProjectsRequests ManageV1ProjectsRequests =>
        field ??= new ManageV1ProjectsRequests(_rawClient, _server, _auth);

    public ManageV1ProjectsUsage ManageV1ProjectsUsage =>
        field ??= new ManageV1ProjectsUsage(_rawClient, _server, _auth);

    public ManageV1ProjectsUsageBreakdown ManageV1ProjectsUsageBreakdown =>
        field ??= new ManageV1ProjectsUsageBreakdown(_rawClient, _server, _auth);

    public ManageV1ProjectsUsageFields ManageV1ProjectsUsageFields =>
        field ??= new ManageV1ProjectsUsageFields(_rawClient, _server, _auth);

    public ReadV1Text ReadV1Text => field ??= new ReadV1Text(_rawClient, _server, _auth);

    public SelfHostedV1DistributionCredentials SelfHostedV1DistributionCredentials =>
        field ??= new SelfHostedV1DistributionCredentials(_rawClient, _server, _auth);

    public SpeakV1Audio SpeakV1Audio => field ??= new SpeakV1Audio(_rawClient, _server, _auth);

    public SpeakV2Audio SpeakV2Audio => field ??= new SpeakV2Audio(_rawClient, _server, _auth);

    public VoiceAgentConfigurations VoiceAgentConfigurations =>
        field ??= new VoiceAgentConfigurations(_rawClient, _server, _auth);

    public VoiceAgentVariables VoiceAgentVariables => field ??= new VoiceAgentVariables(_rawClient, _server, _auth);
}
