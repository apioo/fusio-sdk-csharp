/**
 * BackendActionExecuteResponse automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class BackendActionExecuteResponse
{
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }

    [JsonPropertyName("headers")]
    public BackendActionExecuteResponseHeaders? Headers { get; set; }

    [JsonPropertyName("body")]
    public BackendActionExecuteResponseBody? Body { get; set; }

}

