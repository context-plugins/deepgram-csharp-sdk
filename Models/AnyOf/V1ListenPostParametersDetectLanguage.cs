using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V1ListenPostParametersDetectLanguageConverter))]
public record V1ListenPostParametersDetectLanguage
{
    private readonly Optional<bool> _boolValue;

    private readonly Optional<IReadOnlyList<string>> _listOfStringValue;

    private V1ListenPostParametersDetectLanguage(Optional<bool> boolValue,
        Optional<IReadOnlyList<string>> listOfStringValue)
    {
        _boolValue = boolValue;
        _listOfStringValue = listOfStringValue;
    }

    public static V1ListenPostParametersDetectLanguage Bool(bool value) =>
        new(Optional<bool>.Some(value), default);

    public static V1ListenPostParametersDetectLanguage ListOfString(IReadOnlyList<string> value) =>
        new(default, Optional<IReadOnlyList<string>>.Some(value));

    public bool TryGetBool(out bool value) => _boolValue.TryGetValue(out value);

    public bool TryGetListOfString(out IReadOnlyList<string> value) =>
        _listOfStringValue.TryGetValue(out value);

    public static implicit operator V1ListenPostParametersDetectLanguage(bool value) => Bool(value);
}

file sealed class V1ListenPostParametersDetectLanguageConverter : JsonConverter<V1ListenPostParametersDetectLanguage>
{
    public override V1ListenPostParametersDetectLanguage Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<bool>(root, options, out var boolValue))
        {
            return V1ListenPostParametersDetectLanguage.Bool(boolValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<string>>(root, options, out var listOfStringValue))
        {
            return V1ListenPostParametersDetectLanguage.ListOfString(listOfStringValue);
        }
        throw new JsonException($"JSON does not match bool or IReadOnlyList<string> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1ListenPostParametersDetectLanguage value,
        JsonSerializerOptions options)
    {
        if (value.TryGetBool(out var boolValue))
        {
            JsonSerializer.Serialize(writer, boolValue, options);
        }
        else if (value.TryGetListOfString(out var listOfStringValue))
        {
            JsonSerializer.Serialize(writer, listOfStringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1ListenPostParametersDetectLanguage)} contains no valid value to serialize.");
        }
    }
}
