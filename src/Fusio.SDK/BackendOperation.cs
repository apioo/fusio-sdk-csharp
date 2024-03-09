/**
 * BackendOperation automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendOperation
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
    [JsonPropertyName("active")]
    public bool Active { get; set; }
    [JsonPropertyName("public")]
    public bool Public { get; set; }
    [JsonPropertyName("stability")]
    public int Stability { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("httpMethod")]
    public string HttpMethod { get; set; }
    [JsonPropertyName("httpPath")]
    public string HttpPath { get; set; }
    [JsonPropertyName("httpCode")]
    public int HttpCode { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("parameters")]
    public BackendOperationParameters Parameters { get; set; }
    [JsonPropertyName("incoming")]
    public string Incoming { get; set; }
    [JsonPropertyName("outgoing")]
    public string Outgoing { get; set; }
    [JsonPropertyName("throws")]
    public BackendOperationThrows Throws { get; set; }
    [JsonPropertyName("action")]
    public string Action { get; set; }
    [JsonPropertyName("costs")]
    public int Costs { get; set; }
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }
    [JsonPropertyName("metadata")]
    public CommonMetadata Metadata { get; set; }
}
