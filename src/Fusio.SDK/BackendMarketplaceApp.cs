/**
 * BackendMarketplaceApp automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendMarketplaceApp
{
    [JsonPropertyName("version")]
    public string Version { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("screenshot")]
    public string Screenshot { get; set; }
    [JsonPropertyName("website")]
    public string Website { get; set; }
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }
    [JsonPropertyName("sha1Hash")]
    public string ShaHash { get; set; }
    [JsonPropertyName("startUrl")]
    public string StartUrl { get; set; }
}
