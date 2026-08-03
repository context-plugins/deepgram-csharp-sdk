using System.Text.Json.Serialization;

namespace RestApi.Models;

public record GetProjectBalanceV1Response
{
    /// <summary>
    /// The unique identifier of the balance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance_id")]
    public string? BalanceId { get; init; }

    /// <summary>
    /// The amount of the balance
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; init; } = 0d;

    /// <summary>
    /// The units of the balance, such as "USD"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("units")]
    public string? Units { get; init; }

    /// <summary>
    /// Description or reference of the purchase
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchase_order_id")]
    public string? PurchaseOrderId { get; init; }
}
