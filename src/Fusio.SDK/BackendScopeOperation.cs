/**
 * BackendScopeOperation automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class BackendScopeOperation
{
    [JsonPropertyName("operationId")]
    public int? OperationId { get; set; }

    [JsonPropertyName("allow")]
    public bool? Allow { get; set; }

}

