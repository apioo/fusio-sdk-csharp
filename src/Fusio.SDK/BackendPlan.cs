/**
 * BackendPlan automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

/// <summary>
/// This object represents a plan, a plan allows users to obtain points or in general subscribe to your app
/// </summary>
public class BackendPlan
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("price")]
    public double? Price { get; set; }

    [JsonPropertyName("points")]
    public int? Points { get; set; }

    [JsonPropertyName("period")]
    public int? Period { get; set; }

    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("scopes")]
    public System.Collections.Generic.List<string>? Scopes { get; set; }

    [JsonPropertyName("metadata")]
    public CommonMetadata? Metadata { get; set; }

}

