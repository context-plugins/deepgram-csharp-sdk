using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestApi.Core.Extensions;
using RestApi.Core.Models;

namespace RestApi.Models.AnyOf;

[JsonConverter(typeof(ErrorResponseModelConverter))]
public record ErrorResponseModel
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ErrorResponseLegacyError> _errorResponseLegacyErrorValue;

    private readonly Optional<ErrorResponseModernError> _errorResponseModernErrorValue;

    private ErrorResponseModel(Optional<string> stringValue,
        Optional<ErrorResponseLegacyError> errorResponseLegacyErrorValue,
        Optional<ErrorResponseModernError> errorResponseModernErrorValue)
    {
        _stringValue = stringValue;
        _errorResponseLegacyErrorValue = errorResponseLegacyErrorValue;
        _errorResponseModernErrorValue = errorResponseModernErrorValue;
    }

    public static ErrorResponseModel String(string value) =>
        new(Optional<string>.Some(value), default, default);

    public static ErrorResponseModel ErrorResponseLegacyError(ErrorResponseLegacyError value) =>
        new(default, Optional<ErrorResponseLegacyError>.Some(value), default);

    public static ErrorResponseModel ErrorResponseModernError(ErrorResponseModernError value) =>
        new(default, default, Optional<ErrorResponseModernError>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetErrorResponseLegacyError(out ErrorResponseLegacyError value) =>
        _errorResponseLegacyErrorValue.TryGetValue(out value);

    public bool TryGetErrorResponseModernError(out ErrorResponseModernError value) =>
        _errorResponseModernErrorValue.TryGetValue(out value);

    public static implicit operator ErrorResponseModel(string value) => String(value);

    public static implicit operator ErrorResponseModel(ErrorResponseLegacyError value) =>
        ErrorResponseLegacyError(value);

    public static implicit operator ErrorResponseModel(ErrorResponseModernError value) =>
        ErrorResponseModernError(value);
}

file sealed class ErrorResponseModelConverter : JsonConverter<ErrorResponseModel>
{
    public override ErrorResponseModel Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ErrorResponseModel.String(value);
        }
        if (JsonSerializer.TryDeserialize<ErrorResponseLegacyError>(root,
            options,
            out var errorResponseLegacyErrorValue))
        {
            return ErrorResponseModel.ErrorResponseLegacyError(errorResponseLegacyErrorValue);
        }
        if (JsonSerializer.TryDeserialize<ErrorResponseModernError>(root,
            options,
            out var errorResponseModernErrorValue))
        {
            return ErrorResponseModel.ErrorResponseModernError(errorResponseModernErrorValue);
        }
        throw new JsonException($"JSON does not match string or ErrorResponseLegacyError or ErrorResponseModernError schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ErrorResponseModel value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetErrorResponseLegacyError(out var errorResponseLegacyErrorValue))
        {
            JsonSerializer.Serialize(writer, errorResponseLegacyErrorValue, options);
        }
        else if (value.TryGetErrorResponseModernError(out var errorResponseModernErrorValue))
        {
            JsonSerializer.Serialize(writer, errorResponseModernErrorValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ErrorResponseModel)} contains no valid value to serialize.");
        }
    }
}
