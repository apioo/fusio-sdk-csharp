/**
 * BackendEventSubscription automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendEventSubscription
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("eventId")]
    public int EventId { get; set; }
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }
    [JsonPropertyName("responses")]
    public List<BackendEventSubscriptionResponse> Responses { get; set; }
}
