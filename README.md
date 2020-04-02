# Facebook.AspNetCore.Extensions.DependencyInjection nuget package

Add client services for the Facebook graph API to your ASP.NET Core application.

This package is part of a three package group :
- [Facebook.AspNetCore.Extensions.DependencyInjection](https://github.com/pedro-de-rycker/Facebook.AspNetCore.Extensions.DependencyInjection)
- [Facebook.NetCore.Service](https://github.com/pedro-de-rycker/Facebook.NetCore.Service)
- [Facebook.NetCore.HttpClient](https://github.com/pedro-de-rycker/Facebook.NetCore.HttpClient)
 
## Get started

Download the following package from [nuget.org](https://www.nuget.org/) :

```
Facebook.AspNetCore.Extensions.DependencyInjection
```

Add the services in the  `Startup.cs`
``` csharp
services.AddFacebookServices(new FacebookServicesOptions
{
    ClientId = "{your-client-id}",
    ClientSecret = "{your-client-secret}"
});
```

## Available services

The different services are listed in the `Facebook.NetCore.Service` package [repository README.md](https://github.com/pedro-de-rycker/Facebook.NetCore.Service).