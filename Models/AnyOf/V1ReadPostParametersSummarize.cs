using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V1ReadPostParametersSummarizeConverter))]
public record V1ReadPostParametersSummarize
{
    private readonly Optional<V1ReadPostParametersSummarize0> _v1ReadPostParametersSummarize0Value;

    private readonly Optional<bool> _boolValue;

    private V1ReadPostParametersSummarize(Optional<V1ReadPostParametersSummarize0> v1ReadPostParametersSummarize0Value,
        Optional<bool> boolValue)
    {
        _v1ReadPostParametersSummarize0Value = v1ReadPostParametersSummarize0Value;
        _boolValue = boolValue;
    }

    public static V1ReadPostParametersSummarize V1ReadPostParametersSummarize0(V1ReadPostParametersSummarize0 value) =>
        new(Optional<V1ReadPostParametersSummarize0>.Some(value), default);

    public static V1ReadPostParametersSummarize Bool(bool value) =>
        new(default, Optional<bool>.Some(value));

    public bool TryGetV1ReadPostParametersSummarize0(out V1ReadPostParametersSummarize0 value) =>
        _v1ReadPostParametersSummarize0Value.TryGetValue(out value);

    public bool TryGetBool(out bool value) => _boolValue.TryGetValue(out value);

    public static implicit operator V1ReadPostParametersSummarize(V1ReadPostParametersSummarize0 value) =>
        V1ReadPostParametersSummarize0(value);

    public static implicit operator V1ReadPostParametersSummarize(bool value) => Bool(value);
}

file sealed class V1ReadPostParametersSummarizeConverter : JsonConverter<V1ReadPostParametersSummarize>
{
    public override V1ReadPostParametersSummarize Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1ReadPostParametersSummarize0>(root,
            options,
            out var v1ReadPostParametersSummarize0Value))
        {
            return V1ReadPostParametersSummarize.V1ReadPostParametersSummarize0(v1ReadPostParametersSummarize0Value);
        }
        if (JsonSerializer.TryDeserialize<bool>(root, options, out var boolValue))
        {
            return V1ReadPostParametersSummarize.Bool(boolValue);
        }
        throw new JsonException($"JSON does not match V1ReadPostParametersSummarize0 or bool schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ReadPostParametersSummarize value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1ReadPostParametersSummarize0(out var v1ReadPostParametersSummarize0Value))
        {
            JsonSerializer.Serialize(writer, v1ReadPostParametersSummarize0Value, options);
        }
        else if (value.TryGetBool(out var boolValue))
        {
            JsonSerializer.Serialize(writer, boolValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1ReadPostParametersSummarize)} contains no valid value to serialize.");
        }
    }
}
