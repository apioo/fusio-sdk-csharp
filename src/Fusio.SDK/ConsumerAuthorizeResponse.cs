/**
 * ConsumerAuthorizeResponse automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class ConsumerAuthorizeResponse
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("token")]
    public ConsumerAuthorizeResponseToken? Token { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }

}

