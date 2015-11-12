using System;
using System.Net.Http;
using HaloSite.Controllers;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.Runtime;

namespace HaloSite
{
    public class Startup
    {
		public IConfiguration Configuration { get; set; }

		public Startup(IApplicationEnvironment appEnv)
		{
			//var builder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
			//  .AddJsonFile("config.json")
			//  .AddUserSecrets()
			//  .AddEnvironmentVariables();

			//Configuration = builder.Build();
		}

		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
        {
	        services.AddTransient<IHaloService, HaloService>();
	        var httpClient = new HttpClient {BaseAddress = new Uri("https://www.haloapi.com/")};
			httpClient.DefaultRequestHeaders.Add(ApiTokenHeader, "abc123");
			services.AddSingleton<IHaloHttpClient, HaloHttpClient>(provider => new HaloHttpClient(httpClient));
	        services.AddMvc();
        }

	    public string ApiTokenHeader = "Ocp-Apim-Subscription-Key";

	    public void Configure(IApplicationBuilder app)
        {
	        app.UseMvc();
        }
    }
}
