using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V1SpeakPostParametersBitRateConverter))]
public record V1SpeakPostParametersBitRate
{
    private readonly Optional<V1SpeakPostParametersBitRate0> _v1SpeakPostParametersBitRate0Value;

    private readonly Optional<double> _doubleValue;

    private V1SpeakPostParametersBitRate(Optional<V1SpeakPostParametersBitRate0> v1SpeakPostParametersBitRate0Value,
        Optional<double> doubleValue)
    {
        _v1SpeakPostParametersBitRate0Value = v1SpeakPostParametersBitRate0Value;
        _doubleValue = doubleValue;
    }

    public static V1SpeakPostParametersBitRate V1SpeakPostParametersBitRate0(V1SpeakPostParametersBitRate0 value) =>
        new(Optional<V1SpeakPostParametersBitRate0>.Some(value), default);

    public static V1SpeakPostParametersBitRate Double(double value) =>
        new(default, Optional<double>.Some(value));

    public bool TryGetV1SpeakPostParametersBitRate0(out V1SpeakPostParametersBitRate0 value) =>
        _v1SpeakPostParametersBitRate0Value.TryGetValue(out value);

    public bool TryGetDouble(out double value) => _doubleValue.TryGetValue(out value);

    public static implicit operator V1SpeakPostParametersBitRate(V1SpeakPostParametersBitRate0 value) =>
        V1SpeakPostParametersBitRate0(value);

    public static implicit operator V1SpeakPostParametersBitRate(double value) => Double(value);
}

file sealed class V1SpeakPostParametersBitRateConverter : JsonConverter<V1SpeakPostParametersBitRate>
{
    public override V1SpeakPostParametersBitRate Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersBitRate0>(root,
            options,
            out var v1SpeakPostParametersBitRate0Value))
        {
            return V1SpeakPostParametersBitRate.V1SpeakPostParametersBitRate0(v1SpeakPostParametersBitRate0Value);
        }
        if (JsonSerializer.TryDeserialize<double>(root, options, out var doubleValue))
        {
            return V1SpeakPostParametersBitRate.Double(doubleValue);
        }
        throw new JsonException($"JSON does not match V1SpeakPostParametersBitRate0 or double schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1SpeakPostParametersBitRate value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1SpeakPostParametersBitRate0(out var v1SpeakPostParametersBitRate0Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersBitRate0Value, options);
        }
        else if (value.TryGetDouble(out var doubleValue))
        {
            JsonSerializer.Serialize(writer, doubleValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1SpeakPostParametersBitRate)} contains no valid value to serialize.");
        }
    }
}
