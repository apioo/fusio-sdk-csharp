/**
 * BackendTokenTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendTokenTag : TagAbstract {
    public BackendTokenTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns a specific token
     */
    public async Task<BackendToken> Get(string tokenId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("token_id", tokenId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/token/$token_id<[0-9]+>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendToken>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        if (statusCode >= 0 && statusCode <= 999)
        {
            var data = this.Parser.Parse<CommonMessage>(response.Content);

            throw new CommonMessageException(data);
        }

        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }
    /**
     * Returns a paginated list of tokens
     */
    public async Task<BackendTokenCollection> GetAll(int startIndex, int count, string search, string from, string to, int appId, int userId, int status, string scope, string ip)
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
        queryParams.Add("status", status);
        queryParams.Add("scope", scope);
        queryParams.Add("ip", ip);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/token", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendTokenCollection>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        if (statusCode >= 0 && statusCode <= 999)
        {
            var data = this.Parser.Parse<CommonMessage>(response.Content);

            throw new CommonMessageException(data);
        }

        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }


}
