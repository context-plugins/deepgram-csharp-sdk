using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V1SpeakPostParametersSampleRateConverter))]
public record V1SpeakPostParametersSampleRate
{
    private readonly Optional<V1SpeakPostParametersSampleRate0> _v1SpeakPostParametersSampleRate0Value;

    private readonly Optional<V1SpeakPostParametersSampleRate1> _v1SpeakPostParametersSampleRate1Value;

    private readonly Optional<V1SpeakPostParametersSampleRate2> _v1SpeakPostParametersSampleRate2Value;

    private readonly Optional<V1SpeakPostParametersSampleRate3> _v1SpeakPostParametersSampleRate3Value;

    private readonly Optional<V1SpeakPostParametersSampleRate4> _v1SpeakPostParametersSampleRate4Value;

    private V1SpeakPostParametersSampleRate(Optional<V1SpeakPostParametersSampleRate0> v1SpeakPostParametersSampleRate0Value,
        Optional<V1SpeakPostParametersSampleRate1> v1SpeakPostParametersSampleRate1Value,
        Optional<V1SpeakPostParametersSampleRate2> v1SpeakPostParametersSampleRate2Value,
        Optional<V1SpeakPostParametersSampleRate3> v1SpeakPostParametersSampleRate3Value,
        Optional<V1SpeakPostParametersSampleRate4> v1SpeakPostParametersSampleRate4Value)
    {
        _v1SpeakPostParametersSampleRate0Value = v1SpeakPostParametersSampleRate0Value;
        _v1SpeakPostParametersSampleRate1Value = v1SpeakPostParametersSampleRate1Value;
        _v1SpeakPostParametersSampleRate2Value = v1SpeakPostParametersSampleRate2Value;
        _v1SpeakPostParametersSampleRate3Value = v1SpeakPostParametersSampleRate3Value;
        _v1SpeakPostParametersSampleRate4Value = v1SpeakPostParametersSampleRate4Value;
    }

    public static V1SpeakPostParametersSampleRate V1SpeakPostParametersSampleRate0(V1SpeakPostParametersSampleRate0 value) =>
        new(Optional<V1SpeakPostParametersSampleRate0>.Some(value), default, default, default, default);

    public static V1SpeakPostParametersSampleRate V1SpeakPostParametersSampleRate1(V1SpeakPostParametersSampleRate1 value) =>
        new(default, Optional<V1SpeakPostParametersSampleRate1>.Some(value), default, default, default);

    public static V1SpeakPostParametersSampleRate V1SpeakPostParametersSampleRate2(V1SpeakPostParametersSampleRate2 value) =>
        new(default, default, Optional<V1SpeakPostParametersSampleRate2>.Some(value), default, default);

    public static V1SpeakPostParametersSampleRate V1SpeakPostParametersSampleRate3(V1SpeakPostParametersSampleRate3 value) =>
        new(default, default, default, Optional<V1SpeakPostParametersSampleRate3>.Some(value), default);

    public static V1SpeakPostParametersSampleRate V1SpeakPostParametersSampleRate4(V1SpeakPostParametersSampleRate4 value) =>
        new(default, default, default, default, Optional<V1SpeakPostParametersSampleRate4>.Some(value));

    public bool TryGetV1SpeakPostParametersSampleRate0(out V1SpeakPostParametersSampleRate0 value) =>
        _v1SpeakPostParametersSampleRate0Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersSampleRate1(out V1SpeakPostParametersSampleRate1 value) =>
        _v1SpeakPostParametersSampleRate1Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersSampleRate2(out V1SpeakPostParametersSampleRate2 value) =>
        _v1SpeakPostParametersSampleRate2Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersSampleRate3(out V1SpeakPostParametersSampleRate3 value) =>
        _v1SpeakPostParametersSampleRate3Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersSampleRate4(out V1SpeakPostParametersSampleRate4 value) =>
        _v1SpeakPostParametersSampleRate4Value.TryGetValue(out value);

    public static implicit operator V1SpeakPostParametersSampleRate(V1SpeakPostParametersSampleRate0 value) =>
        V1SpeakPostParametersSampleRate0(value);

    public static implicit operator V1SpeakPostParametersSampleRate(V1SpeakPostParametersSampleRate1 value) =>
        V1SpeakPostParametersSampleRate1(value);

    public static implicit operator V1SpeakPostParametersSampleRate(V1SpeakPostParametersSampleRate2 value) =>
        V1SpeakPostParametersSampleRate2(value);

    public static implicit operator V1SpeakPostParametersSampleRate(V1SpeakPostParametersSampleRate3 value) =>
        V1SpeakPostParametersSampleRate3(value);

    public static implicit operator V1SpeakPostParametersSampleRate(V1SpeakPostParametersSampleRate4 value) =>
        V1SpeakPostParametersSampleRate4(value);
}

file sealed class V1SpeakPostParametersSampleRateConverter : JsonConverter<V1SpeakPostParametersSampleRate>
{
    public override V1SpeakPostParametersSampleRate Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersSampleRate0>(root,
            options,
            out var v1SpeakPostParametersSampleRate0Value))
        {
            return V1SpeakPostParametersSampleRate.V1SpeakPostParametersSampleRate0(v1SpeakPostParametersSampleRate0Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersSampleRate1>(root,
            options,
            out var v1SpeakPostParametersSampleRate1Value))
        {
            return V1SpeakPostParametersSampleRate.V1SpeakPostParametersSampleRate1(v1SpeakPostParametersSampleRate1Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersSampleRate2>(root,
            options,
            out var v1SpeakPostParametersSampleRate2Value))
        {
            return V1SpeakPostParametersSampleRate.V1SpeakPostParametersSampleRate2(v1SpeakPostParametersSampleRate2Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersSampleRate3>(root,
            options,
            out var v1SpeakPostParametersSampleRate3Value))
        {
            return V1SpeakPostParametersSampleRate.V1SpeakPostParametersSampleRate3(v1SpeakPostParametersSampleRate3Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersSampleRate4>(root,
            options,
            out var v1SpeakPostParametersSampleRate4Value))
        {
            return V1SpeakPostParametersSampleRate.V1SpeakPostParametersSampleRate4(v1SpeakPostParametersSampleRate4Value);
        }
        throw new JsonException($"JSON does not match V1SpeakPostParametersSampleRate0 or V1SpeakPostParametersSampleRate1 or V1SpeakPostParametersSampleRate2 or V1SpeakPostParametersSampleRate3 or V1SpeakPostParametersSampleRate4 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1SpeakPostParametersSampleRate value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1SpeakPostParametersSampleRate0(out var v1SpeakPostParametersSampleRate0Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersSampleRate0Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersSampleRate1(out var v1SpeakPostParametersSampleRate1Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersSampleRate1Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersSampleRate2(out var v1SpeakPostParametersSampleRate2Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersSampleRate2Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersSampleRate3(out var v1SpeakPostParametersSampleRate3Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersSampleRate3Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersSampleRate4(out var v1SpeakPostParametersSampleRate4Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersSampleRate4Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1SpeakPostParametersSampleRate)} contains no valid value to serialize.");
        }
    }
}
