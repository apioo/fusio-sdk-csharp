/**
 * Client automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Credentials;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class Client : ClientAbstract
{
    public Client(string baseUrl, ICredentials credentials) : base(baseUrl, credentials)
    {
    }

    public AuthorizationTag Authorization()
    {
        return new AuthorizationTag(
            this.HttpClient,
            this.Parser
        );
    }

    public SystemTag System()
    {
        return new SystemTag(
            this.HttpClient,
            this.Parser
        );
    }

    public ConsumerTag Consumer()
    {
        return new ConsumerTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendTag Backend()
    {
        return new BackendTag(
            this.HttpClient,
            this.Parser
        );
    }



    public static Client Build(string clientId, string clientSecret, ITokenStore tokenStore, List<string> scopes)
    {
        return new Client("http://127.0.0.1/", new OAuth2(clientId, clientSecret, "http://127.0.0.1/authorization/token", "", tokenStore, scopes));
    }
}
