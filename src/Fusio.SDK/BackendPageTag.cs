/**
 * BackendPageTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendPageTag : TagAbstract {
    public BackendPageTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Creates a new page
     */
    public async Task<CommonMessage> Create(BackendPageCreate payload)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/page", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        request.AddOrUpdateHeader("Content-Type", "application/json");

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<CommonMessage>(response.Content);

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
     * Deletes an existing page
     */
    public async Task<CommonMessage> Delete(string pageId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("page_id", pageId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/page/$page_id<[0-9]+|^~>", pathParams), Method.Delete);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<CommonMessage>(response.Content);

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
     * Returns a specific page
     */
    public async Task<BackendPage> Get(string pageId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("page_id", pageId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/page/$page_id<[0-9]+|^~>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendPage>(response.Content);

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
     * Returns a paginated list of pages
     */
    public async Task<BackendPageCollection> GetAll(int startIndex, int count, string search)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("count", count);
        queryParams.Add("search", search);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/page", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendPageCollection>(response.Content);

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
     * Updates an existing page
     */
    public async Task<CommonMessage> Update(string pageId, BackendPageUpdate payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("page_id", pageId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/page/$page_id<[0-9]+|^~>", pathParams), Method.Put);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        request.AddOrUpdateHeader("Content-Type", "application/json");

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<CommonMessage>(response.Content);

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
