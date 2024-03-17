/**
 * BackendApp automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendApp
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    [JsonPropertyName("userId")]
    public int? UserId { get; set; }
    [JsonPropertyName("status")]
    public int? Status { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
    [JsonPropertyName("appKey")]
    public string? AppKey { get; set; }
    [JsonPropertyName("appSecret")]
    public string? AppSecret { get; set; }
    [JsonPropertyName("metadata")]
    public CommonMetadata? Metadata { get; set; }
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }
    [JsonPropertyName("scopes")]
    public List<string>? Scopes { get; set; }
    [JsonPropertyName("tokens")]
    public List<BackendToken>? Tokens { get; set; }
}
