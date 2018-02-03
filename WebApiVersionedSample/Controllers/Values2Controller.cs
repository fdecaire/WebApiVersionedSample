using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApiVersionedSample.Controllers
{
	[ApiVersion("2.0")]
	[ApiVersion("2.1")]
	[Route("v{version:apiVersion}/Values")]
    public class Values2Controller : Controller
    {
        [HttpGet, MapToApiVersion("2.0")]
        public IEnumerable<string> GetV20()
        {
            return new string[] { "value1 - version 2", "value2 - version 2" };
        }

	    [HttpGet, MapToApiVersion("2.1")]
	    public IEnumerable<string> GetV21()
	    {
		    return new string[] { "value1 - version 2.1", "value2 - version 2.1" };
	    }

		[HttpGet("{id}", Name = "Get"), MapToApiVersion("2.0")]
        public string Get20(int id)
        {
            return $"id={id} version 2.0";
        }

	    [HttpGet("{id}", Name = "Get"), MapToApiVersion("2.1")]
	    public string Get21(int id)
	    {
		    return $"id={id} version 2.1";
	    }
    }
}
