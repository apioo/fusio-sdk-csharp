/**
 * ConsumerUserEmail automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class ConsumerUserEmail
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("captcha")]
    public string? Captcha { get; set; }

}

