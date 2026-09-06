
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
CommonMessage response = client.Backend().Account().Changepassword(new BackendAccountchangepassword());

// Returns user data of the authenticated user.
BackendUser response = client.Backend().Account().Get();

// Updates user data of the authenticated user.
CommonMessage response = client.Backend().Account().Update(new BackendUserupdate());

// Creates a new action.
CommonMessage response = client.Backend().Action().Create(new BackendActioncreate());

// Deletes an existing action.
CommonMessage response = client.Backend().Action().Delete("action_id");

// Executes a specific action.
BackendActionexecuteresponse response = client.Backend().Action().Execute("action_id", new BackendActionexecuterequest());

// Returns a specific action.
BackendAction response = client.Backend().Action().Get("action_id");

// Returns a paginated list of actions.
BackendActioncollection response = client.Backend().Action().Getall(1, 1, "search");

// Returns all available action classes.
BackendActionindex response = client.Backend().Action().Getclasses();

// Returns a paginated list of action commits.
BackendActioncommitcollection response = client.Backend().Action().Getcommits("action_id", 1, 1, "search");

// Returns the action config form.
CommonFormcontainer response = client.Backend().Action().Getform("class");

// Updates an existing action.
CommonMessage response = client.Backend().Action().Update("action_id", new BackendActionupdate());

// Creates a new agent.
CommonMessage response = client.Backend().Agent().Create(new BackendAgentcreate());

// Deletes an existing agent.
CommonMessage response = client.Backend().Agent().Delete("agent_id");

// Returns a specific agent.
BackendAgent response = client.Backend().Agent().Get("agent_id");

// Returns a paginated list of agents.
BackendAgentcollection response = client.Backend().Agent().Getall(1, 1, "search");

// Returns available tools for an agent.
BackendAgenttools response = client.Backend().Agent().Gettools();

// Returns a paginated list of agent messages.
BackendAgentmessagecollection response = client.Backend().Agent().Message().Getall("agent_id", "chat_id");

// Submits a new agent message.
AgentOutput response = client.Backend().Agent().Message().Submit("agent_id", new AgentInput());

// Updates an existing agent.
CommonMessage response = client.Backend().Agent().Update("agent_id", new BackendAgentupdate());

// Creates a new app.
CommonMessage response = client.Backend().App().Create(new BackendAppcreate());

// Deletes an existing app.
CommonMessage response = client.Backend().App().Delete("app_id");

// Deletes an existing token from an app.
CommonMessage response = client.Backend().App().Deletetoken("app_id", "token_id");

// Returns a specific app.
BackendApp response = client.Backend().App().Get("app_id");

// Returns a paginated list of apps.
BackendAppcollection response = client.Backend().App().Getall(1, 1, "search");

// Updates an existing app.
CommonMessage response = client.Backend().App().Update("app_id", new BackendAppupdate());

// Returns a specific audit.
BackendAudit response = client.Backend().Audit().Get("audit_id");

// Returns a paginated list of audits.
BackendAuditcollection response = client.Backend().Audit().Getall(1, 1, "search", "from", "to", 1, 1, "event", "ip", "message");

// Generates an backup of the current system.
BackendBackupexport response = client.Backend().Backup().Export();

// Imports an backup to the current system.
BackendBackupimportresult response = client.Backend().Backup().Import(new BackendBackupimport());

// Creates a new bundle.
CommonMessage response = client.Backend().Bundle().Create(new BackendBundlecreate());

// Deletes an existing bundle.
CommonMessage response = client.Backend().Bundle().Delete("bundle_id");

// Returns a specific bundle.
BackendBundle response = client.Backend().Bundle().Get("bundle_id");

// Returns a paginated list of bundles.
BackendBundlecollection response = client.Backend().Bundle().Getall(1, 1, "search");

// Publish an existing bundle to the marketplace.
CommonMessage response = client.Backend().Bundle().Publish("bundle_id");

// Updates an existing bundle.
CommonMessage response = client.Backend().Bundle().Update("bundle_id", new BackendBundleupdate());

// Creates a new category.
CommonMessage response = client.Backend().Category().Create(new BackendCategorycreate());

// Deletes an existing category.
CommonMessage response = client.Backend().Category().Delete("category_id");

// Returns a specific category.
BackendCategory response = client.Backend().Category().Get("category_id");

// Returns a paginated list of categories.
BackendCategorycollection response = client.Backend().Category().Getall(1, 1, "search");

// Updates an existing category.
CommonMessage response = client.Backend().Category().Update("category_id", new BackendCategoryupdate());

// Returns a specific config.
BackendConfig response = client.Backend().Config().Get("config_id");

// Returns a paginated list of configuration values.
BackendConfigcollection response = client.Backend().Config().Getall(1, 1, "search");

// Updates an existing config value.
CommonMessage response = client.Backend().Config().Update("config_id", new BackendConfigupdate());

// Sends a message to an agent.
AgentOutput response = client.Backend().Connection().Agent().Send("connection_id", new AgentInput());

// Creates a new connection.
CommonMessage response = client.Backend().Connection().Create(new BackendConnectioncreate());

// Creates a new row at a table on a database.
CommonMessage response = client.Backend().Connection().Database().Createrow("connection_id", "table_name", new BackendDatabaserow());

// Creates a new table on a database.
CommonMessage response = client.Backend().Connection().Database().Createtable("connection_id", new BackendDatabasetable());

// Deletes an existing row at a table on a database.
CommonMessage response = client.Backend().Connection().Database().Deleterow("connection_id", "table_name", "id");

// Deletes an existing table on a database.
CommonMessage response = client.Backend().Connection().Database().Deletetable("connection_id", "table_name");

// Returns a specific row at a table on a database.
BackendDatabaserow response = client.Backend().Connection().Database().Getrow("connection_id", "table_name", "id");

// Returns paginated rows at a table on a database.
BackendDatabaserowcollection response = client.Backend().Connection().Database().Getrows("connection_id", "table_name", 1, 1, "filterBy", "filterOp", "filterValue", "sortBy", "sortOrder", "columns");

// Returns the schema of a specific table on a database.
BackendDatabasetable response = client.Backend().Connection().Database().Gettable("connection_id", "table_name");

// Returns all available tables on a database.
BackendDatabasetablecollection response = client.Backend().Connection().Database().Gettables("connection_id", 1, 1);

// Updates an existing row at a table on a database.
CommonMessage response = client.Backend().Connection().Database().Updaterow("connection_id", "table_name", "id", new BackendDatabaserow());

// Updates an existing table on a database.
CommonMessage response = client.Backend().Connection().Database().Updatetable("connection_id", "table_name", new BackendDatabasetable());

// Deletes an existing connection.
CommonMessage response = client.Backend().Connection().Delete("connection_id");

// Uploads one or more files on the filesystem connection.
CommonMessage response = client.Backend().Connection().Filesystem().Create("connection_id", new object());

// Deletes an existing file on the filesystem connection.
CommonMessage response = client.Backend().Connection().Filesystem().Delete("connection_id", "file_id");

// Returns the content of the provided file id on the filesystem connection.
client.Backend().Connection().Filesystem().Get("connection_id", "file_id");

// Returns all available files on the filesystem connection.
BackendFilecollection response = client.Backend().Connection().Filesystem().Getall("connection_id", 1, 1);

// Updates an existing file on the filesystem connection.
CommonMessage response = client.Backend().Connection().Filesystem().Update("connection_id", "file_id", new object());

// Returns a specific connection.
BackendConnection response = client.Backend().Connection().Get("connection_id");

// Returns a paginated list of connections.
BackendConnectioncollection response = client.Backend().Connection().Getall(1, 1, "search", "class");

// Returns all available connection classes.
BackendConnectionindex response = client.Backend().Connection().Getclasses();

// Returns the connection config form.
CommonFormcontainer response = client.Backend().Connection().Getform("class");

// Returns a redirect url to start the OAuth2 authorization flow for the given connection.
BackendConnectionredirectresponse response = client.Backend().Connection().Getredirect("connection_id");

// Sends an arbitrary HTTP request to the connection.
BackendHttpresponse response = client.Backend().Connection().Http().Execute("connection_id", new BackendHttprequest());

// Returns the SDK specification.
Passthru response = client.Backend().Connection().Sdk().Get("connection_id");

// Updates an existing connection.
CommonMessage response = client.Backend().Connection().Update("connection_id", new BackendConnectionupdate());

// Creates a new cronjob.
CommonMessage response = client.Backend().Cronjob().Create(new BackendCronjobcreate());

// Deletes an existing cronjob.
CommonMessage response = client.Backend().Cronjob().Delete("cronjob_id");

// Returns a specific cronjob.
BackendCronjob response = client.Backend().Cronjob().Get("cronjob_id");

// Returns a paginated list of cronjobs.
BackendCronjobcollection response = client.Backend().Cronjob().Getall(1, 1, "search", 1);

// Updates an existing cronjob.
CommonMessage response = client.Backend().Cronjob().Update("cronjob_id", new BackendCronjobupdate());

// Returns all available dashboard widgets.
BackendDashboard response = client.Backend().Dashboard().Getall();

// Creates a new event.
CommonMessage response = client.Backend().Event().Create(new BackendEventcreate());

// Deletes an existing event.
CommonMessage response = client.Backend().Event().Delete("event_id");

// Returns a specific event.
BackendEvent response = client.Backend().Event().Get("event_id");

// Returns a paginated list of events.
BackendEventcollection response = client.Backend().Event().Getall(1, 1, "search", 1);

// Updates an existing event.
CommonMessage response = client.Backend().Event().Update("event_id", new BackendEventupdate());

// Creates a new firewall rule.
CommonMessage response = client.Backend().Firewall().Create(new BackendFirewallcreate());

// Deletes an existing firewall rule.
CommonMessage response = client.Backend().Firewall().Delete("firewall_id");

// Returns a specific firewall rule.
BackendFirewall response = client.Backend().Firewall().Get("firewall_id");

// Returns a paginated list of firewall rules.
BackendFirewallcollection response = client.Backend().Firewall().Getall(1, 1, "search");

// Updates an existing firewall rule.
CommonMessage response = client.Backend().Firewall().Update("firewall_id", new BackendFirewallupdate());

// Creates a new form.
CommonMessage response = client.Backend().Form().Create(new BackendFormcreate());

// Deletes an existing form.
CommonMessage response = client.Backend().Form().Delete("form_id");

// Returns a specific form.
BackendForm response = client.Backend().Form().Get("form_id");

// Returns a paginated list of forms.
BackendFormcollection response = client.Backend().Form().Getall(1, 1, "search");

// Updates an existing form.
CommonMessage response = client.Backend().Form().Update("form_id", new BackendFormupdate());

// Executes a generator with the provided config.
CommonMessage response = client.Backend().Generator().Executeprovider("provider", new BackendGeneratorprovider());

// Generates a changelog of all potential changes if you execute this generator with the provided config.
BackendGeneratorproviderchangelog response = client.Backend().Generator().Getchangelog("provider", new BackendGeneratorproviderconfig());

// Returns all available generator classes.
BackendGeneratorindexproviders response = client.Backend().Generator().Getclasses();

// Returns the generator config form.
CommonFormcontainer response = client.Backend().Generator().Getform("provider");

// Creates a new identity.
CommonMessage response = client.Backend().Identity().Create(new BackendIdentitycreate());

// Deletes an existing identity.
CommonMessage response = client.Backend().Identity().Delete("identity_id");

// Returns a specific identity.
BackendIdentity response = client.Backend().Identity().Get("identity_id");

// Returns a paginated list of identities.
BackendIdentitycollection response = client.Backend().Identity().Getall(1, 1, "search");

// Returns all available identity classes.
BackendIdentityindex response = client.Backend().Identity().Getclasses();

// Returns the identity config form.
CommonFormcontainer response = client.Backend().Identity().Getform("class");

// Updates an existing identity.
CommonMessage response = client.Backend().Identity().Update("identity_id", new BackendIdentityupdate());

// Returns a specific log.
BackendLog response = client.Backend().Log().Get("log_id");

// Returns a paginated list of logs.
BackendLogcollection response = client.Backend().Log().Getall(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a paginated list of log errors.
BackendLogerrorcollection response = client.Backend().Log().Getallerrors(1, 1, "search");

// Returns a specific error.
BackendLogerror response = client.Backend().Log().Geterror("error_id");

// Returns a specific marketplace action.
Marketplaceaction response = client.Backend().Marketplace().Action().Get("user", "name");

// Returns a paginated list of marketplace actions.
Marketplaceactioncollection response = client.Backend().Marketplace().Action().Getall(1, "query");

// Installs an action from the marketplace.
Marketplacemessage response = client.Backend().Marketplace().Action().Install(new Marketplaceinstall());

// Upgrades an action from the marketplace.
CommonMessage response = client.Backend().Marketplace().Action().Upgrade("user", "name");

// Returns a specific marketplace app.
Marketplaceapp response = client.Backend().Marketplace().App().Get("user", "name");

// Returns a paginated list of marketplace apps.
Marketplaceappcollection response = client.Backend().Marketplace().App().Getall(1, "query");

// Installs an app from the marketplace.
Marketplacemessage response = client.Backend().Marketplace().App().Install(new Marketplaceinstall());

// Upgrades an app from the marketplace.
Marketplacemessage response = client.Backend().Marketplace().App().Upgrade("user", "name");

// Returns a specific marketplace bundle.
Marketplacebundle response = client.Backend().Marketplace().Bundle().Get("user", "name");

// Returns a paginated list of marketplace bundles.
Marketplacebundlecollection response = client.Backend().Marketplace().Bundle().Getall(1, "query");

// Installs an bundle from the marketplace.
Marketplacemessage response = client.Backend().Marketplace().Bundle().Install(new Marketplaceinstall());

// Upgrades an bundle from the marketplace.
Marketplacemessage response = client.Backend().Marketplace().Bundle().Upgrade("user", "name");

// Creates a new operation.
CommonMessage response = client.Backend().Operation().Create(new BackendOperationcreate());

// Deletes an existing operation.
CommonMessage response = client.Backend().Operation().Delete("operation_id");

// Returns a specific operation.
BackendOperation response = client.Backend().Operation().Get("operation_id");

// Returns a paginated list of operations.
BackendOperationcollection response = client.Backend().Operation().Getall(1, 1, "search", 1);

// Updates an existing operation.
CommonMessage response = client.Backend().Operation().Update("operation_id", new BackendOperationupdate());

// Creates a new page.
CommonMessage response = client.Backend().Page().Create(new BackendPagecreate());

// Deletes an existing page.
CommonMessage response = client.Backend().Page().Delete("page_id");

// Returns a specific page.
BackendPage response = client.Backend().Page().Get("page_id");

// Returns a paginated list of pages.
BackendPagecollection response = client.Backend().Page().Getall(1, 1, "search");

// Updates an existing page.
CommonMessage response = client.Backend().Page().Update("page_id", new BackendPageupdate());

// Creates a new plan.
CommonMessage response = client.Backend().Plan().Create(new BackendPlancreate());

// Deletes an existing plan.
CommonMessage response = client.Backend().Plan().Delete("plan_id");

// Returns a specific plan.
BackendPlan response = client.Backend().Plan().Get("plan_id");

// Returns a paginated list of plans.
BackendPlancollection response = client.Backend().Plan().Getall(1, 1, "search");

// Updates an existing plan.
CommonMessage response = client.Backend().Plan().Update("plan_id", new BackendPlanupdate());

// Creates a new rate limitation.
CommonMessage response = client.Backend().Rate().Create(new BackendRatecreate());

// Deletes an existing rate.
CommonMessage response = client.Backend().Rate().Delete("rate_id");

// Returns a specific rate.
BackendRate response = client.Backend().Rate().Get("rate_id");

// Returns a paginated list of rate limitations.
BackendRatecollection response = client.Backend().Rate().Getall(1, 1, "search");

// Updates an existing rate.
CommonMessage response = client.Backend().Rate().Update("rate_id", new BackendRateupdate());

// Creates a new role.
CommonMessage response = client.Backend().Role().Create(new BackendRolecreate());

// Deletes an existing role.
CommonMessage response = client.Backend().Role().Delete("role_id");

// Returns a specific role.
BackendRole response = client.Backend().Role().Get("role_id");

// Returns a paginated list of roles.
BackendRolecollection response = client.Backend().Role().Getall(1, 1, "search");

// Updates an existing role.
CommonMessage response = client.Backend().Role().Update("role_id", new BackendRoleupdate());

// Creates a new schema.
CommonMessage response = client.Backend().Schema().Create(new BackendSchemacreate());

// Deletes an existing schema.
CommonMessage response = client.Backend().Schema().Delete("schema_id");

// Returns a specific schema.
BackendSchema response = client.Backend().Schema().Get("schema_id");

// Returns a paginated list of schemas.
BackendSchemacollection response = client.Backend().Schema().Getall(1, 1, "search", 1);

// Returns a paginated list of schema commits.
BackendSchemacommitcollection response = client.Backend().Schema().Getcommits("schema_id", 1, 1, "search");

// Returns a HTML preview of the provided schema.
BackendSchemapreviewresponse response = client.Backend().Schema().Getpreview("schema_id");

// Updates an existing schema.
CommonMessage response = client.Backend().Schema().Update("schema_id", new BackendSchemaupdate());

// Creates a new scope.
CommonMessage response = client.Backend().Scope().Create(new BackendScopecreate());

// Deletes an existing scope.
CommonMessage response = client.Backend().Scope().Delete("scope_id");

// Returns a specific scope.
BackendScope response = client.Backend().Scope().Get("scope_id");

// Returns a paginated list of scopes.
BackendScopecollection response = client.Backend().Scope().Getall(1, 1, "search");

// Returns all available scopes grouped by category.
BackendScopecategories response = client.Backend().Scope().Getcategories();

// Updates an existing scope.
CommonMessage response = client.Backend().Scope().Update("scope_id", new BackendScopeupdate());

// Generates a specific SDK.
BackendSdkmessage response = client.Backend().Sdk().Generate(new BackendSdkgenerate());

// Returns a paginated list of SDKs.
BackendSdkresponse response = client.Backend().Sdk().Getall();

// Returns the TypeHub specification.
BackendSpecificationget response = client.Backend().Specification().Get();

// Returns the changelog between your current specification and the last tag.
BackendSpecificationchangelog response = client.Backend().Specification().Getchangelog();

// Publish the specification.
CommonMessage response = client.Backend().Specification().Publish(new BackendSpecificationpublish());

// Creates a new tag of your specification.
CommonMessage response = client.Backend().Specification().Tag(new Passthru());

// Returns a statistic containing the activities per user.
BackendStatisticchart response = client.Backend().Statistic().Getactivitiesperuser(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the request count.
BackendStatisticcount response = client.Backend().Statistic().Getcountrequests(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the errors per operation.
BackendStatisticchart response = client.Backend().Statistic().Geterrorsperoperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the incoming requests.
BackendStatisticchart response = client.Backend().Statistic().Getincomingrequests(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the incoming transactions.
BackendStatisticchart response = client.Backend().Statistic().Getincomingtransactions(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the issues tokens.
BackendStatisticchart response = client.Backend().Statistic().Getissuedtokens(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used activities.
BackendStatisticchart response = client.Backend().Statistic().Getmostusedactivities(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used apps.
BackendStatisticchart response = client.Backend().Statistic().Getmostusedapps(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used operations.
BackendStatisticchart response = client.Backend().Statistic().Getmostusedoperations(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per ip.
BackendStatisticchart response = client.Backend().Statistic().Getrequestsperip(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per operation.
BackendStatisticchart response = client.Backend().Statistic().Getrequestsperoperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per user.
BackendStatisticchart response = client.Backend().Statistic().Getrequestsperuser(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the test coverage.
BackendStatisticchart response = client.Backend().Statistic().Gettestcoverage();

// Returns a statistic containing the time average.
BackendStatisticchart response = client.Backend().Statistic().Gettimeaverage(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the time per operation.
BackendStatisticchart response = client.Backend().Statistic().Gettimeperoperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the used points.
BackendStatisticchart response = client.Backend().Statistic().Getusedpoints(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the user registrations.
BackendStatisticchart response = client.Backend().Statistic().Getuserregistrations(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Creates a new taxonomy.
CommonMessage response = client.Backend().Taxonomy().Create(new BackendTaxonomycreate());

// Deletes an existing taxonomy.
CommonMessage response = client.Backend().Taxonomy().Delete("taxonomy_id");

// Returns a specific taxonomy.
BackendTaxonomy response = client.Backend().Taxonomy().Get("taxonomy_id");

// Returns a paginated list of taxonomies.
BackendTaxonomycollection response = client.Backend().Taxonomy().Getall(1, 1, "search");

// Moves the provided ids to the taxonomy.
CommonMessage response = client.Backend().Taxonomy().Move("taxonomy_id", new BackendTaxonomymove());

// Updates an existing taxonomy.
CommonMessage response = client.Backend().Taxonomy().Update("taxonomy_id", new BackendTaxonomyupdate());

// Removes an existing tenant.
CommonMessage response = client.Backend().Tenant().Remove("tenant_id");

// Setup a new tenant.
CommonMessage response = client.Backend().Tenant().Setup("tenant_id");

// Returns a specific test.
BackendTest response = client.Backend().Test().Get("test_id");

// Returns a paginated list of tests.
BackendTestcollection response = client.Backend().Test().Getall(1, 1, "search");

// Refresh all tests.
CommonMessage response = client.Backend().Test().Refresh();

// Run all tests.
CommonMessage response = client.Backend().Test().Run();

// Updates an existing test.
CommonMessage response = client.Backend().Test().Update("test_id", new BackendTest());

// Returns a specific token.
BackendToken response = client.Backend().Token().Get("token_id");

// Returns a paginated list of tokens.
BackendTokencollection response = client.Backend().Token().Getall(1, 1, "search", "from", "to", 1, 1, 1, "scope", "ip");

// Returns a specific transaction.
BackendTransaction response = client.Backend().Transaction().Get("transaction_id");

// Returns a paginated list of transactions.
BackendTransactioncollection response = client.Backend().Transaction().Getall(1, 1, "search", "from", "to", 1, 1, 1, "status", "provider", 1);

// Returns all deleted records by trash type.
BackendTrashdatacollection response = client.Backend().Trash().Getallbytype("type", 1, 1, "search");

// Returns all trash types.
BackendTrashtypes response = client.Backend().Trash().Gettypes();

// Restores a previously deleted record.
CommonMessage response = client.Backend().Trash().Restore("type", new BackendTrashrestore());

// Creates a new trigger.
CommonMessage response = client.Backend().Trigger().Create(new BackendTriggercreate());

// Deletes an existing trigger.
CommonMessage response = client.Backend().Trigger().Delete("trigger_id");

// Returns a specific trigger.
BackendTrigger response = client.Backend().Trigger().Get("trigger_id");

// Returns a paginated list of triggers.
BackendTriggercollection response = client.Backend().Trigger().Getall(1, 1, "search", 1);

// Updates an existing trigger.
CommonMessage response = client.Backend().Trigger().Update("trigger_id", new BackendTriggerupdate());

// Creates a new user.
CommonMessage response = client.Backend().User().Create(new BackendUsercreate());

// Deletes an existing user.
CommonMessage response = client.Backend().User().Delete("user_id");

// Returns a specific user.
BackendUser response = client.Backend().User().Get("user_id");

// Returns a paginated list of users.
BackendUsercollection response = client.Backend().User().Getall(1, 1, "search");

// Resend the activation mail to the provided user.
CommonMessage response = client.Backend().User().Resend("user_id", new Passthru());

// Updates an existing user.
CommonMessage response = client.Backend().User().Update("user_id", new BackendUserupdate());

// Creates a new webhook.
CommonMessage response = client.Backend().Webhook().Create(new BackendWebhookcreate());

// Deletes an existing webhook.
CommonMessage response = client.Backend().Webhook().Delete("webhook_id");

// Returns a specific webhook.
BackendWebhook response = client.Backend().Webhook().Get("webhook_id");

// Returns a paginated list of webhooks.
BackendWebhookcollection response = client.Backend().Webhook().Getall(1, 1, "search");

// Updates an existing webhook.
CommonMessage response = client.Backend().Webhook().Update("webhook_id", new BackendWebhookupdate());

// Activates an previously registered account through a token which was provided to the user via email.
CommonMessage response = client.Consumer().Account().Activate(new ConsumerUseractivate());

// Authorizes the access of a specific app for the authenticated user.
ConsumerAuthorizeresponse response = client.Consumer().Account().Authorize(new ConsumerAuthorizerequest());

// Change the password for the authenticated user.
CommonMessage response = client.Consumer().Account().Changepassword(new BackendAccountchangepassword());

// Change the password after the password reset flow was started.
CommonMessage response = client.Consumer().Account().Executepasswordreset(new ConsumerUserpasswordreset());

// Returns a user data for the authenticated user.
ConsumerUseraccount response = client.Consumer().Account().Get();

// Returns information about a specific app to start the OAuth2 authorization code flow.
ConsumerAuthorizemeta response = client.Consumer().Account().Getapp("client_id", "scope");

// User login by providing a username and password.
ConsumerUserjwt response = client.Consumer().Account().Login(new ConsumerUserlogin());

// Refresh a previously obtained access token.
ConsumerUserjwt response = client.Consumer().Account().Refresh(new ConsumerUserrefresh());

// Register a new user account.
CommonMessage response = client.Consumer().Account().Register(new ConsumerUserregister());

// Start the password reset flow.
CommonMessage response = client.Consumer().Account().Requestpasswordreset(new ConsumerUseremail());

// Updates user data for the authenticated user.
CommonMessage response = client.Consumer().Account().Update(new ConsumerUseraccount());

// Returns a specific agent.
ConsumerAgent response = client.Consumer().Agent().Get("agent_id");

// Returns a paginated list of agents.
ConsumerAgentcollection response = client.Consumer().Agent().Getall(1, 1, "search");

// Returns a paginated list of agent messages.
ConsumerAgentmessagecollection response = client.Consumer().Agent().Message().Getall("agent_id", "chat_id");

// Submits a new agent message.
AgentOutput response = client.Consumer().Agent().Message().Submit("agent_id", new AgentInput());

// Creates a new app for the authenticated user.
CommonMessage response = client.Consumer().App().Create(new ConsumerAppcreate());

// Deletes an existing app for the authenticated user.
CommonMessage response = client.Consumer().App().Delete("app_id");

// Returns a specific app for the authenticated user.
ConsumerApp response = client.Consumer().App().Get("app_id");

// Returns a paginated list of apps which are assigned to the authenticated user.
ConsumerAppcollection response = client.Consumer().App().Getall(1, 1, "search");

// Updates an existing app for the authenticated user.
CommonMessage response = client.Consumer().App().Update("app_id", new ConsumerAppupdate());

// Returns a specific event for the authenticated user.
ConsumerEvent response = client.Consumer().Event().Get("event_id");

// Returns a paginated list of apps which are assigned to the authenticated user.
ConsumerEventcollection response = client.Consumer().Event().Getall(1, 1, "search");

// Returns a specific form for the authenticated user.
ConsumerForm response = client.Consumer().Form().Get("form_id");

// Returns a paginated list of forms which are relevant to the authenticated user.
ConsumerFormcollection response = client.Consumer().Form().Getall(1, 1, "search");

// Deletes an existing grant for an app which was created by the authenticated user.
CommonMessage response = client.Consumer().Grant().Delete("grant_id");

// Returns a paginated list of grants which are assigned to the authenticated user.
ConsumerGrantcollection response = client.Consumer().Grant().Getall(1, 1, "search");

// Identity callback endpoint to exchange an access token.
Passthru response = client.Consumer().Identity().Exchange("identity");

// Returns a paginated list of identities which are relevant to the authenticated user.
ConsumerIdentitycollection response = client.Consumer().Identity().Getall(1, "appKey");

// Redirect the user to the configured identity provider.
Passthru response = client.Consumer().Identity().Redirect("identity");

// Returns a specific log for the authenticated user.
ConsumerLog response = client.Consumer().Log().Get("log_id");

// Returns a paginated list of logs which are assigned to the authenticated user.
ConsumerLogcollection response = client.Consumer().Log().Getall(1, 1, "search");

// Returns a specific page for the authenticated user.
ConsumerPage response = client.Consumer().Page().Get("page_id");

// Returns a paginated list of pages which are relevant to the authenticated user.
ConsumerPagecollection response = client.Consumer().Page().Getall(1, 1, "search");

// Start the checkout process for a specific plan.
ConsumerPaymentcheckoutresponse response = client.Consumer().Payment().Checkout("provider", new ConsumerPaymentcheckoutrequest());

// Generates a payment portal link for the authenticated user.
ConsumerPaymentportalresponse response = client.Consumer().Payment().Portal("provider", new ConsumerPaymentportalrequest());

// Returns a specific plan for the authenticated user.
ConsumerPlan response = client.Consumer().Plan().Get("plan_id");

// Returns a paginated list of plans which are relevant to the authenticated user.
ConsumerPlancollection response = client.Consumer().Plan().Getall(1, 1, "search");

// Returns a paginated list of scopes which are assigned to the authenticated user.
ConsumerScopecollection response = client.Consumer().Scope().Getall(1, 1, "search");

// Returns all scopes by category.
ConsumerScopecategories response = client.Consumer().Scope().Getcategories();

// Creates a new token for the authenticated user.
ConsumerTokenaccesstoken response = client.Consumer().Token().Create(new ConsumerTokencreate());

// Deletes an existing token for the authenticated user.
CommonMessage response = client.Consumer().Token().Delete("token_id");

// Returns a specific token for the authenticated user.
ConsumerToken response = client.Consumer().Token().Get("token_id");

// Returns a paginated list of tokens which are assigned to the authenticated user.
ConsumerTokencollection response = client.Consumer().Token().Getall(1, 1, "search");

// Updates an existing token for the authenticated user.
ConsumerTokenaccesstoken response = client.Consumer().Token().Update("token_id", new ConsumerTokenupdate());

// Returns a specific transaction for the authenticated user.
ConsumerTransaction response = client.Consumer().Transaction().Get("transaction_id");

// Returns a paginated list of transactions which are assigned to the authenticated user.
ConsumerTransactioncollection response = client.Consumer().Transaction().Getall(1, 1, "search");

// Creates a new webhook for the authenticated user.
CommonMessage response = client.Consumer().Webhook().Create(new ConsumerWebhookcreate());

// Deletes an existing webhook for the authenticated user.
CommonMessage response = client.Consumer().Webhook().Delete("webhook_id");

// Returns a specific webhook for the authenticated user.
ConsumerWebhook response = client.Consumer().Webhook().Get("webhook_id");

// Returns a paginated list of webhooks which are assigned to the authenticated user.
ConsumerWebhookcollection response = client.Consumer().Webhook().Getall(1, 1, "search");

// Updates an existing webhook for the authenticated user.
CommonMessage response = client.Consumer().Webhook().Update("webhook_id", new ConsumerWebhookupdate());

// Connection OAuth2 callback to authorize a connection.
CommonMessage response = client.System().Connection().Callback("name");

// Returns meta information and links about the current installed Fusio version.
SystemAbout response = client.System().Meta().Getabout();

// Debug endpoint which returns the provided data.
Passthru response = client.System().Meta().Getdebug(new Passthru());

// Health check endpoint which returns information about the health status of the system.
SystemHealthcheck response = client.System().Meta().Gethealth();

// Returns all available routes.
SystemRoute response = client.System().Meta().Getroutes();

// Returns details of a specific schema.
SystemSchema response = client.System().Meta().Getschema("name");

// Payment webhook endpoint after successful purchase of a plan.
CommonMessage response = client.System().Payment().Webhook("provider");
```
