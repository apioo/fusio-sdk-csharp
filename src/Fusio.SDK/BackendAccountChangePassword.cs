/**
 * BackendAccountChangePassword automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class BackendAccountChangePassword
{
    [JsonPropertyName("oldPassword")]
    public string OldPassword { get; set; }
    [JsonPropertyName("newPassword")]
    public string NewPassword { get; set; }
    [JsonPropertyName("verifyPassword")]
    public string VerifyPassword { get; set; }
}
