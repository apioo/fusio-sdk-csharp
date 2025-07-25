/**
 * BackendLogTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendLogTag : TagAbstract {
    public BackendLogTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns a specific log
     */
    public async Task<BackendLog> Get(string logId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("log_id", logId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/log/$log_id<[0-9]+>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendLog>(response.Content);

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
     * Returns a paginated list of logs
     */
    public async Task<BackendLogCollection> GetAll(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("count", count);
        queryParams.Add("search", search);
        queryParams.Add("from", from);
        queryParams.Add("to", to);
        queryParams.Add("operationId", operationId);
        queryParams.Add("appId", appId);
        queryParams.Add("userId", userId);
        queryParams.Add("ip", ip);
        queryParams.Add("userAgent", userAgent);
        queryParams.Add("method", method);
        queryParams.Add("path", path);
        queryParams.Add("header", header);
        queryParams.Add("body", body);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/log", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendLogCollection>(response.Content);

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
     * Returns a paginated list of log errors
     */
    public async Task<BackendLogErrorCollection> GetAllErrors(int startIndex, int count, string search)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("count", count);
        queryParams.Add("search", search);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/log/error", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendLogErrorCollection>(response.Content);

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
     * Returns a specific error
     */
    public async Task<BackendLogError> GetError(string errorId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("error_id", errorId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/log/error/$error_id<[0-9]+>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendLogError>(response.Content);

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
