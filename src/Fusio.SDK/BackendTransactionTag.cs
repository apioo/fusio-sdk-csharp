/**
 * BackendTransactionTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendTransactionTag : TagAbstract {
    public BackendTransactionTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<BackendTransaction> Get(string transactionId)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("transaction_id", transactionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/transaction/$transaction_id<[0-9]+>", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendTransaction>(response.Content);
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

    public async Task<BackendTransactionCollection> GetAll(int startIndex, int count, string search, string from, string to, int planId, int userId, int appId, string status, string provider)
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
            queryParams.Add("planId", planId);
            queryParams.Add("userId", userId);
            queryParams.Add("appId", appId);
            queryParams.Add("status", status);
            queryParams.Add("provider", provider);

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/transaction", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendTransactionCollection>(response.Content);
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
