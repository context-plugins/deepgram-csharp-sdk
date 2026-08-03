using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(GetModelV1ResponseConverter))]
public record GetModelV1Response
{
    private readonly Optional<GetModelV1Response0> _getModelV1Response0Value;

    private readonly Optional<GetModelV1Response1> _getModelV1Response1Value;

    private GetModelV1Response(Optional<GetModelV1Response0> getModelV1Response0Value,
        Optional<GetModelV1Response1> getModelV1Response1Value)
    {
        _getModelV1Response0Value = getModelV1Response0Value;
        _getModelV1Response1Value = getModelV1Response1Value;
    }

    public static GetModelV1Response GetModelV1Response0(GetModelV1Response0 value) =>
        new(Optional<GetModelV1Response0>.Some(value), default);

    public static GetModelV1Response GetModelV1Response1(GetModelV1Response1 value) =>
        new(default, Optional<GetModelV1Response1>.Some(value));

    public bool TryGetGetModelV1Response0(out GetModelV1Response0 value) =>
        _getModelV1Response0Value.TryGetValue(out value);

    public bool TryGetGetModelV1Response1(out GetModelV1Response1 value) =>
        _getModelV1Response1Value.TryGetValue(out value);

    public static implicit operator GetModelV1Response(GetModelV1Response0 value) => GetModelV1Response0(value);

    public static implicit operator GetModelV1Response(GetModelV1Response1 value) => GetModelV1Response1(value);
}

file sealed class GetModelV1ResponseConverter : JsonConverter<GetModelV1Response>
{
    public override GetModelV1Response Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GetModelV1Response0>(root, options, out var getModelV1Response0Value))
        {
            return GetModelV1Response.GetModelV1Response0(getModelV1Response0Value);
        }
        if (JsonSerializer.TryDeserialize<GetModelV1Response1>(root, options, out var getModelV1Response1Value))
        {
            return GetModelV1Response.GetModelV1Response1(getModelV1Response1Value);
        }
        throw new JsonException($"JSON does not match GetModelV1Response0 or GetModelV1Response1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, GetModelV1Response value, JsonSerializerOptions options)
    {
        if (value.TryGetGetModelV1Response0(out var getModelV1Response0Value))
        {
            JsonSerializer.Serialize(writer, getModelV1Response0Value, options);
        }
        else if (value.TryGetGetModelV1Response1(out var getModelV1Response1Value))
        {
            JsonSerializer.Serialize(writer, getModelV1Response1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(GetModelV1Response)} contains no valid value to serialize.");
        }
    }
}
