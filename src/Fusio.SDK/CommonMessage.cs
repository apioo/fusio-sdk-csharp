/**
 * CommonMessage automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

/// <summary>
/// Common error message
/// </summary>
public class CommonMessage
{
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

}

