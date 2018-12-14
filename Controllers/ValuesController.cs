using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FV_Iss_977.Models;
using Microsoft.AspNetCore.Mvc;

namespace FV_Iss_977.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpPost]
        public ActionResult<string> Post(Car car)
        {
            return car.Model;
        }

        // GET api/values/5
        [HttpGet("")]
        public ActionResult<string> Get(EntityIdList ids)
        {
            if (ids == null)
                throw new Exception("Why did FV not catch this?");

            return string.Join(",", ids.Select(x => x));
        }
    }
}
