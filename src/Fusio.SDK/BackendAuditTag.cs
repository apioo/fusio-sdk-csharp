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
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("audit_id", auditId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/audit/$audit_id<[0-9]+>", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendAudit>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
                case 401:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                case 404:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                case 410:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                case 500:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                default:
                    throw new UnknownStatusCodeException("The server returned an unknown status code");
            }
        }
        catch (ClientException e)
        {
            throw e;
        }
        catch (System.Exception e)
        {
            throw new ClientException("An unknown error occurred: " + e.Message, e);
        }
    }

    public async Task<BackendAuditCollection> GetAll(int startIndex, int count, string search, string from, string to, int appId, int userId, string _event, string ip, string message)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();

            Dictionary<string, object> queryParams = new Dictionary<string, object>();
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

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/audit", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendAuditCollection>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
                case 401:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                case 500:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                default:
                    throw new UnknownStatusCodeException("The server returned an unknown status code");
            }
        }
        catch (ClientException e)
        {
            throw e;
        }
        catch (System.Exception e)
        {
            throw new ClientException("An unknown error occurred: " + e.Message, e);
        }
    }


}
