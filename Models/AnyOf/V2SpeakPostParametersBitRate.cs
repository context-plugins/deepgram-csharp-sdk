using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V2SpeakPostParametersBitRateConverter))]
public record V2SpeakPostParametersBitRate
{
    private readonly Optional<V2SpeakPostParametersBitRate0> _v2SpeakPostParametersBitRate0Value;

    private readonly Optional<int> _intValue;

    private V2SpeakPostParametersBitRate(Optional<V2SpeakPostParametersBitRate0> v2SpeakPostParametersBitRate0Value,
        Optional<int> intValue)
    {
        _v2SpeakPostParametersBitRate0Value = v2SpeakPostParametersBitRate0Value;
        _intValue = intValue;
    }

    public static V2SpeakPostParametersBitRate V2SpeakPostParametersBitRate0(V2SpeakPostParametersBitRate0 value) =>
        new(Optional<V2SpeakPostParametersBitRate0>.Some(value), default);

    public static V2SpeakPostParametersBitRate Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetV2SpeakPostParametersBitRate0(out V2SpeakPostParametersBitRate0 value) =>
        _v2SpeakPostParametersBitRate0Value.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator V2SpeakPostParametersBitRate(V2SpeakPostParametersBitRate0 value) =>
        V2SpeakPostParametersBitRate0(value);

    public static implicit operator V2SpeakPostParametersBitRate(int value) => Int(value);
}

file sealed class V2SpeakPostParametersBitRateConverter : JsonConverter<V2SpeakPostParametersBitRate>
{
    public override V2SpeakPostParametersBitRate Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersBitRate0>(root,
            options,
            out var v2SpeakPostParametersBitRate0Value))
        {
            return V2SpeakPostParametersBitRate.V2SpeakPostParametersBitRate0(v2SpeakPostParametersBitRate0Value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return V2SpeakPostParametersBitRate.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match V2SpeakPostParametersBitRate0 or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V2SpeakPostParametersBitRate value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV2SpeakPostParametersBitRate0(out var v2SpeakPostParametersBitRate0Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersBitRate0Value, options);
        }
        else if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V2SpeakPostParametersBitRate)} contains no valid value to serialize.");
        }
    }
}
