/**
 * BackendSchemaTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendSchemaTag : TagAbstract {
    public BackendSchemaTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<CommonMessage> Create(BackendSchemaCreate payload)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/schema", pathParams), Method.Post);
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
    public async Task<CommonMessage> Delete(string schemaId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("schema_id", schemaId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/schema/$schema_id<[0-9]+|^~>", pathParams), Method.Delete);
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
    public async Task<BackendSchema> Get(string schemaId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("schema_id", schemaId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/schema/$schema_id<[0-9]+|^~>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendSchema>(response.Content);

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
    public async Task<BackendSchemaCollection> GetAll(int startIndex, int count, string search)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("count", count);
        queryParams.Add("search", search);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/schema", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendSchemaCollection>(response.Content);

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
    public async Task<BackendSchemaPreviewResponse> GetPreview(string schemaId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("schema_id", schemaId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/schema/preview/:schema_id", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<BackendSchemaPreviewResponse>(response.Content);

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
    public async Task<CommonMessage> Update(string schemaId, BackendSchemaUpdate payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("schema_id", schemaId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/schema/$schema_id<[0-9]+|^~>", pathParams), Method.Put);
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
    public async Task<CommonMessage> UpdateForm(string schemaId, BackendSchemaForm payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("schema_id", schemaId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/schema/form/$schema_id<[0-9]+>", pathParams), Method.Put);
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
