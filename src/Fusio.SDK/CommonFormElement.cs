/**
 * CommonFormElement automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class CommonFormElement
{
    [JsonPropertyName("element")]
    public string? Element { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("help")]
    public string? Help { get; set; }
}
