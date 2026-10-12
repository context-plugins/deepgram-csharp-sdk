using System;
using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersRedactSchemaOneOf1Items>))]
public sealed record V1ListenPostParametersRedactSchemaOneOf1Items : OpenStringEnum<V1ListenPostParametersRedactSchemaOneOf1Items>
{
    private V1ListenPostParametersRedactSchemaOneOf1Items(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersRedactSchemaOneOf1Items Pci = new("pci");

    public static readonly V1ListenPostParametersRedactSchemaOneOf1Items Pii = new("pii");

    public static readonly V1ListenPostParametersRedactSchemaOneOf1Items Numbers = new("numbers");

    public TResult Match<TResult>(Func<TResult> onPci,
        Func<TResult> onPii,
        Func<TResult> onNumbers,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pci => onPci(),
            _ when this == Pii => onPii(),
            _ when this == Numbers => onNumbers(),
            _ => otherwise(Value)
        };

    public void Match(Action onPci, Action onPii, Action onNumbers, Action<string> otherwise)
    {
        if (this == Pci) onPci();
        else if (this == Pii) onPii();
        else if (this == Numbers) onNumbers();
        else otherwise(Value);
    }
}
