using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Models.Enums;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V1ListenPostParametersModelConverter))]
public record V1ListenPostParametersModel
{
    private readonly Optional<V1ListenPostParametersModel0> _v1ListenPostParametersModel0Value;

    private readonly Optional<string> _stringValue;

    private V1ListenPostParametersModel(Optional<V1ListenPostParametersModel0> v1ListenPostParametersModel0Value,
        Optional<string> stringValue)
    {
        _v1ListenPostParametersModel0Value = v1ListenPostParametersModel0Value;
        _stringValue = stringValue;
    }

    public static V1ListenPostParametersModel V1ListenPostParametersModel0(V1ListenPostParametersModel0 value) =>
        new(Optional<V1ListenPostParametersModel0>.Some(value), default);

    public static V1ListenPostParametersModel String(string value) =>
        new(default, Optional<string>.Some(value));

    public bool TryGetV1ListenPostParametersModel0(out V1ListenPostParametersModel0 value) =>
        _v1ListenPostParametersModel0Value.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator V1ListenPostParametersModel(V1ListenPostParametersModel0 value) =>
        V1ListenPostParametersModel0(value);

    public static implicit operator V1ListenPostParametersModel(string value) => String(value);
}

file sealed class V1ListenPostParametersModelConverter : JsonConverter<V1ListenPostParametersModel>
{
    public override V1ListenPostParametersModel Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1ListenPostParametersModel0>(root,
            options,
            out var v1ListenPostParametersModel0Value))
        {
            return V1ListenPostParametersModel.V1ListenPostParametersModel0(v1ListenPostParametersModel0Value);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return V1ListenPostParametersModel.String(value);
        }
        throw new JsonException($"JSON does not match V1ListenPostParametersModel0 or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ListenPostParametersModel value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1ListenPostParametersModel0(out var v1ListenPostParametersModel0Value))
        {
            JsonSerializer.Serialize(writer, v1ListenPostParametersModel0Value, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1ListenPostParametersModel)} contains no valid value to serialize.");
        }
    }
}
