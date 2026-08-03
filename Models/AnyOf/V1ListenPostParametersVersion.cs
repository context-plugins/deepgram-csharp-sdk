using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Models.Enums;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V1ListenPostParametersVersionConverter))]
public record V1ListenPostParametersVersion
{
    private readonly Optional<V1ListenPostParametersVersion0> _v1ListenPostParametersVersion0Value;

    private readonly Optional<string> _stringValue;

    private V1ListenPostParametersVersion(Optional<V1ListenPostParametersVersion0> v1ListenPostParametersVersion0Value,
        Optional<string> stringValue)
    {
        _v1ListenPostParametersVersion0Value = v1ListenPostParametersVersion0Value;
        _stringValue = stringValue;
    }

    public static V1ListenPostParametersVersion V1ListenPostParametersVersion0(V1ListenPostParametersVersion0 value) =>
        new(Optional<V1ListenPostParametersVersion0>.Some(value), default);

    public static V1ListenPostParametersVersion String(string value) =>
        new(default, Optional<string>.Some(value));

    public bool TryGetV1ListenPostParametersVersion0(out V1ListenPostParametersVersion0 value) =>
        _v1ListenPostParametersVersion0Value.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator V1ListenPostParametersVersion(V1ListenPostParametersVersion0 value) =>
        V1ListenPostParametersVersion0(value);

    public static implicit operator V1ListenPostParametersVersion(string value) => String(value);
}

file sealed class V1ListenPostParametersVersionConverter : JsonConverter<V1ListenPostParametersVersion>
{
    public override V1ListenPostParametersVersion Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1ListenPostParametersVersion0>(root,
            options,
            out var v1ListenPostParametersVersion0Value))
        {
            return V1ListenPostParametersVersion.V1ListenPostParametersVersion0(v1ListenPostParametersVersion0Value);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return V1ListenPostParametersVersion.String(value);
        }
        throw new JsonException($"JSON does not match V1ListenPostParametersVersion0 or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ListenPostParametersVersion value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1ListenPostParametersVersion0(out var v1ListenPostParametersVersion0Value))
        {
            JsonSerializer.Serialize(writer, v1ListenPostParametersVersion0Value, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1ListenPostParametersVersion)} contains no valid value to serialize.");
        }
    }
}
