using System.Text.Json.Serialization;
using Deepgram.Core.Enum;

namespace Deepgram.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListBillingFieldsV1ResponseDeploymentsItems>))]
public sealed record ListBillingFieldsV1ResponseDeploymentsItems : StringEnum<ListBillingFieldsV1ResponseDeploymentsItems>
{
    private ListBillingFieldsV1ResponseDeploymentsItems(string value) : base(value)
    {
    }

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems Hosted = new("hosted");

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems Beta = new("beta");

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems SelfHosted = new("self-hosted");

    public static readonly ListBillingFieldsV1ResponseDeploymentsItems Dedicated = new("dedicated");

    public static ListBillingFieldsV1ResponseDeploymentsItems FromValue(string value) => FromValueCore(value);
}
