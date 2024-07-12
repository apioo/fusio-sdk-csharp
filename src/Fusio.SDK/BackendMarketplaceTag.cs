/**
 * BackendMarketplaceTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendMarketplaceTag : TagAbstract {
    public BackendMarketplaceTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }

    public BackendMarketplaceAppTag App()
    {
        return new BackendMarketplaceAppTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendMarketplaceActionTag Action()
    {
        return new BackendMarketplaceActionTag(
            this.HttpClient,
            this.Parser
        );
    }


}
