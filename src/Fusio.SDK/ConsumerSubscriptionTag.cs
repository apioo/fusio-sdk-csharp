/**
 * ConsumerSubscriptionTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class ConsumerSubscriptionTag : TagAbstract {
    public ConsumerSubscriptionTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<CommonMessage> Delete(string subscriptionId)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("subscription_id", subscriptionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/consumer/subscription/$subscription_id<[0-9]+>", pathParams), Method.Delete);
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

    public async Task<CommonMessage> Update(string subscriptionId, ConsumerEventSubscriptionUpdate payload)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("subscription_id", subscriptionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/consumer/subscription/$subscription_id<[0-9]+>", pathParams), Method.Put);
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

    public async Task<ConsumerEventSubscription> Get(string subscriptionId)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("subscription_id", subscriptionId);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/consumer/subscription/$subscription_id<[0-9]+>", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<ConsumerEventSubscription>(response.Content);
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

    public async Task<CommonMessage> Create(ConsumerEventSubscriptionCreate payload)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/consumer/subscription", pathParams), Method.Post);
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

    public async Task<ConsumerEventSubscriptionCollection> GetAll(int startIndex, int count, string search)
    {
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();

            Dictionary<string, object> queryParams = new Dictionary<string, object>();
            queryParams.Add("startIndex", startIndex);
            queryParams.Add("count", count);
            queryParams.Add("search", search);

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/consumer/subscription", pathParams), Method.Get);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<ConsumerEventSubscriptionCollection>(response.Content);
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
