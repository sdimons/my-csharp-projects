#### Deploying the Application
Vidly -> right mouse click -> Publish...

#### Deploying the Database
Script for all migrations from SeedUsers to the last migration
```
PM> update-database -script -SourceMigration:SeedUsers
```

#### Build Configurations
1. Toolbar -> Select "Configuration Manager"
2. Active solution configuration -> Select "New"
3. Type name of the new configuration (Testing) and choose "copy settings from" (Release)
4. Solution Explorer -> web.config -> right mouse click -> Add Config Transform
5. Edit new web config (for example connectionString)
6. In the Publish you can use the new file config

#### Application Settings
web.config:
```
  <appSettings>
    <add key="FacebookAppId" value="123"/>
    <add key="FacebookAppSecret" value="456"/>
    ...
  </appSettings>
```
Use appSettings in code:
```
app.UseFacebookAuthentication(
	appId: ConfigurationManager.AppSettings["FacebookAppId"],
	appSecret: ConfigurationManager.AppSettings["FacebookAppSecret"]);
```

Email Server in different configurations:
Web.config:
```
<appSettings>
	<add key="MailServer" value="dev-smtp.vidly.com"/>
	...
<appSettings>
```
Web.Testing.config:
```
<appSettings>
	<add key="MailServer" value="test-smtp.vidly.com"
         xdt:Transform="SetAttributes" xdt:Locator="Match(key)"/>
 </appSettings>
```
To show changes:
Web.Testing.config -> right mouse click -> Preview Transform

#### Securing Configuration Settings
1. Create AppSettings.config and ConnectionStrings.config
2. Move "appSettings" with content to AppSettings.config
3. Move "connectionStrings" with content to ConnectionStrings.config
4. Web.config:
```
<connectionStrings configSource="ConnectionStrings.config"></connectionStrings>
<appSettings configSource="AppSettings.config"></appSettings>
```
5. Encript AppSettings.config and ConnectionStrings.config (workflow):
	- Publish your asp.net mvc application ("c:\deploy")
	- Visual Studio Tools -> Command Prompt for VS2017 (Run as Administrator)
	- 
	```
	c:\Windows\system32>aspnet_regiis -pef "appSettings" "c:\deploy" 
	-prov "DataProtectionConfigurationProvider"
	```
	```
	c:\Windows\system32>aspnet_regiis -pef "connectionStrings" "c:\deploy" 
	-prov "DataProtectionConfigurationProvider"
	```

6. Decript (There are the same steps except the last step):
```
c:\Windows\system32>aspnet_regiis -pdf "appSettings" "c:\deploy"
```

#### Custom Error Pages
1. For errors in actions:
Web.config (system.web):
```
<customErrors mode="On"></customErrors>
```
```
<customErrors mode="RemoteOnly"></customErrors>
```

It's comminf from "Views/Shared/Error.cshtml" and FilterConfig:
```
filters.Add(new HandleErrorAttribute());
```

2. For 404:  
- Web.config (system.web) if an action doesn't exist :
```
<customErrors mode="On">
  <error statusCode="404" redirect="~/404.html" />
</customErrors>
```

- Web.config (system.webServer) if a static file doesn't exists:
```
<httpErrors errorMode="Custom">
  <remove statusCode="404" />
  <error statusCode="404" path="404.html" responseMode="File" />
</httpErrors>
```

