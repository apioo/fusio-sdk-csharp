/**
 * ConsumerEventSubscription automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class ConsumerEventSubscription
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
    [JsonPropertyName("event")]
    public string Event { get; set; }
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }
    [JsonPropertyName("responses")]
    public List<ConsumerEventSubscriptionResponse> Responses { get; set; }
}
