using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(ListenV1MediaTranscribeResponse200Converter))]
public record ListenV1MediaTranscribeResponse200
{
    private readonly Optional<ListenV1Response> _listenV1ResponseValue;

    private readonly Optional<ListenV1AcceptedResponse> _listenV1AcceptedResponseValue;

    private ListenV1MediaTranscribeResponse200(Optional<ListenV1Response> listenV1ResponseValue,
        Optional<ListenV1AcceptedResponse> listenV1AcceptedResponseValue)
    {
        _listenV1ResponseValue = listenV1ResponseValue;
        _listenV1AcceptedResponseValue = listenV1AcceptedResponseValue;
    }

    public static ListenV1MediaTranscribeResponse200 ListenV1Response(ListenV1Response value) =>
        new(Optional<ListenV1Response>.Some(value), default);

    public static ListenV1MediaTranscribeResponse200 ListenV1AcceptedResponse(ListenV1AcceptedResponse value) =>
        new(default, Optional<ListenV1AcceptedResponse>.Some(value));

    public bool TryGetListenV1Response(out ListenV1Response value) =>
        _listenV1ResponseValue.TryGetValue(out value);

    public bool TryGetListenV1AcceptedResponse(out ListenV1AcceptedResponse value) =>
        _listenV1AcceptedResponseValue.TryGetValue(out value);

    public static implicit operator ListenV1MediaTranscribeResponse200(ListenV1Response value) =>
        ListenV1Response(value);

    public static implicit operator ListenV1MediaTranscribeResponse200(ListenV1AcceptedResponse value) =>
        ListenV1AcceptedResponse(value);
}

file sealed class ListenV1MediaTranscribeResponse200Converter : JsonConverter<ListenV1MediaTranscribeResponse200>
{
    public override ListenV1MediaTranscribeResponse200 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ListenV1Response>(root, options, out var listenV1ResponseValue))
        {
            return ListenV1MediaTranscribeResponse200.ListenV1Response(listenV1ResponseValue);
        }
        if (JsonSerializer.TryDeserialize<ListenV1AcceptedResponse>(root,
            options,
            out var listenV1AcceptedResponseValue))
        {
            return ListenV1MediaTranscribeResponse200.ListenV1AcceptedResponse(listenV1AcceptedResponseValue);
        }
        throw new JsonException($"JSON does not match ListenV1Response or ListenV1AcceptedResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ListenV1MediaTranscribeResponse200 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetListenV1Response(out var listenV1ResponseValue))
        {
            JsonSerializer.Serialize(writer, listenV1ResponseValue, options);
        }
        else if (value.TryGetListenV1AcceptedResponse(out var listenV1AcceptedResponseValue))
        {
            JsonSerializer.Serialize(writer, listenV1AcceptedResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ListenV1MediaTranscribeResponse200)} contains no valid value to serialize.");
        }
    }
}
