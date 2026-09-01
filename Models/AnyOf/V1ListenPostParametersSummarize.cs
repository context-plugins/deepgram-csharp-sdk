using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;
using Deepgram.Models.Enums;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V1ListenPostParametersSummarizeConverter))]
public record V1ListenPostParametersSummarize
{
    private readonly Optional<V1ListenPostParametersSummarize0> _v1ListenPostParametersSummarize0Value;

    private readonly Optional<bool> _boolValue;

    private V1ListenPostParametersSummarize(Optional<V1ListenPostParametersSummarize0> v1ListenPostParametersSummarize0Value,
        Optional<bool> boolValue)
    {
        _v1ListenPostParametersSummarize0Value = v1ListenPostParametersSummarize0Value;
        _boolValue = boolValue;
    }

    public static V1ListenPostParametersSummarize V1ListenPostParametersSummarize0(V1ListenPostParametersSummarize0 value) =>
        new(Optional<V1ListenPostParametersSummarize0>.Some(value), default);

    public static V1ListenPostParametersSummarize Bool(bool value) =>
        new(default, Optional<bool>.Some(value));

    public bool TryGetV1ListenPostParametersSummarize0(out V1ListenPostParametersSummarize0 value) =>
        _v1ListenPostParametersSummarize0Value.TryGetValue(out value);

    public bool TryGetBool(out bool value) => _boolValue.TryGetValue(out value);

    public static implicit operator V1ListenPostParametersSummarize(V1ListenPostParametersSummarize0 value) =>
        V1ListenPostParametersSummarize0(value);

    public static implicit operator V1ListenPostParametersSummarize(bool value) => Bool(value);
}

file sealed class V1ListenPostParametersSummarizeConverter : JsonConverter<V1ListenPostParametersSummarize>
{
    public override V1ListenPostParametersSummarize Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1ListenPostParametersSummarize0>(root,
            options,
            out var v1ListenPostParametersSummarize0Value))
        {
            return V1ListenPostParametersSummarize.V1ListenPostParametersSummarize0(v1ListenPostParametersSummarize0Value);
        }
        if (JsonSerializer.TryDeserialize<bool>(root, options, out var boolValue))
        {
            return V1ListenPostParametersSummarize.Bool(boolValue);
        }
        throw new JsonException($"JSON does not match V1ListenPostParametersSummarize0 or bool schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ListenPostParametersSummarize value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1ListenPostParametersSummarize0(out var v1ListenPostParametersSummarize0Value))
        {
            JsonSerializer.Serialize(writer, v1ListenPostParametersSummarize0Value, options);
        }
        else if (value.TryGetBool(out var boolValue))
        {
            JsonSerializer.Serialize(writer, boolValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1ListenPostParametersSummarize)} contains no valid value to serialize.");
        }
    }
}
