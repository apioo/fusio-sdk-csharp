/**
 * BackendStatisticTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendStatisticTag : TagAbstract {
    public BackendStatisticTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<BackendStatisticChart> GetUsedPoints(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/used_points", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetTimePerOperation(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/time_per_operation", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetTimeAverage(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/time_average", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetTestCoverage()
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/backend/statistic/test_coverage", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetMostUsedOperations(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/most_used_operations", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetMostUsedApps(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/most_used_apps", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetIssuedTokens(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/issued_tokens", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetIncomingTransactions(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/incoming_transactions", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetIncomingRequests(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/incoming_requests", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticChart> GetErrorsPerOperation(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/errors_per_operation", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticChart>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    public async Task<BackendStatisticCount> GetCountRequests(int startIndex, int count, string search, string from, string to, int operationId, int appId, int userId, string ip, string userAgent, string method, string path, string header, string body)
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

        RestRequest request = new(this.Parser.Url("/backend/statistic/count_requests", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<BackendStatisticCount>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            401 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            500 => new CommonMessageException(this.Parser.Parse<CommonMessage>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}
