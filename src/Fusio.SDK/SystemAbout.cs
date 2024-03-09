/**
 * SystemAbout automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace Fusio.SDK;
public class SystemAbout
{
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("termsOfService")]
    public string TermsOfService { get; set; }
    [JsonPropertyName("contactName")]
    public string ContactName { get; set; }
    [JsonPropertyName("contactUrl")]
    public string ContactUrl { get; set; }
    [JsonPropertyName("contactEmail")]
    public string ContactEmail { get; set; }
    [JsonPropertyName("licenseName")]
    public string LicenseName { get; set; }
    [JsonPropertyName("licenseUrl")]
    public string LicenseUrl { get; set; }
    [JsonPropertyName("paymentCurrency")]
    public string PaymentCurrency { get; set; }
    [JsonPropertyName("categories")]
    public List<string> Categories { get; set; }
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }
    [JsonPropertyName("apps")]
    public SystemAboutApps Apps { get; set; }
    [JsonPropertyName("links")]
    public List<SystemAboutLink> Links { get; set; }
}
