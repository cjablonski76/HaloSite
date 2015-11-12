using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HaloSite.Models;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HaloSite.Controllers
{
	public interface IHaloService
	{
		Task<RootObject> GetArenaStatsAsync(string gamertag);
	}

	public class HaloService : IHaloService
	{
		private readonly IHaloHttpClient _haloHttpClient;

		public HaloService(IHaloHttpClient haloHttpClient)
		{
			_haloHttpClient = haloHttpClient;
		}

		public async Task<RootObject> GetArenaStatsAsync(string gamertag)
		{
			var responseMessage = await _haloHttpClient.GetAsync("stats/h5/servicerecords/arena?players=" + gamertag);
			var stringMessage = await responseMessage.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<RootObject>(stringMessage);
		}
	}

    [Route("api/[controller]")]
    public class HaloStatsController : Controller
    {
	    private readonly IHaloService _haloService;

	    public HaloStatsController(IHaloService haloService)
	    {
		    _haloService = haloService;
	    }

	    // GET: api/values
        [HttpGet]
        public async Task<RootObject> GetAsync()
        {
	        return await _haloService.GetArenaStatsAsync("skateingdevil76");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
