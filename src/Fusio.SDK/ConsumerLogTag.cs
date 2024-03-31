/**
 * ConsumerLogTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class ConsumerLogTag : TagAbstract {
    public ConsumerLogTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<ConsumerLog> Get(string logId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("log_id", logId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/consumer/log/$log_id<[0-9]+>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<ConsumerLog>(response.Content);
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

    public async Task<ConsumerLogCollection> GetAll(int startIndex, int count, string search)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("count", count);
        queryParams.Add("search", search);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/consumer/log", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<ConsumerLogCollection>(response.Content);
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
