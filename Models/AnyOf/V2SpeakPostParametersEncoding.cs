using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;
using RestApi.Models.Enums;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(V2SpeakPostParametersEncodingConverter))]
public record V2SpeakPostParametersEncoding
{
    private readonly Optional<V2SpeakPostParametersEncoding0> _v2SpeakPostParametersEncoding0Value;

    private readonly Optional<V2SpeakPostParametersEncoding1> _v2SpeakPostParametersEncoding1Value;

    private readonly Optional<V2SpeakPostParametersEncoding2> _v2SpeakPostParametersEncoding2Value;

    private readonly Optional<V2SpeakPostParametersEncoding3> _v2SpeakPostParametersEncoding3Value;

    private readonly Optional<V2SpeakPostParametersEncoding4> _v2SpeakPostParametersEncoding4Value;

    private readonly Optional<V2SpeakPostParametersEncoding5> _v2SpeakPostParametersEncoding5Value;

    private readonly Optional<V2SpeakPostParametersEncoding6> _v2SpeakPostParametersEncoding6Value;

    private V2SpeakPostParametersEncoding(Optional<V2SpeakPostParametersEncoding0> v2SpeakPostParametersEncoding0Value,
        Optional<V2SpeakPostParametersEncoding1> v2SpeakPostParametersEncoding1Value,
        Optional<V2SpeakPostParametersEncoding2> v2SpeakPostParametersEncoding2Value,
        Optional<V2SpeakPostParametersEncoding3> v2SpeakPostParametersEncoding3Value,
        Optional<V2SpeakPostParametersEncoding4> v2SpeakPostParametersEncoding4Value,
        Optional<V2SpeakPostParametersEncoding5> v2SpeakPostParametersEncoding5Value,
        Optional<V2SpeakPostParametersEncoding6> v2SpeakPostParametersEncoding6Value)
    {
        _v2SpeakPostParametersEncoding0Value = v2SpeakPostParametersEncoding0Value;
        _v2SpeakPostParametersEncoding1Value = v2SpeakPostParametersEncoding1Value;
        _v2SpeakPostParametersEncoding2Value = v2SpeakPostParametersEncoding2Value;
        _v2SpeakPostParametersEncoding3Value = v2SpeakPostParametersEncoding3Value;
        _v2SpeakPostParametersEncoding4Value = v2SpeakPostParametersEncoding4Value;
        _v2SpeakPostParametersEncoding5Value = v2SpeakPostParametersEncoding5Value;
        _v2SpeakPostParametersEncoding6Value = v2SpeakPostParametersEncoding6Value;
    }

    public static V2SpeakPostParametersEncoding V2SpeakPostParametersEncoding0(V2SpeakPostParametersEncoding0 value) =>
        new(Optional<V2SpeakPostParametersEncoding0>.Some(value), default, default, default, default, default, default);

    public static V2SpeakPostParametersEncoding V2SpeakPostParametersEncoding1(V2SpeakPostParametersEncoding1 value) =>
        new(default, Optional<V2SpeakPostParametersEncoding1>.Some(value), default, default, default, default, default);

    public static V2SpeakPostParametersEncoding V2SpeakPostParametersEncoding2(V2SpeakPostParametersEncoding2 value) =>
        new(default, default, Optional<V2SpeakPostParametersEncoding2>.Some(value), default, default, default, default);

    public static V2SpeakPostParametersEncoding V2SpeakPostParametersEncoding3(V2SpeakPostParametersEncoding3 value) =>
        new(default, default, default, Optional<V2SpeakPostParametersEncoding3>.Some(value), default, default, default);

    public static V2SpeakPostParametersEncoding V2SpeakPostParametersEncoding4(V2SpeakPostParametersEncoding4 value) =>
        new(default, default, default, default, Optional<V2SpeakPostParametersEncoding4>.Some(value), default, default);

    public static V2SpeakPostParametersEncoding V2SpeakPostParametersEncoding5(V2SpeakPostParametersEncoding5 value) =>
        new(default, default, default, default, default, Optional<V2SpeakPostParametersEncoding5>.Some(value), default);

    public static V2SpeakPostParametersEncoding V2SpeakPostParametersEncoding6(V2SpeakPostParametersEncoding6 value) =>
        new(default, default, default, default, default, default, Optional<V2SpeakPostParametersEncoding6>.Some(value));

    public bool TryGetV2SpeakPostParametersEncoding0(out V2SpeakPostParametersEncoding0 value) =>
        _v2SpeakPostParametersEncoding0Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersEncoding1(out V2SpeakPostParametersEncoding1 value) =>
        _v2SpeakPostParametersEncoding1Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersEncoding2(out V2SpeakPostParametersEncoding2 value) =>
        _v2SpeakPostParametersEncoding2Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersEncoding3(out V2SpeakPostParametersEncoding3 value) =>
        _v2SpeakPostParametersEncoding3Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersEncoding4(out V2SpeakPostParametersEncoding4 value) =>
        _v2SpeakPostParametersEncoding4Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersEncoding5(out V2SpeakPostParametersEncoding5 value) =>
        _v2SpeakPostParametersEncoding5Value.TryGetValue(out value);

    public bool TryGetV2SpeakPostParametersEncoding6(out V2SpeakPostParametersEncoding6 value) =>
        _v2SpeakPostParametersEncoding6Value.TryGetValue(out value);

    public static implicit operator V2SpeakPostParametersEncoding(V2SpeakPostParametersEncoding0 value) =>
        V2SpeakPostParametersEncoding0(value);

    public static implicit operator V2SpeakPostParametersEncoding(V2SpeakPostParametersEncoding1 value) =>
        V2SpeakPostParametersEncoding1(value);

    public static implicit operator V2SpeakPostParametersEncoding(V2SpeakPostParametersEncoding2 value) =>
        V2SpeakPostParametersEncoding2(value);

    public static implicit operator V2SpeakPostParametersEncoding(V2SpeakPostParametersEncoding3 value) =>
        V2SpeakPostParametersEncoding3(value);

    public static implicit operator V2SpeakPostParametersEncoding(V2SpeakPostParametersEncoding4 value) =>
        V2SpeakPostParametersEncoding4(value);

    public static implicit operator V2SpeakPostParametersEncoding(V2SpeakPostParametersEncoding5 value) =>
        V2SpeakPostParametersEncoding5(value);

    public static implicit operator V2SpeakPostParametersEncoding(V2SpeakPostParametersEncoding6 value) =>
        V2SpeakPostParametersEncoding6(value);
}

file sealed class V2SpeakPostParametersEncodingConverter : JsonConverter<V2SpeakPostParametersEncoding>
{
    public override V2SpeakPostParametersEncoding Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersEncoding0>(root,
            options,
            out var v2SpeakPostParametersEncoding0Value))
        {
            return V2SpeakPostParametersEncoding.V2SpeakPostParametersEncoding0(v2SpeakPostParametersEncoding0Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersEncoding1>(root,
            options,
            out var v2SpeakPostParametersEncoding1Value))
        {
            return V2SpeakPostParametersEncoding.V2SpeakPostParametersEncoding1(v2SpeakPostParametersEncoding1Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersEncoding2>(root,
            options,
            out var v2SpeakPostParametersEncoding2Value))
        {
            return V2SpeakPostParametersEncoding.V2SpeakPostParametersEncoding2(v2SpeakPostParametersEncoding2Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersEncoding3>(root,
            options,
            out var v2SpeakPostParametersEncoding3Value))
        {
            return V2SpeakPostParametersEncoding.V2SpeakPostParametersEncoding3(v2SpeakPostParametersEncoding3Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersEncoding4>(root,
            options,
            out var v2SpeakPostParametersEncoding4Value))
        {
            return V2SpeakPostParametersEncoding.V2SpeakPostParametersEncoding4(v2SpeakPostParametersEncoding4Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersEncoding5>(root,
            options,
            out var v2SpeakPostParametersEncoding5Value))
        {
            return V2SpeakPostParametersEncoding.V2SpeakPostParametersEncoding5(v2SpeakPostParametersEncoding5Value);
        }
        if (JsonSerializer.TryDeserialize<V2SpeakPostParametersEncoding6>(root,
            options,
            out var v2SpeakPostParametersEncoding6Value))
        {
            return V2SpeakPostParametersEncoding.V2SpeakPostParametersEncoding6(v2SpeakPostParametersEncoding6Value);
        }
        throw new JsonException($"JSON does not match V2SpeakPostParametersEncoding0 or V2SpeakPostParametersEncoding1 or V2SpeakPostParametersEncoding2 or V2SpeakPostParametersEncoding3 or V2SpeakPostParametersEncoding4 or V2SpeakPostParametersEncoding5 or V2SpeakPostParametersEncoding6 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V2SpeakPostParametersEncoding value,
        JsonSerializerOptions options)
    {
        if (value.TryGetV2SpeakPostParametersEncoding0(out var v2SpeakPostParametersEncoding0Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersEncoding0Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersEncoding1(out var v2SpeakPostParametersEncoding1Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersEncoding1Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersEncoding2(out var v2SpeakPostParametersEncoding2Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersEncoding2Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersEncoding3(out var v2SpeakPostParametersEncoding3Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersEncoding3Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersEncoding4(out var v2SpeakPostParametersEncoding4Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersEncoding4Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersEncoding5(out var v2SpeakPostParametersEncoding5Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersEncoding5Value, options);
        }
        else if (value.TryGetV2SpeakPostParametersEncoding6(out var v2SpeakPostParametersEncoding6Value))
        {
            JsonSerializer.Serialize(writer, v2SpeakPostParametersEncoding6Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(V2SpeakPostParametersEncoding)} contains no valid value to serialize.");
        }
    }
}
