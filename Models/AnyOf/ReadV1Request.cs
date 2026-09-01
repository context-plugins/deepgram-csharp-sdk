using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Deepgram.Core.Extensions;
using Deepgram.Core.Models;

namespace Deepgram.Models.AnyOf;

[JsonConverter(typeof(ReadV1RequestConverter))]
public record ReadV1Request
{
    private readonly Optional<ReadV1RequestUrl> _readV1RequestUrlValue;

    private readonly Optional<ReadV1RequestText> _readV1RequestTextValue;

    private ReadV1Request(Optional<ReadV1RequestUrl> readV1RequestUrlValue,
        Optional<ReadV1RequestText> readV1RequestTextValue)
    {
        _readV1RequestUrlValue = readV1RequestUrlValue;
        _readV1RequestTextValue = readV1RequestTextValue;
    }

    public static ReadV1Request ReadV1RequestUrl(ReadV1RequestUrl value) =>
        new(Optional<ReadV1RequestUrl>.Some(value), default);

    public static ReadV1Request ReadV1RequestText(ReadV1RequestText value) =>
        new(default, Optional<ReadV1RequestText>.Some(value));

    public bool TryGetReadV1RequestUrl(out ReadV1RequestUrl value) =>
        _readV1RequestUrlValue.TryGetValue(out value);

    public bool TryGetReadV1RequestText(out ReadV1RequestText value) =>
        _readV1RequestTextValue.TryGetValue(out value);

    public static implicit operator ReadV1Request(ReadV1RequestUrl value) => ReadV1RequestUrl(value);

    public static implicit operator ReadV1Request(ReadV1RequestText value) => ReadV1RequestText(value);
}

file sealed class ReadV1RequestConverter : JsonConverter<ReadV1Request>
{
    public override ReadV1Request Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ReadV1RequestUrl>(root, options, out var readV1RequestUrlValue))
        {
            return ReadV1Request.ReadV1RequestUrl(readV1RequestUrlValue);
        }
        if (JsonSerializer.TryDeserialize<ReadV1RequestText>(root, options, out var readV1RequestTextValue))
        {
            return ReadV1Request.ReadV1RequestText(readV1RequestTextValue);
        }
        throw new JsonException($"JSON does not match ReadV1RequestUrl or ReadV1RequestText schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReadV1Request value, JsonSerializerOptions options)
    {
        if (value.TryGetReadV1RequestUrl(out var readV1RequestUrlValue))
        {
            JsonSerializer.Serialize(writer, readV1RequestUrlValue, options);
        }
        else if (value.TryGetReadV1RequestText(out var readV1RequestTextValue))
        {
            JsonSerializer.Serialize(writer, readV1RequestTextValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ReadV1Request)} contains no valid value to serialize.");
        }
    }
}
