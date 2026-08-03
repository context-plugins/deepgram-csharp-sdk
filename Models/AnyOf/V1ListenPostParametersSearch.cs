using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V1ListenPostParametersSearchConverter))]
public record V1ListenPostParametersSearch
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<IReadOnlyList<string>> _listOfStringValue;

    private V1ListenPostParametersSearch(Optional<string> stringValue,
        Optional<IReadOnlyList<string>> listOfStringValue)
    {
        _stringValue = stringValue;
        _listOfStringValue = listOfStringValue;
    }

    public static V1ListenPostParametersSearch String(string value) =>
        new(Optional<string>.Some(value), default);

    public static V1ListenPostParametersSearch ListOfString(IReadOnlyList<string> value) =>
        new(default, Optional<IReadOnlyList<string>>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetListOfString(out IReadOnlyList<string> value) =>
        _listOfStringValue.TryGetValue(out value);

    public static implicit operator V1ListenPostParametersSearch(string value) => String(value);
}

file sealed class V1ListenPostParametersSearchConverter : JsonConverter<V1ListenPostParametersSearch>
{
    public override V1ListenPostParametersSearch Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return V1ListenPostParametersSearch.String(value);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<string>>(root, options, out var listOfStringValue))
        {
            return V1ListenPostParametersSearch.ListOfString(listOfStringValue);
        }
        throw new JsonException($"JSON does not match string or IReadOnlyList<string> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ListenPostParametersSearch value,
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
            throw new JsonException($"{nameof(V1ListenPostParametersSearch)} contains no valid value to serialize.");
        }
    }
}
