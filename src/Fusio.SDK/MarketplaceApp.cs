/**
 * MarketplaceApp automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class MarketplaceApp : MarketplaceObject
{
    [JsonPropertyName("scopes")]
    public List<string>? Scopes { get; set; }
    [JsonPropertyName("downloadUrl")]
    public string? DownloadUrl { get; set; }
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
}