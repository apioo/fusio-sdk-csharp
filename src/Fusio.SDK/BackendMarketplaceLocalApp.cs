/**
 * BackendMarketplaceLocalApp automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendMarketplaceLocalApp : BackendMarketplaceApp
{
    [JsonPropertyName("remote")]
    public BackendMarketplaceApp? Remote { get; set; }
}
