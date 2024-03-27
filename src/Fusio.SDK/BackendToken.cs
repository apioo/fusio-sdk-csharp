/**
 * BackendToken automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendToken
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    [JsonPropertyName("status")]
    public int? Status { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("scopes")]
    public List<string>? Scopes { get; set; }
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
    [JsonPropertyName("expire")]
    public DateTime? Expire { get; set; }
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }
}