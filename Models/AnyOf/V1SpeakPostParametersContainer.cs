using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V1SpeakPostParametersContainerConverter))]
public record V1SpeakPostParametersContainer
{
    private readonly Optional<V1SpeakPostParametersContainer0> _v1SpeakPostParametersContainer0Value;

    private readonly Optional<V1SpeakPostParametersContainer1> _v1SpeakPostParametersContainer1Value;

    private readonly Optional<V1SpeakPostParametersContainer2> _v1SpeakPostParametersContainer2Value;

    private readonly Optional<V1SpeakPostParametersContainer3> _v1SpeakPostParametersContainer3Value;

    private readonly Optional<V1SpeakPostParametersContainer4> _v1SpeakPostParametersContainer4Value;

    private V1SpeakPostParametersContainer(Optional<V1SpeakPostParametersContainer0> v1SpeakPostParametersContainer0Value,
        Optional<V1SpeakPostParametersContainer1> v1SpeakPostParametersContainer1Value,
        Optional<V1SpeakPostParametersContainer2> v1SpeakPostParametersContainer2Value,
        Optional<V1SpeakPostParametersContainer3> v1SpeakPostParametersContainer3Value,
        Optional<V1SpeakPostParametersContainer4> v1SpeakPostParametersContainer4Value)
    {
        _v1SpeakPostParametersContainer0Value = v1SpeakPostParametersContainer0Value;
        _v1SpeakPostParametersContainer1Value = v1SpeakPostParametersContainer1Value;
        _v1SpeakPostParametersContainer2Value = v1SpeakPostParametersContainer2Value;
        _v1SpeakPostParametersContainer3Value = v1SpeakPostParametersContainer3Value;
        _v1SpeakPostParametersContainer4Value = v1SpeakPostParametersContainer4Value;
    }

    public static V1SpeakPostParametersContainer V1SpeakPostParametersContainer0(V1SpeakPostParametersContainer0 value) =>
        new(Optional<V1SpeakPostParametersContainer0>.Some(value), default, default, default, default);

    public static V1SpeakPostParametersContainer V1SpeakPostParametersContainer1(V1SpeakPostParametersContainer1 value) =>
        new(default, Optional<V1SpeakPostParametersContainer1>.Some(value), default, default, default);

    public static V1SpeakPostParametersContainer V1SpeakPostParametersContainer2(V1SpeakPostParametersContainer2 value) =>
        new(default, default, Optional<V1SpeakPostParametersContainer2>.Some(value), default, default);

    public static V1SpeakPostParametersContainer V1SpeakPostParametersContainer3(V1SpeakPostParametersContainer3 value) =>
        new(default, default, default, Optional<V1SpeakPostParametersContainer3>.Some(value), default);

    public static V1SpeakPostParametersContainer V1SpeakPostParametersContainer4(V1SpeakPostParametersContainer4 value) =>
        new(default, default, default, default, Optional<V1SpeakPostParametersContainer4>.Some(value));

    public bool TryGetV1SpeakPostParametersContainer0(out V1SpeakPostParametersContainer0 value) =>
        _v1SpeakPostParametersContainer0Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersContainer1(out V1SpeakPostParametersContainer1 value) =>
        _v1SpeakPostParametersContainer1Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersContainer2(out V1SpeakPostParametersContainer2 value) =>
        _v1SpeakPostParametersContainer2Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersContainer3(out V1SpeakPostParametersContainer3 value) =>
        _v1SpeakPostParametersContainer3Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersContainer4(out V1SpeakPostParametersContainer4 value) =>
        _v1SpeakPostParametersContainer4Value.TryGetValue(out value);

    public static implicit operator V1SpeakPostParametersContainer(V1SpeakPostParametersContainer0 value) =>
        V1SpeakPostParametersContainer0(value);

    public static implicit operator V1SpeakPostParametersContainer(V1SpeakPostParametersContainer1 value) =>
        V1SpeakPostParametersContainer1(value);

    public static implicit operator V1SpeakPostParametersContainer(V1SpeakPostParametersContainer2 value) =>
        V1SpeakPostParametersContainer2(value);

    public static implicit operator V1SpeakPostParametersContainer(V1SpeakPostParametersContainer3 value) =>
        V1SpeakPostParametersContainer3(value);

    public static implicit operator V1SpeakPostParametersContainer(V1SpeakPostParametersContainer4 value) =>
        V1SpeakPostParametersContainer4(value);
}

file sealed class V1SpeakPostParametersContainerConverter : JsonConverter<V1SpeakPostParametersContainer>
{
    public override V1SpeakPostParametersContainer Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersContainer0>(root,
            options,
            out var v1SpeakPostParametersContainer0Value))
        {
            return V1SpeakPostParametersContainer.V1SpeakPostParametersContainer0(v1SpeakPostParametersContainer0Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersContainer1>(root,
            options,
            out var v1SpeakPostParametersContainer1Value))
        {
            return V1SpeakPostParametersContainer.V1SpeakPostParametersContainer1(v1SpeakPostParametersContainer1Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersContainer2>(root,
            options,
            out var v1SpeakPostParametersContainer2Value))
        {
            return V1SpeakPostParametersContainer.V1SpeakPostParametersContainer2(v1SpeakPostParametersContainer2Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersContainer3>(root,
            options,
            out var v1SpeakPostParametersContainer3Value))
        {
            return V1SpeakPostParametersContainer.V1SpeakPostParametersContainer3(v1SpeakPostParametersContainer3Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersContainer4>(root,
            options,
            out var v1SpeakPostParametersContainer4Value))
        {
            return V1SpeakPostParametersContainer.V1SpeakPostParametersContainer4(v1SpeakPostParametersContainer4Value);
        }
        throw new JsonException($"JSON does not match V1SpeakPostParametersContainer0 or V1SpeakPostParametersContainer1 or V1SpeakPostParametersContainer2 or V1SpeakPostParametersContainer3 or V1SpeakPostParametersContainer4 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1SpeakPostParametersContainer value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1SpeakPostParametersContainer0(out var v1SpeakPostParametersContainer0Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersContainer0Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersContainer1(out var v1SpeakPostParametersContainer1Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersContainer1Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersContainer2(out var v1SpeakPostParametersContainer2Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersContainer2Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersContainer3(out var v1SpeakPostParametersContainer3Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersContainer3Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersContainer4(out var v1SpeakPostParametersContainer4Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersContainer4Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1SpeakPostParametersContainer)} contains no valid value to serialize.");
        }
    }
}
