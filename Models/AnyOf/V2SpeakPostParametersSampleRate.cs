using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Models.Enums;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V2SpeakPostParametersSampleRateConverter))]
public record V2SpeakPostParametersSampleRate
{
    private readonly Optional<V2SpeakPostParametersSampleRate0> _v2SpeakPostParametersSampleRate0Value;

    private readonly Optional<V2SpeakPostParametersSampleRate1> _v2SpeakPostParametersSampleRate1Value;

    private readonly Optional<V2SpeakPostParametersSampleRate2> _v2SpeakPostParametersSampleRate2Value;

    private readonly Optional<V2SpeakPostParametersSampleRate3> _v2SpeakPostParametersSampleRate3Value;

    private V2SpeakPostParametersSampleRate(Optional<V2SpeakPostParametersSampleRate0> v2SpeakPostParametersSampleRate0Value,
        Optional<V2SpeakPostParametersSampleRate1> v2SpeakPostParametersSampleRate1Value,
        Optional<V2SpeakPostParametersSampleRate2> v2SpeakPostParametersSampleRate2Value,
        Optional<V2SpeakPostParametersSampleRate3> v2SpeakPostParametersSampleRate3Value)
    {
        _v2SpeakPostParametersSampleRate0Value = v2SpeakPostParametersSampleRate0Value;
        _v2SpeakPostParametersSampleRate1Value = v2SpeakPostParametersSampleRate1Value;
        _v2SpeakPostParametersSampleRate2Value = v2SpeakPostParametersSampleRate2Value;
        _v2SpeakPostParametersSampleRate3Value = v2SpeakPostParametersSampleRate3Value;
    }

    public static V2SpeakPostParametersSampleRate V2SpeakPostParametersSampleRate0(V2SpeakPostParametersSampleRate0 value) =>
        new(Optional<V2SpeakPostParametersSampleRate0>.Some(value), default, default, default);

    public static V2SpeakPostParametersSampleRate V2SpeakPostParametersSampleRate1(V2SpeakPostParametersSampleRate1 value) =>
        new(default, Optional<V2SpeakPostParametersSampleRate1>.Some(value), default, default);

    public static V2SpeakPostParametersSampleRate V2SpeakPostParametersSampleRate2(V2SpeakPostParametersSampleRate2 value) =>
        new(default, default, Optional<V2SpeakPostParametersSampleRate2>.Some(value), default);

    public static V2SpeakPostParametersSampleRate V2SpeakPostParametersSampleRate3(V2SpeakPostParametersSampleRate3 value) =>
        new(default, default, default, Optional<V2SpeakPostParametersSampleRate3>.Some(value));

    public bool TryGetV2SpeakPostParametersSampleRate0(out V2SpeakPostParametersSampleRate0 value) =>
        _v2SpeakPostParametersSampleRate0Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersSampleRate1(out V2SpeakPostParametersSampleRate1 value) =>
        _v2SpeakPostParametersSampleRate1Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersSampleRate2(out V2SpeakPostParametersSampleRate2 value) =>
        _v2SpeakPostParametersSampleRate2Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersSampleRate3(out V2SpeakPostParametersSampleRate3 value) =>
        _v2SpeakPostParametersSampleRate3Value.TryGetValue(out value);

    public static implicit operator V2SpeakPostParametersSampleRate(V2SpeakPostParametersSampleRate0 value) =>
        V2SpeakPostParametersSampleRate0(value);

    public static implicit operator V2SpeakPostParametersSampleRate(V2SpeakPostParametersSampleRate1 value) =>
        V2SpeakPostParametersSampleRate1(value);

    public static implicit operator V2SpeakPostParametersSampleRate(V2SpeakPostParametersSampleRate2 value) =>
        V2SpeakPostParametersSampleRate2(value);

    public static implicit operator V2SpeakPostParametersSampleRate(V2SpeakPostParametersSampleRate3 value) =>
        V2SpeakPostParametersSampleRate3(value);
}

file sealed class V2SpeakPostParametersSampleRateConverter : JsonConverter<V2SpeakPostParametersSampleRate>
{
    public override V2SpeakPostParametersSampleRate Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersSampleRate0>(root,
            options,
            out var v2SpeakPostParametersSampleRate0Value))
        {
            return V2SpeakPostParametersSampleRate.V2SpeakPostParametersSampleRate0(v2SpeakPostParametersSampleRate0Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersSampleRate1>(root,
            options,
            out var v2SpeakPostParametersSampleRate1Value))
        {
            return V2SpeakPostParametersSampleRate.V2SpeakPostParametersSampleRate1(v2SpeakPostParametersSampleRate1Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersSampleRate2>(root,
            options,
            out var v2SpeakPostParametersSampleRate2Value))
        {
            return V2SpeakPostParametersSampleRate.V2SpeakPostParametersSampleRate2(v2SpeakPostParametersSampleRate2Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersSampleRate3>(root,
            options,
            out var v2SpeakPostParametersSampleRate3Value))
        {
            return V2SpeakPostParametersSampleRate.V2SpeakPostParametersSampleRate3(v2SpeakPostParametersSampleRate3Value);
        }
        throw new JsonException($"JSON does not match V2SpeakPostParametersSampleRate0 or V2SpeakPostParametersSampleRate1 or V2SpeakPostParametersSampleRate2 or V2SpeakPostParametersSampleRate3 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V2SpeakPostParametersSampleRate value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV2SpeakPostParametersSampleRate0(out var v2SpeakPostParametersSampleRate0Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersSampleRate0Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersSampleRate1(out var v2SpeakPostParametersSampleRate1Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersSampleRate1Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersSampleRate2(out var v2SpeakPostParametersSampleRate2Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersSampleRate2Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersSampleRate3(out var v2SpeakPostParametersSampleRate3Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersSampleRate3Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(V2SpeakPostParametersSampleRate)} contains no valid value to serialize.");
        }
    }
}
