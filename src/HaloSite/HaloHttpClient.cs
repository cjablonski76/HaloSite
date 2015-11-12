using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HaloSite
{
	public interface IHaloHttpClient
	{
		Task<HttpResponseMessage> GetAsync(string requestUri);
	}

    public class HaloHttpClient : IHaloHttpClient
	{
	    private readonly HttpClient _httpClient;

	    public HaloHttpClient(HttpClient httpClient)
	    {
			_httpClient = httpClient;
			_httpClient.BaseAddress = new Uri("https://www.haloapi.com/");
	    }


	    public async Task<HttpResponseMessage> GetAsync(string requestUri)
	    {
		    return await _httpClient.GetAsync(requestUri);
	    }
	}
}
