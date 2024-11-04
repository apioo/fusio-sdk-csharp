/**
 * SystemPaymentTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class SystemPaymentTag : TagAbstract {
    public SystemPaymentTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<CommonMessage> Webhook(string provider)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("provider", provider);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/system/payment/:provider/webhook", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<CommonMessage>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        if (statusCode == 500)
        {
            var data = this.Parser.Parse<CommonMessage>(response.Content);

            throw new CommonMessageException(data);
        }

        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }


}
