/**
 * BackendStatisticChartSeries automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class BackendStatisticChartSeries
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("data")]
    public System.Collections.Generic.List<double>? Data { get; set; }

}

