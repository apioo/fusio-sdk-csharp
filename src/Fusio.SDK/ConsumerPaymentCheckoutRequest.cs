/**
 * ConsumerPaymentCheckoutRequest automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class ConsumerPaymentCheckoutRequest
{
    [JsonPropertyName("planId")]
    public int? PlanId { get; set; }
    [JsonPropertyName("returnUrl")]
    public string? ReturnUrl { get; set; }
}