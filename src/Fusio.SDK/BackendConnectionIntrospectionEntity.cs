/**
 * BackendConnectionIntrospectionEntity automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendConnectionIntrospectionEntity
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("headers")]
    public List<string>? Headers { get; set; }
    [JsonPropertyName("rows")]
    public List<BackendConnectionIntrospectionEntityRow>? Rows { get; set; }
}