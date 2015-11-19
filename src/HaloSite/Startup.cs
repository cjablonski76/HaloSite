using System;
using System.Net.Http;
using HaloSite.Controllers;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace HaloSite
{
    public class Startup
    {
		public IConfiguration Configuration { get; set; }

		public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(appEnv.ApplicationBasePath)
				.AddUserSecrets();
			Configuration = builder.Build();
		}

		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
        {
	        services.AddTransient<IHaloService, HaloService>();
	        var httpClient = new HttpClient {BaseAddress = new Uri("https://www.haloapi.com/")};
            httpClient.DefaultRequestHeaders.Add(ApiTokenHeader, Configuration["haloApiToken"]);
			services.AddSingleton<IHaloHttpClient, HaloHttpClient>(provider => new HaloHttpClient(httpClient));
			services.AddMvc();
        }

	    private const string ApiTokenHeader = "Ocp-Apim-Subscription-Key";

	    public void Configure(IApplicationBuilder app)
        {
	        app.UseMvc();
        }
    }
}
