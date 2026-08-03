using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(CreateKeyV1RequestConverter))]
public record CreateKeyV1Request
{
    private readonly Optional<object> _anonymousObjectValue;

    private CreateKeyV1Request(Optional<object> anonymousObjectValue)
    {
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static CreateKeyV1Request AnonymousObject(object value) => new(Optional<object>.Some(value));

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);
}

file sealed class CreateKeyV1RequestConverter : JsonConverter<CreateKeyV1Request>
{
    public override CreateKeyV1Request Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<object>(root, options, out var anonymousObjectValue))
        {
            return CreateKeyV1Request.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match object schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CreateKeyV1Request value, JsonSerializerOptions options)
    {
        if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CreateKeyV1Request)} contains no valid value to serialize.");
        }
    }
}
