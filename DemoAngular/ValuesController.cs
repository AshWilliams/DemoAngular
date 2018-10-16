using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAngular
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            return await Task.Run(()=> new string[] { "Proyecto", "Angular", "+", ".Net Core", "Web", "API?" });
        }

    }
}
