/**
 * BackendIdentityIndex automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendIdentityIndex
{
    [JsonPropertyName("providers")]
    public List<BackendIdentityIndexEntry>? Providers { get; set; }
}
