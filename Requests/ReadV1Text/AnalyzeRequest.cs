using Deepgram.Models.AnyOf;
using Deepgram.Models.Enums;

namespace Deepgram.Requests.ReadV1Text;

/// <summary>
/// The inputs of the Analyze operation.
/// </summary>
public sealed record AnalyzeRequest
{
    /// <summary>
    /// URL to which we'll make the callback request
    /// </summary>
    public string? Callback { get; init; }

    /// <summary>
    /// HTTP method by which the callback request will be made
    /// </summary>
    public V1ListenPostParametersCallbackMethod CallbackMethod { get; init; } = V1ListenPostParametersCallbackMethod.Post;

    /// <summary>
    /// Recognizes the sentiment throughout a transcript or text
    /// </summary>
    public bool Sentiment { get; init; } = false;

    /// <summary>
    /// Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only.
    /// </summary>
    public V1ReadPostParametersSummarize? Summarize { get; init; }

    /// <summary>
    /// Label your requests for the purpose of identification during usage reporting
    /// </summary>
    public V1ReadPostParametersTag? Tag { get; init; }

    /// <summary>
    /// Detect topics throughout a transcript or text
    /// </summary>
    public bool Topics { get; init; } = false;

    /// <summary>
    /// Custom topics you want the model to detect within your input audio or text if present Submit up to <c>100</c>.
    /// </summary>
    public V1ReadPostParametersCustomTopic? CustomTopic { get; init; }

    /// <summary>
    /// Sets how the model will interpret strings submitted to the <c>custom_topic</c> param. When <c>strict</c>, the model will only return topics submitted using the <c>custom_topic</c> param. When <c>extended</c>, the model will return its own detected topics in addition to those submitted using the <c>custom_topic</c> param
    /// </summary>
    public V1ListenPostParametersCustomTopicMode CustomTopicMode { get; init; } = V1ListenPostParametersCustomTopicMode.Extended;

    /// <summary>
    /// Recognizes speaker intent throughout a transcript or text
    /// </summary>
    public bool Intents { get; init; } = false;

    /// <summary>
    /// Custom intents you want the model to detect within your input audio if present
    /// </summary>
    public V1ReadPostParametersCustomIntent? CustomIntent { get; init; }

    /// <summary>
    /// Sets how the model will interpret intents submitted to the <c>custom_intent</c> param. When <c>strict</c>, the model will only return intents submitted using the <c>custom_intent</c> param. When <c>extended</c>, the model will return its own detected intents in the <c>custom_intent</c> param.
    /// </summary>
    public V1ListenPostParametersCustomTopicMode CustomIntentMode { get; init; } = V1ListenPostParametersCustomTopicMode.Extended;

    /// <summary>
    /// The <see href="https://tools.ietf.org/html/bcp47">BCP-47 language tag</see> that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available
    /// </summary>
    public string Language { get; init; } = "en";

    /// <summary>
    /// Analyze a text file
    /// </summary>
    public ReadV1Request? Body { get; init; }
}
