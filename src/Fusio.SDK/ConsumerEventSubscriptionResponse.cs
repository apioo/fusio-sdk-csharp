/**
 * ConsumerEventSubscriptionResponse automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class ConsumerEventSubscriptionResponse
{
    [JsonPropertyName("status")]
    public int Status { get; set; }
    [JsonPropertyName("code")]
    public int Code { get; set; }
    [JsonPropertyName("attempts")]
    public string Attempts { get; set; }
    [JsonPropertyName("executeDate")]
    public string ExecuteDate { get; set; }
}
