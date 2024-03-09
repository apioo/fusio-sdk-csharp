/**
 * BackendTransaction automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendTransaction
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    [JsonPropertyName("planId")]
    public int PlanId { get; set; }
    [JsonPropertyName("transactionId")]
    public string TransactionId { get; set; }
    [JsonPropertyName("amount")]
    public double Amount { get; set; }
    [JsonPropertyName("points")]
    public double Points { get; set; }
    [JsonPropertyName("periodStart")]
    public DateTime PeriodStart { get; set; }
    [JsonPropertyName("periodEnd")]
    public DateTime PeriodEnd { get; set; }
    [JsonPropertyName("insertDate")]
    public DateTime InsertDate { get; set; }
}
