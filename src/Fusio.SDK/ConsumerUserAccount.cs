/**
 * ConsumerUserAccount automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class ConsumerUserAccount
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("planId")]
    public int? PlanId { get; set; }

    [JsonPropertyName("status")]
    public int? Status { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("points")]
    public int? Points { get; set; }

    [JsonPropertyName("scopes")]
    public System.Collections.Generic.List<string>? Scopes { get; set; }

    [JsonPropertyName("plans")]
    public System.Collections.Generic.List<ConsumerUserPlan>? Plans { get; set; }

    [JsonPropertyName("metadata")]
    public CommonMetadata? Metadata { get; set; }

    [JsonPropertyName("date")]
    public System.DateTime? Date { get; set; }

}

