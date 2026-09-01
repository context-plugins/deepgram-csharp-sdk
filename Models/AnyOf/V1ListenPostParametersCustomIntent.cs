using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(V1ListenPostParametersCustomIntentConverter))]
public record V1ListenPostParametersCustomIntent
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<IReadOnlyList<string>> _listOfStringValue;

    private V1ListenPostParametersCustomIntent(Optional<string> stringValue,
        Optional<IReadOnlyList<string>> listOfStringValue)
    {
        _stringValue = stringValue;
        _listOfStringValue = listOfStringValue;
    }

    public static V1ListenPostParametersCustomIntent String(string value) =>
        new(Optional<string>.Some(value), default);

    public static V1ListenPostParametersCustomIntent ListOfString(IReadOnlyList<string> value) =>
        new(default, Optional<IReadOnlyList<string>>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetListOfString(out IReadOnlyList<string> value) =>
        _listOfStringValue.TryGetValue(out value);

    public static implicit operator V1ListenPostParametersCustomIntent(string value) => String(value);
}

file sealed class V1ListenPostParametersCustomIntentConverter : JsonConverter<V1ListenPostParametersCustomIntent>
{
    public override V1ListenPostParametersCustomIntent Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return V1ListenPostParametersCustomIntent.String(value);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<string>>(root, options, out var listOfStringValue))
        {
            return V1ListenPostParametersCustomIntent.ListOfString(listOfStringValue);
        }
        throw new JsonException($"JSON does not match string or IReadOnlyList<string> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ListenPostParametersCustomIntent value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetListOfString(out var listOfStringValue))
        {
            JsonSerializer.Serialize(writer, listOfStringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1ListenPostParametersCustomIntent)} contains no valid value to serialize.");
        }
    }
}
