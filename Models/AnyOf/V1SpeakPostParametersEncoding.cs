using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Models.Enums;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V1SpeakPostParametersEncodingConverter))]
public record V1SpeakPostParametersEncoding
{
    private readonly Optional<V1SpeakPostParametersEncoding0> _v1SpeakPostParametersEncoding0Value;

    private readonly Optional<V1SpeakPostParametersEncoding1> _v1SpeakPostParametersEncoding1Value;

    private readonly Optional<V1SpeakPostParametersEncoding2> _v1SpeakPostParametersEncoding2Value;

    private readonly Optional<V1SpeakPostParametersEncoding3> _v1SpeakPostParametersEncoding3Value;

    private readonly Optional<V1SpeakPostParametersEncoding4> _v1SpeakPostParametersEncoding4Value;

    private readonly Optional<V1SpeakPostParametersEncoding5> _v1SpeakPostParametersEncoding5Value;

    private readonly Optional<V1SpeakPostParametersEncoding6> _v1SpeakPostParametersEncoding6Value;

    private V1SpeakPostParametersEncoding(Optional<V1SpeakPostParametersEncoding0> v1SpeakPostParametersEncoding0Value,
        Optional<V1SpeakPostParametersEncoding1> v1SpeakPostParametersEncoding1Value,
        Optional<V1SpeakPostParametersEncoding2> v1SpeakPostParametersEncoding2Value,
        Optional<V1SpeakPostParametersEncoding3> v1SpeakPostParametersEncoding3Value,
        Optional<V1SpeakPostParametersEncoding4> v1SpeakPostParametersEncoding4Value,
        Optional<V1SpeakPostParametersEncoding5> v1SpeakPostParametersEncoding5Value,
        Optional<V1SpeakPostParametersEncoding6> v1SpeakPostParametersEncoding6Value)
    {
        _v1SpeakPostParametersEncoding0Value = v1SpeakPostParametersEncoding0Value;
        _v1SpeakPostParametersEncoding1Value = v1SpeakPostParametersEncoding1Value;
        _v1SpeakPostParametersEncoding2Value = v1SpeakPostParametersEncoding2Value;
        _v1SpeakPostParametersEncoding3Value = v1SpeakPostParametersEncoding3Value;
        _v1SpeakPostParametersEncoding4Value = v1SpeakPostParametersEncoding4Value;
        _v1SpeakPostParametersEncoding5Value = v1SpeakPostParametersEncoding5Value;
        _v1SpeakPostParametersEncoding6Value = v1SpeakPostParametersEncoding6Value;
    }

    public static V1SpeakPostParametersEncoding V1SpeakPostParametersEncoding0(V1SpeakPostParametersEncoding0 value) =>
        new(Optional<V1SpeakPostParametersEncoding0>.Some(value), default, default, default, default, default, default);

    public static V1SpeakPostParametersEncoding V1SpeakPostParametersEncoding1(V1SpeakPostParametersEncoding1 value) =>
        new(default, Optional<V1SpeakPostParametersEncoding1>.Some(value), default, default, default, default, default);

    public static V1SpeakPostParametersEncoding V1SpeakPostParametersEncoding2(V1SpeakPostParametersEncoding2 value) =>
        new(default, default, Optional<V1SpeakPostParametersEncoding2>.Some(value), default, default, default, default);

    public static V1SpeakPostParametersEncoding V1SpeakPostParametersEncoding3(V1SpeakPostParametersEncoding3 value) =>
        new(default, default, default, Optional<V1SpeakPostParametersEncoding3>.Some(value), default, default, default);

    public static V1SpeakPostParametersEncoding V1SpeakPostParametersEncoding4(V1SpeakPostParametersEncoding4 value) =>
        new(default, default, default, default, Optional<V1SpeakPostParametersEncoding4>.Some(value), default, default);

    public static V1SpeakPostParametersEncoding V1SpeakPostParametersEncoding5(V1SpeakPostParametersEncoding5 value) =>
        new(default, default, default, default, default, Optional<V1SpeakPostParametersEncoding5>.Some(value), default);

    public static V1SpeakPostParametersEncoding V1SpeakPostParametersEncoding6(V1SpeakPostParametersEncoding6 value) =>
        new(default, default, default, default, default, default, Optional<V1SpeakPostParametersEncoding6>.Some(value));

    public bool TryGetV1SpeakPostParametersEncoding0(out V1SpeakPostParametersEncoding0 value) =>
        _v1SpeakPostParametersEncoding0Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersEncoding1(out V1SpeakPostParametersEncoding1 value) =>
        _v1SpeakPostParametersEncoding1Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersEncoding2(out V1SpeakPostParametersEncoding2 value) =>
        _v1SpeakPostParametersEncoding2Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersEncoding3(out V1SpeakPostParametersEncoding3 value) =>
        _v1SpeakPostParametersEncoding3Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersEncoding4(out V1SpeakPostParametersEncoding4 value) =>
        _v1SpeakPostParametersEncoding4Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersEncoding5(out V1SpeakPostParametersEncoding5 value) =>
        _v1SpeakPostParametersEncoding5Value.TryGetValue(out value);

    public bool TryGetV1SpeakPostParametersEncoding6(out V1SpeakPostParametersEncoding6 value) =>
        _v1SpeakPostParametersEncoding6Value.TryGetValue(out value);

    public static implicit operator V1SpeakPostParametersEncoding(V1SpeakPostParametersEncoding0 value) =>
        V1SpeakPostParametersEncoding0(value);

    public static implicit operator V1SpeakPostParametersEncoding(V1SpeakPostParametersEncoding1 value) =>
        V1SpeakPostParametersEncoding1(value);

    public static implicit operator V1SpeakPostParametersEncoding(V1SpeakPostParametersEncoding2 value) =>
        V1SpeakPostParametersEncoding2(value);

    public static implicit operator V1SpeakPostParametersEncoding(V1SpeakPostParametersEncoding3 value) =>
        V1SpeakPostParametersEncoding3(value);

    public static implicit operator V1SpeakPostParametersEncoding(V1SpeakPostParametersEncoding4 value) =>
        V1SpeakPostParametersEncoding4(value);

    public static implicit operator V1SpeakPostParametersEncoding(V1SpeakPostParametersEncoding5 value) =>
        V1SpeakPostParametersEncoding5(value);

    public static implicit operator V1SpeakPostParametersEncoding(V1SpeakPostParametersEncoding6 value) =>
        V1SpeakPostParametersEncoding6(value);
}

file sealed class V1SpeakPostParametersEncodingConverter : JsonConverter<V1SpeakPostParametersEncoding>
{
    public override V1SpeakPostParametersEncoding Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersEncoding0>(root,
            options,
            out var v1SpeakPostParametersEncoding0Value))
        {
            return V1SpeakPostParametersEncoding.V1SpeakPostParametersEncoding0(v1SpeakPostParametersEncoding0Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersEncoding1>(root,
            options,
            out var v1SpeakPostParametersEncoding1Value))
        {
            return V1SpeakPostParametersEncoding.V1SpeakPostParametersEncoding1(v1SpeakPostParametersEncoding1Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersEncoding2>(root,
            options,
            out var v1SpeakPostParametersEncoding2Value))
        {
            return V1SpeakPostParametersEncoding.V1SpeakPostParametersEncoding2(v1SpeakPostParametersEncoding2Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersEncoding3>(root,
            options,
            out var v1SpeakPostParametersEncoding3Value))
        {
            return V1SpeakPostParametersEncoding.V1SpeakPostParametersEncoding3(v1SpeakPostParametersEncoding3Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersEncoding4>(root,
            options,
            out var v1SpeakPostParametersEncoding4Value))
        {
            return V1SpeakPostParametersEncoding.V1SpeakPostParametersEncoding4(v1SpeakPostParametersEncoding4Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersEncoding5>(root,
            options,
            out var v1SpeakPostParametersEncoding5Value))
        {
            return V1SpeakPostParametersEncoding.V1SpeakPostParametersEncoding5(v1SpeakPostParametersEncoding5Value);
        }
        if (JsonSerializer.TryDeserialize<V1SpeakPostParametersEncoding6>(root,
            options,
            out var v1SpeakPostParametersEncoding6Value))
        {
            return V1SpeakPostParametersEncoding.V1SpeakPostParametersEncoding6(v1SpeakPostParametersEncoding6Value);
        }
        throw new JsonException($"JSON does not match V1SpeakPostParametersEncoding0 or V1SpeakPostParametersEncoding1 or V1SpeakPostParametersEncoding2 or V1SpeakPostParametersEncoding3 or V1SpeakPostParametersEncoding4 or V1SpeakPostParametersEncoding5 or V1SpeakPostParametersEncoding6 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V1SpeakPostParametersEncoding value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV1SpeakPostParametersEncoding0(out var v1SpeakPostParametersEncoding0Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersEncoding0Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersEncoding1(out var v1SpeakPostParametersEncoding1Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersEncoding1Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersEncoding2(out var v1SpeakPostParametersEncoding2Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersEncoding2Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersEncoding3(out var v1SpeakPostParametersEncoding3Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersEncoding3Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersEncoding4(out var v1SpeakPostParametersEncoding4Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersEncoding4Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersEncoding5(out var v1SpeakPostParametersEncoding5Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersEncoding5Value, options);
        }
        else if (value.TryGetV1SpeakPostParametersEncoding6(out var v1SpeakPostParametersEncoding6Value))
        {
            JsonSerializer.Serialize(writer, v1SpeakPostParametersEncoding6Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(V1SpeakPostParametersEncoding)} contains no valid value to serialize.");
        }
    }
}
