/**
 * BackendTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace Fusio.SDK;

public class BackendTag : TagAbstract {
    public BackendTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }

    public BackendWebhookTag Webhook()
    {
        return new BackendWebhookTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendUserTag User()
    {
        return new BackendUserTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendTrashTag Trash()
    {
        return new BackendTrashTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendTransactionTag Transaction()
    {
        return new BackendTransactionTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendTokenTag Token()
    {
        return new BackendTokenTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendTestTag Test()
    {
        return new BackendTestTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendTenantTag Tenant()
    {
        return new BackendTenantTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendStatisticTag Statistic()
    {
        return new BackendStatisticTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendSdkTag Sdk()
    {
        return new BackendSdkTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendScopeTag Scope()
    {
        return new BackendScopeTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendSchemaTag Schema()
    {
        return new BackendSchemaTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendOperationTag Operation()
    {
        return new BackendOperationTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendRoleTag Role()
    {
        return new BackendRoleTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendRateTag Rate()
    {
        return new BackendRateTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendPlanTag Plan()
    {
        return new BackendPlanTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendPageTag Page()
    {
        return new BackendPageTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendMarketplaceTag Marketplace()
    {
        return new BackendMarketplaceTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendLogTag Log()
    {
        return new BackendLogTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendIdentityTag Identity()
    {
        return new BackendIdentityTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendGeneratorTag Generator()
    {
        return new BackendGeneratorTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendBackupTag Backup()
    {
        return new BackendBackupTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendEventTag Event()
    {
        return new BackendEventTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendDatabaseTag Database()
    {
        return new BackendDatabaseTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendDashboardTag Dashboard()
    {
        return new BackendDashboardTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendCronjobTag Cronjob()
    {
        return new BackendCronjobTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendConnectionTag Connection()
    {
        return new BackendConnectionTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendConfigTag Config()
    {
        return new BackendConfigTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendCategoryTag Category()
    {
        return new BackendCategoryTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendAuditTag Audit()
    {
        return new BackendAuditTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendAppTag App()
    {
        return new BackendAppTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendActionTag Action()
    {
        return new BackendActionTag(
            this.HttpClient,
            this.Parser
        );
    }

    public BackendAccountTag Account()
    {
        return new BackendAccountTag(
            this.HttpClient,
            this.Parser
        );
    }


}
