using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListenPostParametersRedactSchemaOneOf1Items>))]
public sealed record V1ListenPostParametersRedactSchemaOneOf1Items : StringEnum<V1ListenPostParametersRedactSchemaOneOf1Items>
{
    private V1ListenPostParametersRedactSchemaOneOf1Items(string value) : base(value)
    {
    }

    public static readonly V1ListenPostParametersRedactSchemaOneOf1Items Pci = new("pci");

    public static readonly V1ListenPostParametersRedactSchemaOneOf1Items Pii = new("pii");

    public static readonly V1ListenPostParametersRedactSchemaOneOf1Items Numbers = new("numbers");

    public static V1ListenPostParametersRedactSchemaOneOf1Items FromValue(string value) => FromValueCore(value);
}
