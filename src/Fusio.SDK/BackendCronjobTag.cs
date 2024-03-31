/**
 * BackendCronjobTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendCronjobTag : TagAbstract {
    public BackendCronjobTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<CommonMessage> Delete(string cronjobId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("cronjob_id", cronjobId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/cronjob/$cronjob_id<[0-9]+|^~>", pathParams), Method.Delete);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<CommonMessage>(response.Content);
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
        };
    }

    public async Task<CommonMessage> Update(string cronjobId, BackendCronjobUpdate payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("cronjob_id", cronjobId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/cronjob/$cronjob_id<[0-9]+|^~>", pathParams), Method.Put);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<CommonMessage>(response.Content);
        }

        if (response.ErrorException != null)
        {
            throw new ClientException("An unknown error occurred: " + response.ErrorException.Message, response.ErrorException);
        }

        throw (int) response.StatusCode switch
        {
            400 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            404 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            410 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendCronjob> Get(string cronjobId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("cronjob_id", cronjobId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/cronjob/$cronjob_id<[0-9]+|^~>", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendCronjob>(response.Content);
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
        };
    }

    public async Task<CommonMessage> Create(BackendCronjobCreate payload)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/cronjob", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<CommonMessage>(response.Content);
        }

        if (response.ErrorException != null)
        {
            throw new ClientException("An unknown error occurred: " + response.ErrorException.Message, response.ErrorException);
        }

        throw (int) response.StatusCode switch
        {
            400 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendCronjobCollection> GetAll(int startIndex, int count, string search)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("count", count);
        queryParams.Add("search", search);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/cronjob", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendCronjobCollection>(response.Content);
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
        };
    }


}
