/**
 * ConsumerLog automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class ConsumerLog
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    [JsonPropertyName("appId")]
    public int? AppId { get; set; }
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
    [JsonPropertyName("userAgent")]
    public string? UserAgent { get; set; }
    [JsonPropertyName("method")]
    public string? Method { get; set; }
    [JsonPropertyName("path")]
    public string? Path { get; set; }
    [JsonPropertyName("header")]
    public string? Header { get; set; }
    [JsonPropertyName("body")]
    public string? Body { get; set; }
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }
}