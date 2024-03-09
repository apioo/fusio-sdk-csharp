/**
 * BackendConnectionTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendConnectionTag : TagAbstract {
    public BackendConnectionTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<BackendConnectionIntrospectionEntity> GetIntrospectionForEntity(string connectionId, string entity)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("connection_id", connectionId);
            pathParams.Add("entity", entity);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/$connection_id<[0-9]+|^~>/introspection/:entity", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendConnectionIntrospectionEntity>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
                case 401:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                case 404:
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

    public async Task<BackendConnectionIntrospectionEntities> GetIntrospection(string connectionId)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("connection_id", connectionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/$connection_id<[0-9]+|^~>/introspection", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendConnectionIntrospectionEntities>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
                case 401:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                case 404:
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

    public async Task<CommonMessage> GetRedirect(string connectionId)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("connection_id", connectionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/$connection_id<[0-9]+|^~>/redirect", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<CommonMessage>(response.Content);
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

    public async Task<CommonMessage> Delete(string connectionId)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("connection_id", connectionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/$connection_id<[0-9]+|^~>", pathParams), Method.Delete);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<CommonMessage>(response.Content);
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

    public async Task<CommonMessage> Update(string connectionId, BackendConnectionUpdate payload)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("connection_id", connectionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/$connection_id<[0-9]+|^~>", pathParams), Method.Put);
            this.Parser.Query(request, queryParams, queryStructNames);
            request.AddJsonBody(JsonSerializer.Serialize(payload));

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<CommonMessage>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
                case 400:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
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

    public async Task<BackendConnection> Get(string connectionId)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("connection_id", connectionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/$connection_id<[0-9]+|^~>", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendConnection>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
                case 404:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
                case 401:
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

    public async Task<CommonFormContainer> GetForm(string _class)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();

            Dictionary<string, object> queryParams = new Dictionary<string, object>();
            queryParams.Add("class", _class);

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/form", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<CommonFormContainer>(response.Content);
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

    public async Task<BackendConnectionIndex> GetClasses()
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection/list", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendConnectionIndex>(response.Content);
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

    public async Task<CommonMessage> Create(BackendConnectionCreate payload)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection", pathParams), Method.Post);
            this.Parser.Query(request, queryParams, queryStructNames);
            request.AddJsonBody(JsonSerializer.Serialize(payload));

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<CommonMessage>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
                case 400:
                    throw new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content));
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

    public async Task<BackendConnectionCollection> GetAll(int startIndex, int count, string search)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();

            Dictionary<string, object> queryParams = new Dictionary<string, object>();
            queryParams.Add("startIndex", startIndex);
            queryParams.Add("count", count);
            queryParams.Add("search", search);

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/backend/connection", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<BackendConnectionCollection>(response.Content);
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
