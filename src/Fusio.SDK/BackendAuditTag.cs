/**
 * BackendAuditTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendAuditTag : TagAbstract {
    public BackendAuditTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<BackendAudit> Get(string auditId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("audit_id", auditId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/audit/$audit_id<[0-9]+>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendAudit>(response.Content);
        }

        if (response.ErrorException != null)
        {
            throw new ClientException("An unknown error occurred: " + response.ErrorException.Message, response.ErrorException);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            404 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            410 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        }
    }

    public async Task<BackendAuditCollection> GetAll(int startIndex, int count, string search, string from, string to, int appId, int userId, string _event, string ip, string message)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("count", count);
        queryParams.Add("search", search);
        queryParams.Add("from", from);
        queryParams.Add("to", to);
        queryParams.Add("appId", appId);
        queryParams.Add("userId", userId);
        queryParams.Add("event", _event);
        queryParams.Add("ip", ip);
        queryParams.Add("message", message);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/audit", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendAuditCollection>(response.Content);
        }

        if (response.ErrorException != null)
        {
            throw new ClientException("An unknown error occurred: " + response.ErrorException.Message, response.ErrorException);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        }
    }


}
