/**
 * BackendBackupImport automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

/// <summary>
/// Import a previously exported system configuration
/// </summary>
public class BackendBackupImport
{
    [JsonPropertyName("import")]
    public string? Import { get; set; }

}

