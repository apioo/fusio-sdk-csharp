/**
 * BackendTest automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class BackendTest
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("status")]
    public int? Status { get; set; }

    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("response")]
    public string? Response { get; set; }

    [JsonPropertyName("config")]
    public BackendTestConfig? Config { get; set; }

}

