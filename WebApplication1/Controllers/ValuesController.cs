using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController(){}

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            int three = id % 3;
            int five = id % 5;

            if (three == 0)
            {
                return five == 0 ? "fishchips" : "fish";
            } 
            else if (five == 0)
            {
                return "ships";
            }
            return "nofish";
        }
    }
}
