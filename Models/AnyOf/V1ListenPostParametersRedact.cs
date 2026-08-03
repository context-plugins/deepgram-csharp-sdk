using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Models.Enums;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V1ListenPostParametersRedactConverter))]
public record V1ListenPostParametersRedact
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<IReadOnlyList<V1ListenPostParametersRedactSchemaOneOf1Items>> _listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue;

    private V1ListenPostParametersRedact(Optional<string> stringValue,
        Optional<IReadOnlyList<V1ListenPostParametersRedactSchemaOneOf1Items>> listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue)
    {
        _stringValue = stringValue;
        _listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue = listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue;
    }

    public static V1ListenPostParametersRedact String(string value) =>
        new(Optional<string>.Some(value), default);

    public static V1ListenPostParametersRedact ListOfV1ListenPostParametersRedactSchemaOneOf1Items(IReadOnlyList<V1ListenPostParametersRedactSchemaOneOf1Items> value) =>
        new(default, Optional<IReadOnlyList<V1ListenPostParametersRedactSchemaOneOf1Items>>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetListOfV1ListenPostParametersRedactSchemaOneOf1Items(out IReadOnlyList<V1ListenPostParametersRedactSchemaOneOf1Items> value) =>
        _listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue.TryGetValue(out value);

    public static implicit operator V1ListenPostParametersRedact(string value) => String(value);
}

file sealed class V1ListenPostParametersRedactConverter : JsonConverter<V1ListenPostParametersRedact>
{
    public override V1ListenPostParametersRedact Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return V1ListenPostParametersRedact.String(value);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<V1ListenPostParametersRedactSchemaOneOf1Items>>(root,
            options,
            out var listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue))
        {
            return V1ListenPostParametersRedact.ListOfV1ListenPostParametersRedactSchemaOneOf1Items(listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue);
        }
        throw new JsonException($"JSON does not match string or IReadOnlyList<V1ListenPostParametersRedactSchemaOneOf1Items> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ListenPostParametersRedact value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetListOfV1ListenPostParametersRedactSchemaOneOf1Items(out var listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue))
        {
            JsonSerializer.Serialize(writer, listOfV1ListenPostParametersRedactSchemaOneOf1ItemsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1ListenPostParametersRedact)} contains no valid value to serialize.");
        }
    }
}
