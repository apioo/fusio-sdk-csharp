/**
 * SystemTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class SystemTag : TagAbstract {
    public SystemTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }

    public SystemConnectionTag Connection()
    {
        return new SystemConnectionTag(
            this.HttpClient,
            this.Parser
        );
    }

    public SystemMetaTag Meta()
    {
        return new SystemMetaTag(
            this.HttpClient,
            this.Parser
        );
    }

    public SystemPaymentTag Payment()
    {
        return new SystemPaymentTag(
            this.HttpClient,
            this.Parser
        );
    }


}
