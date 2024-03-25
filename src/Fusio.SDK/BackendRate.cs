/**
 * BackendRate automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendRate
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("rateLimit")]
    public int? RateLimit { get; set; }
    [JsonPropertyName("timespan")]
    public TimeSpan? Timespan { get; set; }
    [JsonPropertyName("allocation")]
    public List<BackendRateAllocation>? Allocation { get; set; }
    [JsonPropertyName("metadata")]
    public CommonMetadata? Metadata { get; set; }
}
