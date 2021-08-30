using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruito.Controllers
{
    [Route("api/[controller]/[action]")]
    public class HelloController:ruitoControllerBase
    {
        public HelloController()
        {

        }

        [HttpGet]
        public string SayHello(string user)
        {
            return "hello " + user;
        }
    }
}
