/**
 * BackendUser automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendUser
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("roleId")]
    public int RoleId { get; set; }
    [JsonPropertyName("planId")]
    public int PlanId { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("points")]
    public int Points { get; set; }
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }
    [JsonPropertyName("apps")]
    public List<BackendApp> Apps { get; set; }
    [JsonPropertyName("metadata")]
    public CommonMetadata Metadata { get; set; }
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }
}
