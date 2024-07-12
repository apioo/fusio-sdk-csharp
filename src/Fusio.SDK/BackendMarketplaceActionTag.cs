/**
 * BackendMarketplaceActionTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendMarketplaceActionTag : TagAbstract {
    public BackendMarketplaceActionTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<CommonMessage> Upgrade(string user, string name)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user", user);
        pathParams.Add("name", name);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/marketplace/action/:user/:name", pathParams), Method.Put);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<CommonMessage>(response.Content);
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

    public async Task<MarketplaceAction> Get(string user, string name)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("user", user);
        pathParams.Add("name", name);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/marketplace/action/:user/:name", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<MarketplaceAction>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            404 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            410 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            500 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<MarketplaceMessage> Install(MarketplaceInstall payload)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/marketplace/action", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<MarketplaceMessage>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            400 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            401 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            500 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<MarketplaceActionCollection> GetAll(int startIndex, string query)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("query", query);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/marketplace/action", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<MarketplaceActionCollection>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            500 => new MarketplaceMessageException(this.Parser.Parse<MarketplaceMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}
