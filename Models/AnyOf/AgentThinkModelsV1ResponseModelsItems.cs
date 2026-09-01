using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(AgentThinkModelsV1ResponseModelsItemsConverter))]
public record AgentThinkModelsV1ResponseModelsItems
{
    private readonly Optional<AgentThinkModelsV1ResponseModelsItems0> _agentThinkModelsV1ResponseModelsItems0Value;

    private readonly Optional<AgentThinkModelsV1ResponseModelsItems1> _agentThinkModelsV1ResponseModelsItems1Value;

    private readonly Optional<AgentThinkModelsV1ResponseModelsItems2> _agentThinkModelsV1ResponseModelsItems2Value;

    private readonly Optional<AgentThinkModelsV1ResponseModelsItems3> _agentThinkModelsV1ResponseModelsItems3Value;

    private readonly Optional<AgentThinkModelsV1ResponseModelsItems4> _agentThinkModelsV1ResponseModelsItems4Value;

    private AgentThinkModelsV1ResponseModelsItems(Optional<AgentThinkModelsV1ResponseModelsItems0> agentThinkModelsV1ResponseModelsItems0Value,
        Optional<AgentThinkModelsV1ResponseModelsItems1> agentThinkModelsV1ResponseModelsItems1Value,
        Optional<AgentThinkModelsV1ResponseModelsItems2> agentThinkModelsV1ResponseModelsItems2Value,
        Optional<AgentThinkModelsV1ResponseModelsItems3> agentThinkModelsV1ResponseModelsItems3Value,
        Optional<AgentThinkModelsV1ResponseModelsItems4> agentThinkModelsV1ResponseModelsItems4Value)
    {
        _agentThinkModelsV1ResponseModelsItems0Value = agentThinkModelsV1ResponseModelsItems0Value;
        _agentThinkModelsV1ResponseModelsItems1Value = agentThinkModelsV1ResponseModelsItems1Value;
        _agentThinkModelsV1ResponseModelsItems2Value = agentThinkModelsV1ResponseModelsItems2Value;
        _agentThinkModelsV1ResponseModelsItems3Value = agentThinkModelsV1ResponseModelsItems3Value;
        _agentThinkModelsV1ResponseModelsItems4Value = agentThinkModelsV1ResponseModelsItems4Value;
    }

    public static AgentThinkModelsV1ResponseModelsItems AgentThinkModelsV1ResponseModelsItems0(AgentThinkModelsV1ResponseModelsItems0 value) =>
        new(Optional<AgentThinkModelsV1ResponseModelsItems0>.Some(value), default, default, default, default);

    public static AgentThinkModelsV1ResponseModelsItems AgentThinkModelsV1ResponseModelsItems1(AgentThinkModelsV1ResponseModelsItems1 value) =>
        new(default, Optional<AgentThinkModelsV1ResponseModelsItems1>.Some(value), default, default, default);

    public static AgentThinkModelsV1ResponseModelsItems AgentThinkModelsV1ResponseModelsItems2(AgentThinkModelsV1ResponseModelsItems2 value) =>
        new(default, default, Optional<AgentThinkModelsV1ResponseModelsItems2>.Some(value), default, default);

    public static AgentThinkModelsV1ResponseModelsItems AgentThinkModelsV1ResponseModelsItems3(AgentThinkModelsV1ResponseModelsItems3 value) =>
        new(default, default, default, Optional<AgentThinkModelsV1ResponseModelsItems3>.Some(value), default);

    public static AgentThinkModelsV1ResponseModelsItems AgentThinkModelsV1ResponseModelsItems4(AgentThinkModelsV1ResponseModelsItems4 value) =>
        new(default, default, default, default, Optional<AgentThinkModelsV1ResponseModelsItems4>.Some(value));

    public bool TryGetAgentThinkModelsV1ResponseModelsItems0(out AgentThinkModelsV1ResponseModelsItems0 value) =>
        _agentThinkModelsV1ResponseModelsItems0Value.TryGetValue(out value);

    public bool TryGetAgentThinkModelsV1ResponseModelsItems1(out AgentThinkModelsV1ResponseModelsItems1 value) =>
        _agentThinkModelsV1ResponseModelsItems1Value.TryGetValue(out value);

    public bool TryGetAgentThinkModelsV1ResponseModelsItems2(out AgentThinkModelsV1ResponseModelsItems2 value) =>
        _agentThinkModelsV1ResponseModelsItems2Value.TryGetValue(out value);

    public bool TryGetAgentThinkModelsV1ResponseModelsItems3(out AgentThinkModelsV1ResponseModelsItems3 value) =>
        _agentThinkModelsV1ResponseModelsItems3Value.TryGetValue(out value);

    public bool TryGetAgentThinkModelsV1ResponseModelsItems4(out AgentThinkModelsV1ResponseModelsItems4 value) =>
        _agentThinkModelsV1ResponseModelsItems4Value.TryGetValue(out value);

    public static implicit operator AgentThinkModelsV1ResponseModelsItems(AgentThinkModelsV1ResponseModelsItems0 value) =>
        AgentThinkModelsV1ResponseModelsItems0(value);

    public static implicit operator AgentThinkModelsV1ResponseModelsItems(AgentThinkModelsV1ResponseModelsItems1 value) =>
        AgentThinkModelsV1ResponseModelsItems1(value);

    public static implicit operator AgentThinkModelsV1ResponseModelsItems(AgentThinkModelsV1ResponseModelsItems2 value) =>
        AgentThinkModelsV1ResponseModelsItems2(value);

    public static implicit operator AgentThinkModelsV1ResponseModelsItems(AgentThinkModelsV1ResponseModelsItems3 value) =>
        AgentThinkModelsV1ResponseModelsItems3(value);

    public static implicit operator AgentThinkModelsV1ResponseModelsItems(AgentThinkModelsV1ResponseModelsItems4 value) =>
        AgentThinkModelsV1ResponseModelsItems4(value);
}

file sealed class AgentThinkModelsV1ResponseModelsItemsConverter : JsonConverter<AgentThinkModelsV1ResponseModelsItems>
{
    public override AgentThinkModelsV1ResponseModelsItems Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AgentThinkModelsV1ResponseModelsItems0>(root,
            options,
            out var agentThinkModelsV1ResponseModelsItems0Value))
        {
            return AgentThinkModelsV1ResponseModelsItems.AgentThinkModelsV1ResponseModelsItems0(agentThinkModelsV1ResponseModelsItems0Value);
        }
        if (JsonSerializer.TryDeserialize<AgentThinkModelsV1ResponseModelsItems1>(root,
            options,
            out var agentThinkModelsV1ResponseModelsItems1Value))
        {
            return AgentThinkModelsV1ResponseModelsItems.AgentThinkModelsV1ResponseModelsItems1(agentThinkModelsV1ResponseModelsItems1Value);
        }
        if (JsonSerializer.TryDeserialize<AgentThinkModelsV1ResponseModelsItems2>(root,
            options,
            out var agentThinkModelsV1ResponseModelsItems2Value))
        {
            return AgentThinkModelsV1ResponseModelsItems.AgentThinkModelsV1ResponseModelsItems2(agentThinkModelsV1ResponseModelsItems2Value);
        }
        if (JsonSerializer.TryDeserialize<AgentThinkModelsV1ResponseModelsItems3>(root,
            options,
            out var agentThinkModelsV1ResponseModelsItems3Value))
        {
            return AgentThinkModelsV1ResponseModelsItems.AgentThinkModelsV1ResponseModelsItems3(agentThinkModelsV1ResponseModelsItems3Value);
        }
        if (JsonSerializer.TryDeserialize<AgentThinkModelsV1ResponseModelsItems4>(root,
            options,
            out var agentThinkModelsV1ResponseModelsItems4Value))
        {
            return AgentThinkModelsV1ResponseModelsItems.AgentThinkModelsV1ResponseModelsItems4(agentThinkModelsV1ResponseModelsItems4Value);
        }
        throw new JsonException($"JSON does not match AgentThinkModelsV1ResponseModelsItems0 or AgentThinkModelsV1ResponseModelsItems1 or AgentThinkModelsV1ResponseModelsItems2 or AgentThinkModelsV1ResponseModelsItems3 or AgentThinkModelsV1ResponseModelsItems4 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AgentThinkModelsV1ResponseModelsItems value,
        JsonSerializerOptions options)
    {
        if (value.TryGetAgentThinkModelsV1ResponseModelsItems0(out var agentThinkModelsV1ResponseModelsItems0Value))
        {
            JsonSerializer.Serialize(writer, agentThinkModelsV1ResponseModelsItems0Value, options);
        }
        else if (value.TryGetAgentThinkModelsV1ResponseModelsItems1(out var agentThinkModelsV1ResponseModelsItems1Value))
        {
            JsonSerializer.Serialize(writer, agentThinkModelsV1ResponseModelsItems1Value, options);
        }
        else if (value.TryGetAgentThinkModelsV1ResponseModelsItems2(out var agentThinkModelsV1ResponseModelsItems2Value))
        {
            JsonSerializer.Serialize(writer, agentThinkModelsV1ResponseModelsItems2Value, options);
        }
        else if (value.TryGetAgentThinkModelsV1ResponseModelsItems3(out var agentThinkModelsV1ResponseModelsItems3Value))
        {
            JsonSerializer.Serialize(writer, agentThinkModelsV1ResponseModelsItems3Value, options);
        }
        else if (value.TryGetAgentThinkModelsV1ResponseModelsItems4(out var agentThinkModelsV1ResponseModelsItems4Value))
        {
            JsonSerializer.Serialize(writer, agentThinkModelsV1ResponseModelsItems4Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(AgentThinkModelsV1ResponseModelsItems)} contains no valid value to serialize.");
        }
    }
}
