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
        try
        {
            Dictionary<string, object> pathParams = new Dictionary<string, object>();
            pathParams.Add("provider", provider);

            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            List<string> queryStructNames = new List<string>();

            RestRequest request = new RestRequest(this.Parser.Url("/system/payment/:provider/webhook", pathParams), Method.Post);
            this.Parser.Query(request, queryParams, queryStructNames);

            RestResponse response = await this.HttpClient.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return this.Parser.Parse<CommonMessage>(response.Content);
            }

            switch ((int) response.StatusCode)
            {
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