
# fusio-sdk-csharp

This [SDK](https://github.com/apioo/fusio-sdk-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/fusio/sdk

## Usage

```csharp
using Fusio.SDK.Client;

Client client = Client.Build("[access_token]")

// Returns user data of the current authenticated user.
BackendUser response = client.Authorization().Getwhoami();

// Revoke the access token of the current authenticated user.
CommonMessage response = client.Authorization().Revoke();

// Changes the password of the authenticated user.
CommonMessage response = client.Backend().AccountChangepassword(new BackendAccountchangepassword());

// Returns user data of the authenticated user.
BackendUser response = client.Backend().AccountGet();

// Updates user data of the authenticated user.
CommonMessage response = client.Backend().AccountUpdate(new BackendUserupdate());

// Creates a new action.
CommonMessage response = client.Backend().ActionCreate(new BackendActioncreate());

// Deletes an existing action.
CommonMessage response = client.Backend().ActionDelete("action_id");

// Executes a specific action.
BackendActionexecuteresponse response = client.Backend().ActionExecute("action_id", new BackendActionexecuterequest());

// Returns a specific action.
BackendAction response = client.Backend().ActionGet("action_id");

// Returns a paginated list of actions.
BackendActioncollection response = client.Backend().ActionGetall(1, 1, "search");

// Returns all available action classes.
BackendActionindex response = client.Backend().ActionGetclasses();

// Returns a paginated list of action commits.
BackendActioncommitcollection response = client.Backend().ActionGetcommits("action_id", 1, 1, "search");

// Returns the action config form.
CommonFormcontainer response = client.Backend().ActionGetform("class");

// Updates an existing action.
CommonMessage response = client.Backend().ActionUpdate("action_id", new BackendActionupdate());

// Creates a new agent.
CommonMessage response = client.Backend().AgentCreate(new BackendAgentcreate());

// Deletes an existing agent.
CommonMessage response = client.Backend().AgentDelete("agent_id");

// Returns a specific agent.
BackendAgent response = client.Backend().AgentGet("agent_id");

// Returns a paginated list of agents.
BackendAgentcollection response = client.Backend().AgentGetall(1, 1, "search");

// Returns available tools for an agent.
BackendAgenttools response = client.Backend().AgentGettools();

// Returns a paginated list of agent messages.
BackendAgentmessagecollection response = client.Backend().AgentMessageGetall("agent_id", "chat_id");

// Submits a new agent message.
AgentOutput response = client.Backend().AgentMessageSubmit("agent_id", new AgentInput());

// Updates an existing agent.
CommonMessage response = client.Backend().AgentUpdate("agent_id", new BackendAgentupdate());

// Creates a new app.
CommonMessage response = client.Backend().AppCreate(new BackendAppcreate());

// Deletes an existing app.
CommonMessage response = client.Backend().AppDelete("app_id");

// Deletes an existing token from an app.
CommonMessage response = client.Backend().AppDeletetoken("app_id", "token_id");

// Returns a specific app.
BackendApp response = client.Backend().AppGet("app_id");

// Returns a paginated list of apps.
BackendAppcollection response = client.Backend().AppGetall(1, 1, "search");

// Updates an existing app.
CommonMessage response = client.Backend().AppUpdate("app_id", new BackendAppupdate());

// Returns a specific audit.
BackendAudit response = client.Backend().AuditGet("audit_id");

// Returns a paginated list of audits.
BackendAuditcollection response = client.Backend().AuditGetall(1, 1, "search", "from", "to", 1, 1, "event", "ip", "message");

// Generates an backup of the current system.
BackendBackupexport response = client.Backend().BackupExport();

// Imports an backup to the current system.
BackendBackupimportresult response = client.Backend().BackupImport(new BackendBackupimport());

// Creates a new bundle.
CommonMessage response = client.Backend().BundleCreate(new BackendBundlecreate());

// Deletes an existing bundle.
CommonMessage response = client.Backend().BundleDelete("bundle_id");

// Returns a specific bundle.
BackendBundle response = client.Backend().BundleGet("bundle_id");

// Returns a paginated list of bundles.
BackendBundlecollection response = client.Backend().BundleGetall(1, 1, "search");

// Publish an existing bundle to the marketplace.
CommonMessage response = client.Backend().BundlePublish("bundle_id");

// Updates an existing bundle.
CommonMessage response = client.Backend().BundleUpdate("bundle_id", new BackendBundleupdate());

// Creates a new category.
CommonMessage response = client.Backend().CategoryCreate(new BackendCategorycreate());

// Deletes an existing category.
CommonMessage response = client.Backend().CategoryDelete("category_id");

// Returns a specific category.
BackendCategory response = client.Backend().CategoryGet("category_id");

// Returns a paginated list of categories.
BackendCategorycollection response = client.Backend().CategoryGetall(1, 1, "search");

// Updates an existing category.
CommonMessage response = client.Backend().CategoryUpdate("category_id", new BackendCategoryupdate());

// Returns a specific config.
BackendConfig response = client.Backend().ConfigGet("config_id");

// Returns a paginated list of configuration values.
BackendConfigcollection response = client.Backend().ConfigGetall(1, 1, "search");

// Updates an existing config value.
CommonMessage response = client.Backend().ConfigUpdate("config_id", new BackendConfigupdate());

// Sends a message to an agent.
AgentOutput response = client.Backend().ConnectionAgentSend("connection_id", new AgentInput());

// Creates a new connection.
CommonMessage response = client.Backend().ConnectionCreate(new BackendConnectioncreate());

// Creates a new row at a table on a database.
CommonMessage response = client.Backend().ConnectionDatabaseCreaterow("connection_id", "table_name", new BackendDatabaserow());

// Creates a new table on a database.
CommonMessage response = client.Backend().ConnectionDatabaseCreatetable("connection_id", new BackendDatabasetable());

// Deletes an existing row at a table on a database.
CommonMessage response = client.Backend().ConnectionDatabaseDeleterow("connection_id", "table_name", "id");

// Deletes an existing table on a database.
CommonMessage response = client.Backend().ConnectionDatabaseDeletetable("connection_id", "table_name");

// Returns a specific row at a table on a database.
BackendDatabaserow response = client.Backend().ConnectionDatabaseGetrow("connection_id", "table_name", "id");

// Returns paginated rows at a table on a database.
BackendDatabaserowcollection response = client.Backend().ConnectionDatabaseGetrows("connection_id", "table_name", 1, 1, "filterBy", "filterOp", "filterValue", "sortBy", "sortOrder", "columns");

// Returns the schema of a specific table on a database.
BackendDatabasetable response = client.Backend().ConnectionDatabaseGettable("connection_id", "table_name");

// Returns all available tables on a database.
BackendDatabasetablecollection response = client.Backend().ConnectionDatabaseGettables("connection_id", 1, 1);

// Updates an existing row at a table on a database.
CommonMessage response = client.Backend().ConnectionDatabaseUpdaterow("connection_id", "table_name", "id", new BackendDatabaserow());

// Updates an existing table on a database.
CommonMessage response = client.Backend().ConnectionDatabaseUpdatetable("connection_id", "table_name", new BackendDatabasetable());

// Deletes an existing connection.
CommonMessage response = client.Backend().ConnectionDelete("connection_id");

// Uploads one or more files on the filesystem connection.
CommonMessage response = client.Backend().ConnectionFilesystemCreate("connection_id", new object());

// Deletes an existing file on the filesystem connection.
CommonMessage response = client.Backend().ConnectionFilesystemDelete("connection_id", "file_id");

// Returns the content of the provided file id on the filesystem connection.
client.Backend().ConnectionFilesystemGet("connection_id", "file_id");

// Returns all available files on the filesystem connection.
BackendFilecollection response = client.Backend().ConnectionFilesystemGetall("connection_id", 1, 1);

// Updates an existing file on the filesystem connection.
CommonMessage response = client.Backend().ConnectionFilesystemUpdate("connection_id", "file_id", new object());

// Returns a specific connection.
BackendConnection response = client.Backend().ConnectionGet("connection_id");

// Returns a paginated list of connections.
BackendConnectioncollection response = client.Backend().ConnectionGetall(1, 1, "search", "class");

// Returns all available connection classes.
BackendConnectionindex response = client.Backend().ConnectionGetclasses();

// Returns the connection config form.
CommonFormcontainer response = client.Backend().ConnectionGetform("class");

// Returns a redirect url to start the OAuth2 authorization flow for the given connection.
BackendConnectionredirectresponse response = client.Backend().ConnectionGetredirect("connection_id");

// Sends an arbitrary HTTP request to the connection.
BackendHttpresponse response = client.Backend().ConnectionHttpExecute("connection_id", new BackendHttprequest());

// Returns the SDK specification.
Passthru response = client.Backend().ConnectionSdkGet("connection_id");

// Updates an existing connection.
CommonMessage response = client.Backend().ConnectionUpdate("connection_id", new BackendConnectionupdate());

// Creates a new cronjob.
CommonMessage response = client.Backend().CronjobCreate(new BackendCronjobcreate());

// Deletes an existing cronjob.
CommonMessage response = client.Backend().CronjobDelete("cronjob_id");

// Returns a specific cronjob.
BackendCronjob response = client.Backend().CronjobGet("cronjob_id");

// Returns a paginated list of cronjobs.
BackendCronjobcollection response = client.Backend().CronjobGetall(1, 1, "search", 1);

// Updates an existing cronjob.
CommonMessage response = client.Backend().CronjobUpdate("cronjob_id", new BackendCronjobupdate());

// Returns all available dashboard widgets.
BackendDashboard response = client.Backend().DashboardGetall();

// Creates a new event.
CommonMessage response = client.Backend().EventCreate(new BackendEventcreate());

// Deletes an existing event.
CommonMessage response = client.Backend().EventDelete("event_id");

// Returns a specific event.
BackendEvent response = client.Backend().EventGet("event_id");

// Returns a paginated list of events.
BackendEventcollection response = client.Backend().EventGetall(1, 1, "search", 1);

// Updates an existing event.
CommonMessage response = client.Backend().EventUpdate("event_id", new BackendEventupdate());

// Creates a new firewall rule.
CommonMessage response = client.Backend().FirewallCreate(new BackendFirewallcreate());

// Deletes an existing firewall rule.
CommonMessage response = client.Backend().FirewallDelete("firewall_id");

// Returns a specific firewall rule.
BackendFirewall response = client.Backend().FirewallGet("firewall_id");

// Returns a paginated list of firewall rules.
BackendFirewallcollection response = client.Backend().FirewallGetall(1, 1, "search");

// Updates an existing firewall rule.
CommonMessage response = client.Backend().FirewallUpdate("firewall_id", new BackendFirewallupdate());

// Creates a new form.
CommonMessage response = client.Backend().FormCreate(new BackendFormcreate());

// Deletes an existing form.
CommonMessage response = client.Backend().FormDelete("form_id");

// Returns a specific form.
BackendForm response = client.Backend().FormGet("form_id");

// Returns a paginated list of forms.
BackendFormcollection response = client.Backend().FormGetall(1, 1, "search");

// Updates an existing form.
CommonMessage response = client.Backend().FormUpdate("form_id", new BackendFormupdate());

// Executes a generator with the provided config.
CommonMessage response = client.Backend().GeneratorExecuteprovider("provider", new BackendGeneratorprovider());

// Generates a changelog of all potential changes if you execute this generator with the provided config.
BackendGeneratorproviderchangelog response = client.Backend().GeneratorGetchangelog("provider", new BackendGeneratorproviderconfig());

// Returns all available generator classes.
BackendGeneratorindexproviders response = client.Backend().GeneratorGetclasses();

// Returns the generator config form.
CommonFormcontainer response = client.Backend().GeneratorGetform("provider");

// Creates a new identity.
CommonMessage response = client.Backend().IdentityCreate(new BackendIdentitycreate());

// Deletes an existing identity.
CommonMessage response = client.Backend().IdentityDelete("identity_id");

// Returns a specific identity.
BackendIdentity response = client.Backend().IdentityGet("identity_id");

// Returns a paginated list of identities.
BackendIdentitycollection response = client.Backend().IdentityGetall(1, 1, "search");

// Returns all available identity classes.
BackendIdentityindex response = client.Backend().IdentityGetclasses();

// Returns the identity config form.
CommonFormcontainer response = client.Backend().IdentityGetform("class");

// Updates an existing identity.
CommonMessage response = client.Backend().IdentityUpdate("identity_id", new BackendIdentityupdate());

// Returns a specific log.
BackendLog response = client.Backend().LogGet("log_id");

// Returns a paginated list of logs.
BackendLogcollection response = client.Backend().LogGetall(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a paginated list of log errors.
BackendLogerrorcollection response = client.Backend().LogGetallerrors(1, 1, "search");

// Returns a specific error.
BackendLogerror response = client.Backend().LogGeterror("error_id");

// Returns a specific marketplace action.
Marketplaceaction response = client.Backend().MarketplaceActionGet("user", "name");

// Returns a paginated list of marketplace actions.
Marketplaceactioncollection response = client.Backend().MarketplaceActionGetall(1, "query");

// Installs an action from the marketplace.
Marketplacemessage response = client.Backend().MarketplaceActionInstall(new Marketplaceinstall());

// Upgrades an action from the marketplace.
CommonMessage response = client.Backend().MarketplaceActionUpgrade("user", "name");

// Returns a specific marketplace app.
Marketplaceapp response = client.Backend().MarketplaceAppGet("user", "name");

// Returns a paginated list of marketplace apps.
Marketplaceappcollection response = client.Backend().MarketplaceAppGetall(1, "query");

// Installs an app from the marketplace.
Marketplacemessage response = client.Backend().MarketplaceAppInstall(new Marketplaceinstall());

// Upgrades an app from the marketplace.
Marketplacemessage response = client.Backend().MarketplaceAppUpgrade("user", "name");

// Returns a specific marketplace bundle.
Marketplacebundle response = client.Backend().MarketplaceBundleGet("user", "name");

// Returns a paginated list of marketplace bundles.
Marketplacebundlecollection response = client.Backend().MarketplaceBundleGetall(1, "query");

// Installs an bundle from the marketplace.
Marketplacemessage response = client.Backend().MarketplaceBundleInstall(new Marketplaceinstall());

// Upgrades an bundle from the marketplace.
Marketplacemessage response = client.Backend().MarketplaceBundleUpgrade("user", "name");

// Creates a new operation.
CommonMessage response = client.Backend().OperationCreate(new BackendOperationcreate());

// Deletes an existing operation.
CommonMessage response = client.Backend().OperationDelete("operation_id");

// Returns a specific operation.
BackendOperation response = client.Backend().OperationGet("operation_id");

// Returns a paginated list of operations.
BackendOperationcollection response = client.Backend().OperationGetall(1, 1, "search", 1);

// Updates an existing operation.
CommonMessage response = client.Backend().OperationUpdate("operation_id", new BackendOperationupdate());

// Creates a new page.
CommonMessage response = client.Backend().PageCreate(new BackendPagecreate());

// Deletes an existing page.
CommonMessage response = client.Backend().PageDelete("page_id");

// Returns a specific page.
BackendPage response = client.Backend().PageGet("page_id");

// Returns a paginated list of pages.
BackendPagecollection response = client.Backend().PageGetall(1, 1, "search");

// Updates an existing page.
CommonMessage response = client.Backend().PageUpdate("page_id", new BackendPageupdate());

// Creates a new plan.
CommonMessage response = client.Backend().PlanCreate(new BackendPlancreate());

// Deletes an existing plan.
CommonMessage response = client.Backend().PlanDelete("plan_id");

// Returns a specific plan.
BackendPlan response = client.Backend().PlanGet("plan_id");

// Returns a paginated list of plans.
BackendPlancollection response = client.Backend().PlanGetall(1, 1, "search");

// Updates an existing plan.
CommonMessage response = client.Backend().PlanUpdate("plan_id", new BackendPlanupdate());

// Creates a new rate limitation.
CommonMessage response = client.Backend().RateCreate(new BackendRatecreate());

// Deletes an existing rate.
CommonMessage response = client.Backend().RateDelete("rate_id");

// Returns a specific rate.
BackendRate response = client.Backend().RateGet("rate_id");

// Returns a paginated list of rate limitations.
BackendRatecollection response = client.Backend().RateGetall(1, 1, "search");

// Updates an existing rate.
CommonMessage response = client.Backend().RateUpdate("rate_id", new BackendRateupdate());

// Creates a new role.
CommonMessage response = client.Backend().RoleCreate(new BackendRolecreate());

// Deletes an existing role.
CommonMessage response = client.Backend().RoleDelete("role_id");

// Returns a specific role.
BackendRole response = client.Backend().RoleGet("role_id");

// Returns a paginated list of roles.
BackendRolecollection response = client.Backend().RoleGetall(1, 1, "search");

// Updates an existing role.
CommonMessage response = client.Backend().RoleUpdate("role_id", new BackendRoleupdate());

// Creates a new schema.
CommonMessage response = client.Backend().SchemaCreate(new BackendSchemacreate());

// Deletes an existing schema.
CommonMessage response = client.Backend().SchemaDelete("schema_id");

// Returns a specific schema.
BackendSchema response = client.Backend().SchemaGet("schema_id");

// Returns a paginated list of schemas.
BackendSchemacollection response = client.Backend().SchemaGetall(1, 1, "search", 1);

// Returns a paginated list of schema commits.
BackendSchemacommitcollection response = client.Backend().SchemaGetcommits("schema_id", 1, 1, "search");

// Returns a HTML preview of the provided schema.
BackendSchemapreviewresponse response = client.Backend().SchemaGetpreview("schema_id");

// Updates an existing schema.
CommonMessage response = client.Backend().SchemaUpdate("schema_id", new BackendSchemaupdate());

// Creates a new scope.
CommonMessage response = client.Backend().ScopeCreate(new BackendScopecreate());

// Deletes an existing scope.
CommonMessage response = client.Backend().ScopeDelete("scope_id");

// Returns a specific scope.
BackendScope response = client.Backend().ScopeGet("scope_id");

// Returns a paginated list of scopes.
BackendScopecollection response = client.Backend().ScopeGetall(1, 1, "search");

// Returns all available scopes grouped by category.
BackendScopecategories response = client.Backend().ScopeGetcategories();

// Updates an existing scope.
CommonMessage response = client.Backend().ScopeUpdate("scope_id", new BackendScopeupdate());

// Generates a specific SDK.
BackendSdkmessage response = client.Backend().SdkGenerate(new BackendSdkgenerate());

// Returns a paginated list of SDKs.
BackendSdkresponse response = client.Backend().SdkGetall();

// Returns the TypeHub specification.
BackendSpecificationget response = client.Backend().SpecificationGet();

// Returns the changelog between your current specification and the last tag.
BackendSpecificationchangelog response = client.Backend().SpecificationGetchangelog();

// Publish the specification.
CommonMessage response = client.Backend().SpecificationPublish(new BackendSpecificationpublish());

// Creates a new tag of your specification.
CommonMessage response = client.Backend().SpecificationTag(new Passthru());

// Returns a statistic containing the activities per user.
BackendStatisticchart response = client.Backend().StatisticGetactivitiesperuser(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the request count.
BackendStatisticcount response = client.Backend().StatisticGetcountrequests(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the errors per operation.
BackendStatisticchart response = client.Backend().StatisticGeterrorsperoperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the incoming requests.
BackendStatisticchart response = client.Backend().StatisticGetincomingrequests(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the incoming transactions.
BackendStatisticchart response = client.Backend().StatisticGetincomingtransactions(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the issues tokens.
BackendStatisticchart response = client.Backend().StatisticGetissuedtokens(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used activities.
BackendStatisticchart response = client.Backend().StatisticGetmostusedactivities(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used apps.
BackendStatisticchart response = client.Backend().StatisticGetmostusedapps(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used operations.
BackendStatisticchart response = client.Backend().StatisticGetmostusedoperations(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per ip.
BackendStatisticchart response = client.Backend().StatisticGetrequestsperip(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per operation.
BackendStatisticchart response = client.Backend().StatisticGetrequestsperoperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per user.
BackendStatisticchart response = client.Backend().StatisticGetrequestsperuser(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the test coverage.
BackendStatisticchart response = client.Backend().StatisticGettestcoverage();

// Returns a statistic containing the time average.
BackendStatisticchart response = client.Backend().StatisticGettimeaverage(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the time per operation.
BackendStatisticchart response = client.Backend().StatisticGettimeperoperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the used points.
BackendStatisticchart response = client.Backend().StatisticGetusedpoints(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the user registrations.
BackendStatisticchart response = client.Backend().StatisticGetuserregistrations(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Creates a new taxonomy.
CommonMessage response = client.Backend().TaxonomyCreate(new BackendTaxonomycreate());

// Deletes an existing taxonomy.
CommonMessage response = client.Backend().TaxonomyDelete("taxonomy_id");

// Returns a specific taxonomy.
BackendTaxonomy response = client.Backend().TaxonomyGet("taxonomy_id");

// Returns a paginated list of taxonomies.
BackendTaxonomycollection response = client.Backend().TaxonomyGetall(1, 1, "search");

// Moves the provided ids to the taxonomy.
CommonMessage response = client.Backend().TaxonomyMove("taxonomy_id", new BackendTaxonomymove());

// Updates an existing taxonomy.
CommonMessage response = client.Backend().TaxonomyUpdate("taxonomy_id", new BackendTaxonomyupdate());

// Removes an existing tenant.
CommonMessage response = client.Backend().TenantRemove("tenant_id");

// Setup a new tenant.
CommonMessage response = client.Backend().TenantSetup("tenant_id");

// Returns a specific test.
BackendTest response = client.Backend().TestGet("test_id");

// Returns a paginated list of tests.
BackendTestcollection response = client.Backend().TestGetall(1, 1, "search");

// Refresh all tests.
CommonMessage response = client.Backend().TestRefresh();

// Run all tests.
CommonMessage response = client.Backend().TestRun();

// Updates an existing test.
CommonMessage response = client.Backend().TestUpdate("test_id", new BackendTest());

// Returns a specific token.
BackendToken response = client.Backend().TokenGet("token_id");

// Returns a paginated list of tokens.
BackendTokencollection response = client.Backend().TokenGetall(1, 1, "search", "from", "to", 1, 1, 1, "scope", "ip");

// Returns a specific transaction.
BackendTransaction response = client.Backend().TransactionGet("transaction_id");

// Returns a paginated list of transactions.
BackendTransactioncollection response = client.Backend().TransactionGetall(1, 1, "search", "from", "to", 1, 1, 1, "status", "provider", 1);

// Returns all deleted records by trash type.
BackendTrashdatacollection response = client.Backend().TrashGetallbytype("type", 1, 1, "search");

// Returns all trash types.
BackendTrashtypes response = client.Backend().TrashGettypes();

// Restores a previously deleted record.
CommonMessage response = client.Backend().TrashRestore("type", new BackendTrashrestore());

// Creates a new trigger.
CommonMessage response = client.Backend().TriggerCreate(new BackendTriggercreate());

// Deletes an existing trigger.
CommonMessage response = client.Backend().TriggerDelete("trigger_id");

// Returns a specific trigger.
BackendTrigger response = client.Backend().TriggerGet("trigger_id");

// Returns a paginated list of triggers.
BackendTriggercollection response = client.Backend().TriggerGetall(1, 1, "search", 1);

// Updates an existing trigger.
CommonMessage response = client.Backend().TriggerUpdate("trigger_id", new BackendTriggerupdate());

// Creates a new user.
CommonMessage response = client.Backend().UserCreate(new BackendUsercreate());

// Deletes an existing user.
CommonMessage response = client.Backend().UserDelete("user_id");

// Returns a specific user.
BackendUser response = client.Backend().UserGet("user_id");

// Returns a paginated list of users.
BackendUsercollection response = client.Backend().UserGetall(1, 1, "search");

// Resend the activation mail to the provided user.
CommonMessage response = client.Backend().UserResend("user_id", new Passthru());

// Updates an existing user.
CommonMessage response = client.Backend().UserUpdate("user_id", new BackendUserupdate());

// Creates a new webhook.
CommonMessage response = client.Backend().WebhookCreate(new BackendWebhookcreate());

// Deletes an existing webhook.
CommonMessage response = client.Backend().WebhookDelete("webhook_id");

// Returns a specific webhook.
BackendWebhook response = client.Backend().WebhookGet("webhook_id");

// Returns a paginated list of webhooks.
BackendWebhookcollection response = client.Backend().WebhookGetall(1, 1, "search");

// Updates an existing webhook.
CommonMessage response = client.Backend().WebhookUpdate("webhook_id", new BackendWebhookupdate());

// Activates an previously registered account through a token which was provided to the user via email.
CommonMessage response = client.Consumer().AccountActivate(new ConsumerUseractivate());

// Authorizes the access of a specific app for the authenticated user.
ConsumerAuthorizeresponse response = client.Consumer().AccountAuthorize(new ConsumerAuthorizerequest());

// Change the password for the authenticated user.
CommonMessage response = client.Consumer().AccountChangepassword(new BackendAccountchangepassword());

// Change the password after the password reset flow was started.
CommonMessage response = client.Consumer().AccountExecutepasswordreset(new ConsumerUserpasswordreset());

// Returns a user data for the authenticated user.
ConsumerUseraccount response = client.Consumer().AccountGet();

// Returns information about a specific app to start the OAuth2 authorization code flow.
ConsumerAuthorizemeta response = client.Consumer().AccountGetapp("client_id", "scope");

// User login by providing a username and password.
ConsumerUserjwt response = client.Consumer().AccountLogin(new ConsumerUserlogin());

// Refresh a previously obtained access token.
ConsumerUserjwt response = client.Consumer().AccountRefresh(new ConsumerUserrefresh());

// Register a new user account.
CommonMessage response = client.Consumer().AccountRegister(new ConsumerUserregister());

// Start the password reset flow.
CommonMessage response = client.Consumer().AccountRequestpasswordreset(new ConsumerUseremail());

// Updates user data for the authenticated user.
CommonMessage response = client.Consumer().AccountUpdate(new ConsumerUseraccount());

// Returns a specific agent.
ConsumerAgent response = client.Consumer().AgentGet("agent_id");

// Returns a paginated list of agents.
ConsumerAgentcollection response = client.Consumer().AgentGetall(1, 1, "search");

// Returns a paginated list of agent messages.
ConsumerAgentmessagecollection response = client.Consumer().AgentMessageGetall("agent_id", "chat_id");

// Submits a new agent message.
AgentOutput response = client.Consumer().AgentMessageSubmit("agent_id", new AgentInput());

// Creates a new app for the authenticated user.
CommonMessage response = client.Consumer().AppCreate(new ConsumerAppcreate());

// Deletes an existing app for the authenticated user.
CommonMessage response = client.Consumer().AppDelete("app_id");

// Returns a specific app for the authenticated user.
ConsumerApp response = client.Consumer().AppGet("app_id");

// Returns a paginated list of apps which are assigned to the authenticated user.
ConsumerAppcollection response = client.Consumer().AppGetall(1, 1, "search");

// Updates an existing app for the authenticated user.
CommonMessage response = client.Consumer().AppUpdate("app_id", new ConsumerAppupdate());

// Returns a specific event for the authenticated user.
ConsumerEvent response = client.Consumer().EventGet("event_id");

// Returns a paginated list of apps which are assigned to the authenticated user.
ConsumerEventcollection response = client.Consumer().EventGetall(1, 1, "search");

// Returns a specific form for the authenticated user.
ConsumerForm response = client.Consumer().FormGet("form_id");

// Returns a paginated list of forms which are relevant to the authenticated user.
ConsumerFormcollection response = client.Consumer().FormGetall(1, 1, "search");

// Deletes an existing grant for an app which was created by the authenticated user.
CommonMessage response = client.Consumer().GrantDelete("grant_id");

// Returns a paginated list of grants which are assigned to the authenticated user.
ConsumerGrantcollection response = client.Consumer().GrantGetall(1, 1, "search");

// Identity callback endpoint to exchange an access token.
Passthru response = client.Consumer().IdentityExchange("identity");

// Returns a paginated list of identities which are relevant to the authenticated user.
ConsumerIdentitycollection response = client.Consumer().IdentityGetall(1, "appKey");

// Redirect the user to the configured identity provider.
Passthru response = client.Consumer().IdentityRedirect("identity");

// Returns a specific log for the authenticated user.
ConsumerLog response = client.Consumer().LogGet("log_id");

// Returns a paginated list of logs which are assigned to the authenticated user.
ConsumerLogcollection response = client.Consumer().LogGetall(1, 1, "search");

// Returns a specific page for the authenticated user.
ConsumerPage response = client.Consumer().PageGet("page_id");

// Returns a paginated list of pages which are relevant to the authenticated user.
ConsumerPagecollection response = client.Consumer().PageGetall(1, 1, "search");

// Start the checkout process for a specific plan.
ConsumerPaymentcheckoutresponse response = client.Consumer().PaymentCheckout("provider", new ConsumerPaymentcheckoutrequest());

// Generates a payment portal link for the authenticated user.
ConsumerPaymentportalresponse response = client.Consumer().PaymentPortal("provider", new ConsumerPaymentportalrequest());

// Returns a specific plan for the authenticated user.
ConsumerPlan response = client.Consumer().PlanGet("plan_id");

// Returns a paginated list of plans which are relevant to the authenticated user.
ConsumerPlancollection response = client.Consumer().PlanGetall(1, 1, "search");

// Returns a paginated list of scopes which are assigned to the authenticated user.
ConsumerScopecollection response = client.Consumer().ScopeGetall(1, 1, "search");

// Returns all scopes by category.
ConsumerScopecategories response = client.Consumer().ScopeGetcategories();

// Creates a new token for the authenticated user.
ConsumerTokenaccesstoken response = client.Consumer().TokenCreate(new ConsumerTokencreate());

// Deletes an existing token for the authenticated user.
CommonMessage response = client.Consumer().TokenDelete("token_id");

// Returns a specific token for the authenticated user.
ConsumerToken response = client.Consumer().TokenGet("token_id");

// Returns a paginated list of tokens which are assigned to the authenticated user.
ConsumerTokencollection response = client.Consumer().TokenGetall(1, 1, "search");

// Updates an existing token for the authenticated user.
ConsumerTokenaccesstoken response = client.Consumer().TokenUpdate("token_id", new ConsumerTokenupdate());

// Returns a specific transaction for the authenticated user.
ConsumerTransaction response = client.Consumer().TransactionGet("transaction_id");

// Returns a paginated list of transactions which are assigned to the authenticated user.
ConsumerTransactioncollection response = client.Consumer().TransactionGetall(1, 1, "search");

// Creates a new webhook for the authenticated user.
CommonMessage response = client.Consumer().WebhookCreate(new ConsumerWebhookcreate());

// Deletes an existing webhook for the authenticated user.
CommonMessage response = client.Consumer().WebhookDelete("webhook_id");

// Returns a specific webhook for the authenticated user.
ConsumerWebhook response = client.Consumer().WebhookGet("webhook_id");

// Returns a paginated list of webhooks which are assigned to the authenticated user.
ConsumerWebhookcollection response = client.Consumer().WebhookGetall(1, 1, "search");

// Updates an existing webhook for the authenticated user.
CommonMessage response = client.Consumer().WebhookUpdate("webhook_id", new ConsumerWebhookupdate());

// Connection OAuth2 callback to authorize a connection.
CommonMessage response = client.System().ConnectionCallback("name");

// Returns meta information and links about the current installed Fusio version.
SystemAbout response = client.System().MetaGetabout();

// Debug endpoint which returns the provided data.
Passthru response = client.System().MetaGetdebug(new Passthru());

// Health check endpoint which returns information about the health status of the system.
SystemHealthcheck response = client.System().MetaGethealth();

// Returns all available routes.
SystemRoute response = client.System().MetaGetroutes();

// Returns details of a specific schema.
SystemSchema response = client.System().MetaGetschema("name");

// Payment webhook endpoint after successful purchase of a plan.
CommonMessage response = client.System().PaymentWebhook("provider");
```
