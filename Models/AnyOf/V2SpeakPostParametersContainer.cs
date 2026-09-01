using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V2SpeakPostParametersContainerConverter))]
public record V2SpeakPostParametersContainer
{
    private readonly Optional<V2SpeakPostParametersContainer0> _v2SpeakPostParametersContainer0Value;

    private readonly Optional<V2SpeakPostParametersContainer1> _v2SpeakPostParametersContainer1Value;

    private readonly Optional<V2SpeakPostParametersContainer2> _v2SpeakPostParametersContainer2Value;

    private readonly Optional<V2SpeakPostParametersContainer3> _v2SpeakPostParametersContainer3Value;

    private readonly Optional<V2SpeakPostParametersContainer4> _v2SpeakPostParametersContainer4Value;

    private V2SpeakPostParametersContainer(Optional<V2SpeakPostParametersContainer0> v2SpeakPostParametersContainer0Value,
        Optional<V2SpeakPostParametersContainer1> v2SpeakPostParametersContainer1Value,
        Optional<V2SpeakPostParametersContainer2> v2SpeakPostParametersContainer2Value,
        Optional<V2SpeakPostParametersContainer3> v2SpeakPostParametersContainer3Value,
        Optional<V2SpeakPostParametersContainer4> v2SpeakPostParametersContainer4Value)
    {
        _v2SpeakPostParametersContainer0Value = v2SpeakPostParametersContainer0Value;
        _v2SpeakPostParametersContainer1Value = v2SpeakPostParametersContainer1Value;
        _v2SpeakPostParametersContainer2Value = v2SpeakPostParametersContainer2Value;
        _v2SpeakPostParametersContainer3Value = v2SpeakPostParametersContainer3Value;
        _v2SpeakPostParametersContainer4Value = v2SpeakPostParametersContainer4Value;
    }

    public static V2SpeakPostParametersContainer V2SpeakPostParametersContainer0(V2SpeakPostParametersContainer0 value) =>
        new(Optional<V2SpeakPostParametersContainer0>.Some(value), default, default, default, default);

    public static V2SpeakPostParametersContainer V2SpeakPostParametersContainer1(V2SpeakPostParametersContainer1 value) =>
        new(default, Optional<V2SpeakPostParametersContainer1>.Some(value), default, default, default);

    public static V2SpeakPostParametersContainer V2SpeakPostParametersContainer2(V2SpeakPostParametersContainer2 value) =>
        new(default, default, Optional<V2SpeakPostParametersContainer2>.Some(value), default, default);

    public static V2SpeakPostParametersContainer V2SpeakPostParametersContainer3(V2SpeakPostParametersContainer3 value) =>
        new(default, default, default, Optional<V2SpeakPostParametersContainer3>.Some(value), default);

    public static V2SpeakPostParametersContainer V2SpeakPostParametersContainer4(V2SpeakPostParametersContainer4 value) =>
        new(default, default, default, default, Optional<V2SpeakPostParametersContainer4>.Some(value));

    public bool TryGetV2SpeakPostParametersContainer0(out V2SpeakPostParametersContainer0 value) =>
        _v2SpeakPostParametersContainer0Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersContainer1(out V2SpeakPostParametersContainer1 value) =>
        _v2SpeakPostParametersContainer1Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersContainer2(out V2SpeakPostParametersContainer2 value) =>
        _v2SpeakPostParametersContainer2Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersContainer3(out V2SpeakPostParametersContainer3 value) =>
        _v2SpeakPostParametersContainer3Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersContainer4(out V2SpeakPostParametersContainer4 value) =>
        _v2SpeakPostParametersContainer4Value.TryGetValue(out value);

    public static implicit operator V2SpeakPostParametersContainer(V2SpeakPostParametersContainer0 value) =>
        V2SpeakPostParametersContainer0(value);

    public static implicit operator V2SpeakPostParametersContainer(V2SpeakPostParametersContainer1 value) =>
        V2SpeakPostParametersContainer1(value);

    public static implicit operator V2SpeakPostParametersContainer(V2SpeakPostParametersContainer2 value) =>
        V2SpeakPostParametersContainer2(value);

    public static implicit operator V2SpeakPostParametersContainer(V2SpeakPostParametersContainer3 value) =>
        V2SpeakPostParametersContainer3(value);

    public static implicit operator V2SpeakPostParametersContainer(V2SpeakPostParametersContainer4 value) =>
        V2SpeakPostParametersContainer4(value);
}

file sealed class V2SpeakPostParametersContainerConverter : JsonConverter<V2SpeakPostParametersContainer>
{
    public override V2SpeakPostParametersContainer Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersContainer0>(root,
            options,
            out var v2SpeakPostParametersContainer0Value))
        {
            return V2SpeakPostParametersContainer.V2SpeakPostParametersContainer0(v2SpeakPostParametersContainer0Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersContainer1>(root,
            options,
            out var v2SpeakPostParametersContainer1Value))
        {
            return V2SpeakPostParametersContainer.V2SpeakPostParametersContainer1(v2SpeakPostParametersContainer1Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersContainer2>(root,
            options,
            out var v2SpeakPostParametersContainer2Value))
        {
            return V2SpeakPostParametersContainer.V2SpeakPostParametersContainer2(v2SpeakPostParametersContainer2Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersContainer3>(root,
            options,
            out var v2SpeakPostParametersContainer3Value))
        {
            return V2SpeakPostParametersContainer.V2SpeakPostParametersContainer3(v2SpeakPostParametersContainer3Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersContainer4>(root,
            options,
            out var v2SpeakPostParametersContainer4Value))
        {
            return V2SpeakPostParametersContainer.V2SpeakPostParametersContainer4(v2SpeakPostParametersContainer4Value);
        }
        throw new JsonException($"JSON does not match V2SpeakPostParametersContainer0 or V2SpeakPostParametersContainer1 or V2SpeakPostParametersContainer2 or V2SpeakPostParametersContainer3 or V2SpeakPostParametersContainer4 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V2SpeakPostParametersContainer value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV2SpeakPostParametersContainer0(out var v2SpeakPostParametersContainer0Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersContainer0Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersContainer1(out var v2SpeakPostParametersContainer1Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersContainer1Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersContainer2(out var v2SpeakPostParametersContainer2Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersContainer2Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersContainer3(out var v2SpeakPostParametersContainer3Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersContainer3Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersContainer4(out var v2SpeakPostParametersContainer4Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersContainer4Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(V2SpeakPostParametersContainer)} contains no valid value to serialize.");
        }
    }
}
