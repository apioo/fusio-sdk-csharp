
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
Backend_User response = client.Authorization().getWhoami();

// Revoke the access token of the current authenticated user.
Common_Message response = client.Authorization().revoke();

// Changes the password of the authenticated user.
Common_Message response = client.Backend().Account().changePassword(new Backend_AccountChangePassword());

// Returns user data of the authenticated user.
Backend_User response = client.Backend().Account().get();

// Updates user data of the authenticated user.
Common_Message response = client.Backend().Account().update(new Backend_UserUpdate());

// Creates a new action.
Common_Message response = client.Backend().Action().create(new Backend_ActionCreate());

// Deletes an existing action.
Common_Message response = client.Backend().Action().delete("action_id");

// Executes a specific action.
Backend_ActionExecuteResponse response = client.Backend().Action().execute("action_id", new Backend_ActionExecuteRequest());

// Returns a specific action.
Backend_Action response = client.Backend().Action().get("action_id");

// Returns a paginated list of actions.
Backend_ActionCollection response = client.Backend().Action().getAll(1, 1, "search");

// Returns all available action classes.
Backend_ActionIndex response = client.Backend().Action().getClasses();

// Returns a paginated list of action commits.
Backend_ActionCommitCollection response = client.Backend().Action().getCommits("action_id", 1, 1, "search");

// Returns the action config form.
Common_FormContainer response = client.Backend().Action().getForm("class");

// Updates an existing action.
Common_Message response = client.Backend().Action().update("action_id", new Backend_ActionUpdate());

// Creates a new agent.
Common_Message response = client.Backend().Agent().create(new Backend_AgentCreate());

// Deletes an existing agent.
Common_Message response = client.Backend().Agent().delete("agent_id");

// Returns a specific agent.
Backend_Agent response = client.Backend().Agent().get("agent_id");

// Returns a paginated list of agents.
Backend_AgentCollection response = client.Backend().Agent().getAll(1, 1, "search");

// Returns available tools for an agent.
Backend_AgentTools response = client.Backend().Agent().getTools();

// Returns a paginated list of agent messages.
Backend_AgentMessageCollection response = client.Backend().Agent().Message().getAll("agent_id", "chat_id");

// Submits a new agent message.
Agent_Output response = client.Backend().Agent().Message().submit("agent_id", new Agent_Input());

// Updates an existing agent.
Common_Message response = client.Backend().Agent().update("agent_id", new Backend_AgentUpdate());

// Creates a new app.
Common_Message response = client.Backend().App().create(new Backend_AppCreate());

// Deletes an existing app.
Common_Message response = client.Backend().App().delete("app_id");

// Deletes an existing token from an app.
Common_Message response = client.Backend().App().deleteToken("app_id", "token_id");

// Returns a specific app.
Backend_App response = client.Backend().App().get("app_id");

// Returns a paginated list of apps.
Backend_AppCollection response = client.Backend().App().getAll(1, 1, "search");

// Updates an existing app.
Common_Message response = client.Backend().App().update("app_id", new Backend_AppUpdate());

// Returns a specific audit.
Backend_Audit response = client.Backend().Audit().get("audit_id");

// Returns a paginated list of audits.
Backend_AuditCollection response = client.Backend().Audit().getAll(1, 1, "search", "from", "to", 1, 1, "event", "ip", "message");

// Generates an backup of the current system.
Backend_BackupExport response = client.Backend().Backup().export();

// Imports an backup to the current system.
Backend_BackupImportResult response = client.Backend().Backup().import(new Backend_BackupImport());

// Creates a new bundle.
Common_Message response = client.Backend().Bundle().create(new Backend_BundleCreate());

// Deletes an existing bundle.
Common_Message response = client.Backend().Bundle().delete("bundle_id");

// Returns a specific bundle.
Backend_Bundle response = client.Backend().Bundle().get("bundle_id");

// Returns a paginated list of bundles.
Backend_BundleCollection response = client.Backend().Bundle().getAll(1, 1, "search");

// Publish an existing bundle to the marketplace.
Common_Message response = client.Backend().Bundle().publish("bundle_id");

// Updates an existing bundle.
Common_Message response = client.Backend().Bundle().update("bundle_id", new Backend_BundleUpdate());

// Creates a new category.
Common_Message response = client.Backend().Category().create(new Backend_CategoryCreate());

// Deletes an existing category.
Common_Message response = client.Backend().Category().delete("category_id");

// Returns a specific category.
Backend_Category response = client.Backend().Category().get("category_id");

// Returns a paginated list of categories.
Backend_CategoryCollection response = client.Backend().Category().getAll(1, 1, "search");

// Updates an existing category.
Common_Message response = client.Backend().Category().update("category_id", new Backend_CategoryUpdate());

// Returns a specific config.
Backend_Config response = client.Backend().Config().get("config_id");

// Returns a paginated list of configuration values.
Backend_ConfigCollection response = client.Backend().Config().getAll(1, 1, "search");

// Updates an existing config value.
Common_Message response = client.Backend().Config().update("config_id", new Backend_ConfigUpdate());

// Sends a message to an agent.
Agent_Output response = client.Backend().Connection().Agent().send("connection_id", new Agent_Input());

// Creates a new connection.
Common_Message response = client.Backend().Connection().create(new Backend_ConnectionCreate());

// Creates a new row at a table on a database.
Common_Message response = client.Backend().Connection().Database().createRow("connection_id", "table_name", new Backend_DatabaseRow());

// Creates a new table on a database.
Common_Message response = client.Backend().Connection().Database().createTable("connection_id", new Backend_DatabaseTable());

// Deletes an existing row at a table on a database.
Common_Message response = client.Backend().Connection().Database().deleteRow("connection_id", "table_name", "id");

// Deletes an existing table on a database.
Common_Message response = client.Backend().Connection().Database().deleteTable("connection_id", "table_name");

// Returns a specific row at a table on a database.
Backend_DatabaseRow response = client.Backend().Connection().Database().getRow("connection_id", "table_name", "id");

// Returns paginated rows at a table on a database.
Backend_DatabaseRowCollection response = client.Backend().Connection().Database().getRows("connection_id", "table_name", 1, 1, "filterBy", "filterOp", "filterValue", "sortBy", "sortOrder", "columns");

// Returns the schema of a specific table on a database.
Backend_DatabaseTable response = client.Backend().Connection().Database().getTable("connection_id", "table_name");

// Returns all available tables on a database.
Backend_DatabaseTableCollection response = client.Backend().Connection().Database().getTables("connection_id", 1, 1);

// Updates an existing row at a table on a database.
Common_Message response = client.Backend().Connection().Database().updateRow("connection_id", "table_name", "id", new Backend_DatabaseRow());

// Updates an existing table on a database.
Common_Message response = client.Backend().Connection().Database().updateTable("connection_id", "table_name", new Backend_DatabaseTable());

// Deletes an existing connection.
Common_Message response = client.Backend().Connection().delete("connection_id");

// Uploads one or more files on the filesystem connection.
Common_Message response = client.Backend().Connection().Filesystem().create("connection_id", new object());

// Deletes an existing file on the filesystem connection.
Common_Message response = client.Backend().Connection().Filesystem().delete("connection_id", "file_id");

// Returns the content of the provided file id on the filesystem connection.
client.Backend().Connection().Filesystem().get("connection_id", "file_id");

// Returns all available files on the filesystem connection.
Backend_FileCollection response = client.Backend().Connection().Filesystem().getAll("connection_id", 1, 1);

// Updates an existing file on the filesystem connection.
Common_Message response = client.Backend().Connection().Filesystem().update("connection_id", "file_id", new object());

// Returns a specific connection.
Backend_Connection response = client.Backend().Connection().get("connection_id");

// Returns a paginated list of connections.
Backend_ConnectionCollection response = client.Backend().Connection().getAll(1, 1, "search", "class");

// Returns all available connection classes.
Backend_ConnectionIndex response = client.Backend().Connection().getClasses();

// Returns the connection config form.
Common_FormContainer response = client.Backend().Connection().getForm("class");

// Returns a redirect url to start the OAuth2 authorization flow for the given connection.
Backend_ConnectionRedirectResponse response = client.Backend().Connection().getRedirect("connection_id");

// Sends an arbitrary HTTP request to the connection.
Backend_HttpResponse response = client.Backend().Connection().Http().execute("connection_id", new Backend_HttpRequest());

// Returns the SDK specification.
Passthru response = client.Backend().Connection().Sdk().get("connection_id");

// Updates an existing connection.
Common_Message response = client.Backend().Connection().update("connection_id", new Backend_ConnectionUpdate());

// Creates a new cronjob.
Common_Message response = client.Backend().Cronjob().create(new Backend_CronjobCreate());

// Deletes an existing cronjob.
Common_Message response = client.Backend().Cronjob().delete("cronjob_id");

// Returns a specific cronjob.
Backend_Cronjob response = client.Backend().Cronjob().get("cronjob_id");

// Returns a paginated list of cronjobs.
Backend_CronjobCollection response = client.Backend().Cronjob().getAll(1, 1, "search", 1);

// Updates an existing cronjob.
Common_Message response = client.Backend().Cronjob().update("cronjob_id", new Backend_CronjobUpdate());

// Returns all available dashboard widgets.
Backend_Dashboard response = client.Backend().Dashboard().getAll();

// Creates a new event.
Common_Message response = client.Backend().Event().create(new Backend_EventCreate());

// Deletes an existing event.
Common_Message response = client.Backend().Event().delete("event_id");

// Returns a specific event.
Backend_Event response = client.Backend().Event().get("event_id");

// Returns a paginated list of events.
Backend_EventCollection response = client.Backend().Event().getAll(1, 1, "search", 1);

// Updates an existing event.
Common_Message response = client.Backend().Event().update("event_id", new Backend_EventUpdate());

// Creates a new firewall rule.
Common_Message response = client.Backend().Firewall().create(new Backend_FirewallCreate());

// Deletes an existing firewall rule.
Common_Message response = client.Backend().Firewall().delete("firewall_id");

// Returns a specific firewall rule.
Backend_Firewall response = client.Backend().Firewall().get("firewall_id");

// Returns a paginated list of firewall rules.
Backend_FirewallCollection response = client.Backend().Firewall().getAll(1, 1, "search");

// Updates an existing firewall rule.
Common_Message response = client.Backend().Firewall().update("firewall_id", new Backend_FirewallUpdate());

// Creates a new form.
Common_Message response = client.Backend().Form().create(new Backend_FormCreate());

// Deletes an existing form.
Common_Message response = client.Backend().Form().delete("form_id");

// Returns a specific form.
Backend_Form response = client.Backend().Form().get("form_id");

// Returns a paginated list of forms.
Backend_FormCollection response = client.Backend().Form().getAll(1, 1, "search");

// Updates an existing form.
Common_Message response = client.Backend().Form().update("form_id", new Backend_FormUpdate());

// Executes a generator with the provided config.
Common_Message response = client.Backend().Generator().executeProvider("provider", new Backend_GeneratorProvider());

// Generates a changelog of all potential changes if you execute this generator with the provided config.
Backend_GeneratorProviderChangelog response = client.Backend().Generator().getChangelog("provider", new Backend_GeneratorProviderConfig());

// Returns all available generator classes.
Backend_GeneratorIndexProviders response = client.Backend().Generator().getClasses();

// Returns the generator config form.
Common_FormContainer response = client.Backend().Generator().getForm("provider");

// Creates a new identity.
Common_Message response = client.Backend().Identity().create(new Backend_IdentityCreate());

// Deletes an existing identity.
Common_Message response = client.Backend().Identity().delete("identity_id");

// Returns a specific identity.
Backend_Identity response = client.Backend().Identity().get("identity_id");

// Returns a paginated list of identities.
Backend_IdentityCollection response = client.Backend().Identity().getAll(1, 1, "search");

// Returns all available identity classes.
Backend_IdentityIndex response = client.Backend().Identity().getClasses();

// Returns the identity config form.
Common_FormContainer response = client.Backend().Identity().getForm("class");

// Updates an existing identity.
Common_Message response = client.Backend().Identity().update("identity_id", new Backend_IdentityUpdate());

// Returns a specific log.
Backend_Log response = client.Backend().Log().get("log_id");

// Returns a paginated list of logs.
Backend_LogCollection response = client.Backend().Log().getAll(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a paginated list of log errors.
Backend_LogErrorCollection response = client.Backend().Log().getAllErrors(1, 1, "search");

// Returns a specific error.
Backend_LogError response = client.Backend().Log().getError("error_id");

// Returns a specific marketplace action.
MarketplaceAction response = client.Backend().Marketplace().Action().get("user", "name");

// Returns a paginated list of marketplace actions.
MarketplaceActionCollection response = client.Backend().Marketplace().Action().getAll(1, "query");

// Installs an action from the marketplace.
MarketplaceMessage response = client.Backend().Marketplace().Action().install(new MarketplaceInstall());

// Upgrades an action from the marketplace.
Common_Message response = client.Backend().Marketplace().Action().upgrade("user", "name");

// Returns a specific marketplace app.
MarketplaceApp response = client.Backend().Marketplace().App().get("user", "name");

// Returns a paginated list of marketplace apps.
MarketplaceAppCollection response = client.Backend().Marketplace().App().getAll(1, "query");

// Installs an app from the marketplace.
MarketplaceMessage response = client.Backend().Marketplace().App().install(new MarketplaceInstall());

// Upgrades an app from the marketplace.
MarketplaceMessage response = client.Backend().Marketplace().App().upgrade("user", "name");

// Returns a specific marketplace bundle.
MarketplaceBundle response = client.Backend().Marketplace().Bundle().get("user", "name");

// Returns a paginated list of marketplace bundles.
MarketplaceBundleCollection response = client.Backend().Marketplace().Bundle().getAll(1, "query");

// Installs an bundle from the marketplace.
MarketplaceMessage response = client.Backend().Marketplace().Bundle().install(new MarketplaceInstall());

// Upgrades an bundle from the marketplace.
MarketplaceMessage response = client.Backend().Marketplace().Bundle().upgrade("user", "name");

// Creates a new operation.
Common_Message response = client.Backend().Operation().create(new Backend_OperationCreate());

// Deletes an existing operation.
Common_Message response = client.Backend().Operation().delete("operation_id");

// Returns a specific operation.
Backend_Operation response = client.Backend().Operation().get("operation_id");

// Returns a paginated list of operations.
Backend_OperationCollection response = client.Backend().Operation().getAll(1, 1, "search", 1);

// Updates an existing operation.
Common_Message response = client.Backend().Operation().update("operation_id", new Backend_OperationUpdate());

// Creates a new page.
Common_Message response = client.Backend().Page().create(new Backend_PageCreate());

// Deletes an existing page.
Common_Message response = client.Backend().Page().delete("page_id");

// Returns a specific page.
Backend_Page response = client.Backend().Page().get("page_id");

// Returns a paginated list of pages.
Backend_PageCollection response = client.Backend().Page().getAll(1, 1, "search");

// Updates an existing page.
Common_Message response = client.Backend().Page().update("page_id", new Backend_PageUpdate());

// Creates a new plan.
Common_Message response = client.Backend().Plan().create(new Backend_PlanCreate());

// Deletes an existing plan.
Common_Message response = client.Backend().Plan().delete("plan_id");

// Returns a specific plan.
Backend_Plan response = client.Backend().Plan().get("plan_id");

// Returns a paginated list of plans.
Backend_PlanCollection response = client.Backend().Plan().getAll(1, 1, "search");

// Updates an existing plan.
Common_Message response = client.Backend().Plan().update("plan_id", new Backend_PlanUpdate());

// Creates a new rate limitation.
Common_Message response = client.Backend().Rate().create(new Backend_RateCreate());

// Deletes an existing rate.
Common_Message response = client.Backend().Rate().delete("rate_id");

// Returns a specific rate.
Backend_Rate response = client.Backend().Rate().get("rate_id");

// Returns a paginated list of rate limitations.
Backend_RateCollection response = client.Backend().Rate().getAll(1, 1, "search");

// Updates an existing rate.
Common_Message response = client.Backend().Rate().update("rate_id", new Backend_RateUpdate());

// Creates a new role.
Common_Message response = client.Backend().Role().create(new Backend_RoleCreate());

// Deletes an existing role.
Common_Message response = client.Backend().Role().delete("role_id");

// Returns a specific role.
Backend_Role response = client.Backend().Role().get("role_id");

// Returns a paginated list of roles.
Backend_RoleCollection response = client.Backend().Role().getAll(1, 1, "search");

// Updates an existing role.
Common_Message response = client.Backend().Role().update("role_id", new Backend_RoleUpdate());

// Creates a new schema.
Common_Message response = client.Backend().Schema().create(new Backend_SchemaCreate());

// Deletes an existing schema.
Common_Message response = client.Backend().Schema().delete("schema_id");

// Returns a specific schema.
Backend_Schema response = client.Backend().Schema().get("schema_id");

// Returns a paginated list of schemas.
Backend_SchemaCollection response = client.Backend().Schema().getAll(1, 1, "search", 1);

// Returns a paginated list of schema commits.
Backend_SchemaCommitCollection response = client.Backend().Schema().getCommits("schema_id", 1, 1, "search");

// Returns a HTML preview of the provided schema.
Backend_SchemaPreviewResponse response = client.Backend().Schema().getPreview("schema_id");

// Updates an existing schema.
Common_Message response = client.Backend().Schema().update("schema_id", new Backend_SchemaUpdate());

// Creates a new scope.
Common_Message response = client.Backend().Scope().create(new Backend_ScopeCreate());

// Deletes an existing scope.
Common_Message response = client.Backend().Scope().delete("scope_id");

// Returns a specific scope.
Backend_Scope response = client.Backend().Scope().get("scope_id");

// Returns a paginated list of scopes.
Backend_ScopeCollection response = client.Backend().Scope().getAll(1, 1, "search");

// Returns all available scopes grouped by category.
Backend_ScopeCategories response = client.Backend().Scope().getCategories();

// Updates an existing scope.
Common_Message response = client.Backend().Scope().update("scope_id", new Backend_ScopeUpdate());

// Generates a specific SDK.
Backend_SdkMessage response = client.Backend().Sdk().generate(new Backend_SdkGenerate());

// Returns a paginated list of SDKs.
Backend_SdkResponse response = client.Backend().Sdk().getAll();

// Returns the TypeHub specification.
Backend_SpecificationGet response = client.Backend().Specification().get();

// Returns the changelog between your current specification and the last tag.
Backend_SpecificationChangelog response = client.Backend().Specification().getChangelog();

// Publish the specification.
Common_Message response = client.Backend().Specification().publish(new Backend_SpecificationPublish());

// Creates a new tag of your specification.
Common_Message response = client.Backend().Specification().tag(new Passthru());

// Returns a statistic containing the activities per user.
Backend_StatisticChart response = client.Backend().Statistic().getActivitiesPerUser(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the request count.
Backend_StatisticCount response = client.Backend().Statistic().getCountRequests(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the errors per operation.
Backend_StatisticChart response = client.Backend().Statistic().getErrorsPerOperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the incoming requests.
Backend_StatisticChart response = client.Backend().Statistic().getIncomingRequests(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the incoming transactions.
Backend_StatisticChart response = client.Backend().Statistic().getIncomingTransactions(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the issues tokens.
Backend_StatisticChart response = client.Backend().Statistic().getIssuedTokens(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used activities.
Backend_StatisticChart response = client.Backend().Statistic().getMostUsedActivities(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used apps.
Backend_StatisticChart response = client.Backend().Statistic().getMostUsedApps(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the most used operations.
Backend_StatisticChart response = client.Backend().Statistic().getMostUsedOperations(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per ip.
Backend_StatisticChart response = client.Backend().Statistic().getRequestsPerIP(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per operation.
Backend_StatisticChart response = client.Backend().Statistic().getRequestsPerOperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the requests per user.
Backend_StatisticChart response = client.Backend().Statistic().getRequestsPerUser(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the test coverage.
Backend_StatisticChart response = client.Backend().Statistic().getTestCoverage();

// Returns a statistic containing the time average.
Backend_StatisticChart response = client.Backend().Statistic().getTimeAverage(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the time per operation.
Backend_StatisticChart response = client.Backend().Statistic().getTimePerOperation(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the used points.
Backend_StatisticChart response = client.Backend().Statistic().getUsedPoints(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Returns a statistic containing the user registrations.
Backend_StatisticChart response = client.Backend().Statistic().getUserRegistrations(1, 1, "search", "from", "to", 1, 1, 1, "ip", "userAgent", "method", "path", "header", "body");

// Creates a new taxonomy.
Common_Message response = client.Backend().Taxonomy().create(new Backend_TaxonomyCreate());

// Deletes an existing taxonomy.
Common_Message response = client.Backend().Taxonomy().delete("taxonomy_id");

// Returns a specific taxonomy.
Backend_Taxonomy response = client.Backend().Taxonomy().get("taxonomy_id");

// Returns a paginated list of taxonomies.
Backend_TaxonomyCollection response = client.Backend().Taxonomy().getAll(1, 1, "search");

// Moves the provided ids to the taxonomy.
Common_Message response = client.Backend().Taxonomy().move("taxonomy_id", new Backend_TaxonomyMove());

// Updates an existing taxonomy.
Common_Message response = client.Backend().Taxonomy().update("taxonomy_id", new Backend_TaxonomyUpdate());

// Removes an existing tenant.
Common_Message response = client.Backend().Tenant().remove("tenant_id");

// Setup a new tenant.
Common_Message response = client.Backend().Tenant().setup("tenant_id");

// Returns a specific test.
Backend_Test response = client.Backend().Test().get("test_id");

// Returns a paginated list of tests.
Backend_TestCollection response = client.Backend().Test().getAll(1, 1, "search");

// Refresh all tests.
Common_Message response = client.Backend().Test().refresh();

// Run all tests.
Common_Message response = client.Backend().Test().run();

// Updates an existing test.
Common_Message response = client.Backend().Test().update("test_id", new Backend_Test());

// Returns a specific token.
Backend_Token response = client.Backend().Token().get("token_id");

// Returns a paginated list of tokens.
Backend_TokenCollection response = client.Backend().Token().getAll(1, 1, "search", "from", "to", 1, 1, 1, "scope", "ip");

// Returns a specific transaction.
Backend_Transaction response = client.Backend().Transaction().get("transaction_id");

// Returns a paginated list of transactions.
Backend_TransactionCollection response = client.Backend().Transaction().getAll(1, 1, "search", "from", "to", 1, 1, 1, "status", "provider", 1);

// Returns all deleted records by trash type.
Backend_TrashDataCollection response = client.Backend().Trash().getAllByType("type", 1, 1, "search");

// Returns all trash types.
Backend_TrashTypes response = client.Backend().Trash().getTypes();

// Restores a previously deleted record.
Common_Message response = client.Backend().Trash().restore("type", new Backend_TrashRestore());

// Creates a new trigger.
Common_Message response = client.Backend().Trigger().create(new Backend_TriggerCreate());

// Deletes an existing trigger.
Common_Message response = client.Backend().Trigger().delete("trigger_id");

// Returns a specific trigger.
Backend_Trigger response = client.Backend().Trigger().get("trigger_id");

// Returns a paginated list of triggers.
Backend_TriggerCollection response = client.Backend().Trigger().getAll(1, 1, "search", 1);

// Updates an existing trigger.
Common_Message response = client.Backend().Trigger().update("trigger_id", new Backend_TriggerUpdate());

// Creates a new user.
Common_Message response = client.Backend().User().create(new Backend_UserCreate());

// Deletes an existing user.
Common_Message response = client.Backend().User().delete("user_id");

// Returns a specific user.
Backend_User response = client.Backend().User().get("user_id");

// Returns a paginated list of users.
Backend_UserCollection response = client.Backend().User().getAll(1, 1, "search");

// Resend the activation mail to the provided user.
Common_Message response = client.Backend().User().resend("user_id", new Passthru());

// Updates an existing user.
Common_Message response = client.Backend().User().update("user_id", new Backend_UserUpdate());

// Creates a new webhook.
Common_Message response = client.Backend().Webhook().create(new Backend_WebhookCreate());

// Deletes an existing webhook.
Common_Message response = client.Backend().Webhook().delete("webhook_id");

// Returns a specific webhook.
Backend_Webhook response = client.Backend().Webhook().get("webhook_id");

// Returns a paginated list of webhooks.
Backend_WebhookCollection response = client.Backend().Webhook().getAll(1, 1, "search");

// Updates an existing webhook.
Common_Message response = client.Backend().Webhook().update("webhook_id", new Backend_WebhookUpdate());

// Activates an previously registered account through a token which was provided to the user via email.
Common_Message response = client.Consumer().Account().activate(new Consumer_UserActivate());

// Authorizes the access of a specific app for the authenticated user.
Consumer_AuthorizeResponse response = client.Consumer().Account().authorize(new Consumer_AuthorizeRequest());

// Change the password for the authenticated user.
Common_Message response = client.Consumer().Account().changePassword(new Backend_AccountChangePassword());

// Change the password after the password reset flow was started.
Common_Message response = client.Consumer().Account().executePasswordReset(new Consumer_UserPasswordReset());

// Returns a user data for the authenticated user.
Consumer_UserAccount response = client.Consumer().Account().get();

// Returns information about a specific app to start the OAuth2 authorization code flow.
Consumer_AuthorizeMeta response = client.Consumer().Account().getApp("client_id", "scope");

// User login by providing a username and password.
Consumer_UserJWT response = client.Consumer().Account().login(new Consumer_UserLogin());

// Refresh a previously obtained access token.
Consumer_UserJWT response = client.Consumer().Account().refresh(new Consumer_UserRefresh());

// Register a new user account.
Common_Message response = client.Consumer().Account().register(new Consumer_UserRegister());

// Start the password reset flow.
Common_Message response = client.Consumer().Account().requestPasswordReset(new Consumer_UserEmail());

// Updates user data for the authenticated user.
Common_Message response = client.Consumer().Account().update(new Consumer_UserAccount());

// Returns a specific agent.
Consumer_Agent response = client.Consumer().Agent().get("agent_id");

// Returns a paginated list of agents.
Consumer_AgentCollection response = client.Consumer().Agent().getAll(1, 1, "search");

// Returns a paginated list of agent messages.
Consumer_AgentMessageCollection response = client.Consumer().Agent().Message().getAll("agent_id", "chat_id");

// Submits a new agent message.
Agent_Output response = client.Consumer().Agent().Message().submit("agent_id", new Agent_Input());

// Creates a new app for the authenticated user.
Common_Message response = client.Consumer().App().create(new Consumer_AppCreate());

// Deletes an existing app for the authenticated user.
Common_Message response = client.Consumer().App().delete("app_id");

// Returns a specific app for the authenticated user.
Consumer_App response = client.Consumer().App().get("app_id");

// Returns a paginated list of apps which are assigned to the authenticated user.
Consumer_AppCollection response = client.Consumer().App().getAll(1, 1, "search");

// Updates an existing app for the authenticated user.
Common_Message response = client.Consumer().App().update("app_id", new Consumer_AppUpdate());

// Returns a specific event for the authenticated user.
Consumer_Event response = client.Consumer().Event().get("event_id");

// Returns a paginated list of apps which are assigned to the authenticated user.
Consumer_EventCollection response = client.Consumer().Event().getAll(1, 1, "search");

// Returns a specific form for the authenticated user.
Consumer_Form response = client.Consumer().Form().get("form_id");

// Returns a paginated list of forms which are relevant to the authenticated user.
Consumer_FormCollection response = client.Consumer().Form().getAll(1, 1, "search");

// Deletes an existing grant for an app which was created by the authenticated user.
Common_Message response = client.Consumer().Grant().delete("grant_id");

// Returns a paginated list of grants which are assigned to the authenticated user.
Consumer_GrantCollection response = client.Consumer().Grant().getAll(1, 1, "search");

// Identity callback endpoint to exchange an access token.
Passthru response = client.Consumer().Identity().exchange("identity");

// Returns a paginated list of identities which are relevant to the authenticated user.
Consumer_IdentityCollection response = client.Consumer().Identity().getAll(1, "appKey");

// Redirect the user to the configured identity provider.
Passthru response = client.Consumer().Identity().redirect("identity");

// Returns a specific log for the authenticated user.
Consumer_Log response = client.Consumer().Log().get("log_id");

// Returns a paginated list of logs which are assigned to the authenticated user.
Consumer_LogCollection response = client.Consumer().Log().getAll(1, 1, "search");

// Returns a specific page for the authenticated user.
Consumer_Page response = client.Consumer().Page().get("page_id");

// Returns a paginated list of pages which are relevant to the authenticated user.
Consumer_PageCollection response = client.Consumer().Page().getAll(1, 1, "search");

// Start the checkout process for a specific plan.
Consumer_PaymentCheckoutResponse response = client.Consumer().Payment().checkout("provider", new Consumer_PaymentCheckoutRequest());

// Generates a payment portal link for the authenticated user.
Consumer_PaymentPortalResponse response = client.Consumer().Payment().portal("provider", new Consumer_PaymentPortalRequest());

// Returns a specific plan for the authenticated user.
Consumer_Plan response = client.Consumer().Plan().get("plan_id");

// Returns a paginated list of plans which are relevant to the authenticated user.
Consumer_PlanCollection response = client.Consumer().Plan().getAll(1, 1, "search");

// Returns a paginated list of scopes which are assigned to the authenticated user.
Consumer_ScopeCollection response = client.Consumer().Scope().getAll(1, 1, "search");

// Returns all scopes by category.
Consumer_ScopeCategories response = client.Consumer().Scope().getCategories();

// Creates a new token for the authenticated user.
Consumer_TokenAccessToken response = client.Consumer().Token().create(new Consumer_TokenCreate());

// Deletes an existing token for the authenticated user.
Common_Message response = client.Consumer().Token().delete("token_id");

// Returns a specific token for the authenticated user.
Consumer_Token response = client.Consumer().Token().get("token_id");

// Returns a paginated list of tokens which are assigned to the authenticated user.
Consumer_TokenCollection response = client.Consumer().Token().getAll(1, 1, "search");

// Updates an existing token for the authenticated user.
Consumer_TokenAccessToken response = client.Consumer().Token().update("token_id", new Consumer_TokenUpdate());

// Returns a specific transaction for the authenticated user.
Consumer_Transaction response = client.Consumer().Transaction().get("transaction_id");

// Returns a paginated list of transactions which are assigned to the authenticated user.
Consumer_TransactionCollection response = client.Consumer().Transaction().getAll(1, 1, "search");

// Creates a new webhook for the authenticated user.
Common_Message response = client.Consumer().Webhook().create(new Consumer_WebhookCreate());

// Deletes an existing webhook for the authenticated user.
Common_Message response = client.Consumer().Webhook().delete("webhook_id");

// Returns a specific webhook for the authenticated user.
Consumer_Webhook response = client.Consumer().Webhook().get("webhook_id");

// Returns a paginated list of webhooks which are assigned to the authenticated user.
Consumer_WebhookCollection response = client.Consumer().Webhook().getAll(1, 1, "search");

// Updates an existing webhook for the authenticated user.
Common_Message response = client.Consumer().Webhook().update("webhook_id", new Consumer_WebhookUpdate());

// Endpoint to generate a captcha challenge.
System_CaptchaChallenge response = client.System().Captcha().challenge();

// Connection OAuth2 callback to authorize a connection.
Common_Message response = client.System().Connection().callback("name");

// Returns meta information and links about the current installed Fusio version.
System_About response = client.System().Meta().getAbout();

// Debug endpoint which returns the provided data.
Passthru response = client.System().Meta().getDebug(new Passthru());

// Health check endpoint which returns information about the health status of the system.
System_HealthCheck response = client.System().Meta().getHealth();

// Returns all available routes.
System_Route response = client.System().Meta().getRoutes();

// Returns details of a specific schema.
System_Schema response = client.System().Meta().getSchema("name");

// Payment webhook endpoint after successful purchase of a plan.
Common_Message response = client.System().Payment().webhook("provider");
```
