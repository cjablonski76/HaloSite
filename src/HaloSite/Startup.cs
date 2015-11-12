using System;
using System.Net.Http;
using HaloSite.Controllers;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace HaloSite
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
	        services.AddTransient<IHaloService, HaloService>();
	        var httpClient = new HttpClient {BaseAddress = new Uri("https://www.haloapi.com/")};
			httpClient.DefaultRequestHeaders.Add(ApiTokenHeader, "6b2a9a0cc1454506b3f24538a0a7dc13");
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
