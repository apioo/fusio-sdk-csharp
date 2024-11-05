/**
 * BackendAudit automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class BackendAudit
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("app")]
    public BackendApp? App { get; set; }

    [JsonPropertyName("user")]
    public BackendUser? User { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("content")]
    public BackendAuditObject? Content { get; set; }

    [JsonPropertyName("date")]
    public System.DateTime? Date { get; set; }

}

