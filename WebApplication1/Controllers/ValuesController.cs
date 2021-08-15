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
            if (id % 3 == 0)
            {
                if (id % 5 == 0)
                {
                    return "fishchips";
                }
                return "fish";
            } else if (id % 5 == 0)
            {
                return "ships";
            }
            return "nofish";
        }
    }
}
