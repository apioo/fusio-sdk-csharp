/**
 * ConsumerUserPlan automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class ConsumerUserPlan
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("price")]
    public int? Price { get; set; }
    [JsonPropertyName("points")]
    public int? Points { get; set; }
    [JsonPropertyName("period")]
    public int? Period { get; set; }
}
