/**
 * BackendDashboard automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace Fusio.SDK;

public class BackendDashboard
{
    [JsonPropertyName("errorsPerOperation")]
    public BackendStatisticChart? ErrorsPerOperation { get; set; }

    [JsonPropertyName("incomingRequests")]
    public BackendStatisticChart? IncomingRequests { get; set; }

    [JsonPropertyName("incomingTransactions")]
    public BackendStatisticChart? IncomingTransactions { get; set; }

    [JsonPropertyName("mostUsedOperations")]
    public BackendStatisticChart? MostUsedOperations { get; set; }

    [JsonPropertyName("timePerOperation")]
    public BackendStatisticChart? TimePerOperation { get; set; }

    [JsonPropertyName("testCoverage")]
    public BackendStatisticChart? TestCoverage { get; set; }

    [JsonPropertyName("mostUsedActivities")]
    public BackendStatisticChart? MostUsedActivities { get; set; }

    [JsonPropertyName("activitiesPerUser")]
    public BackendStatisticChart? ActivitiesPerUser { get; set; }

    [JsonPropertyName("userRegistrations")]
    public BackendStatisticChart? UserRegistrations { get; set; }

}

