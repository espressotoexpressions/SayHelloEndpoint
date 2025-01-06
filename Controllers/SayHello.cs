using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHello : ControllerBase
    {
        [HttpPost] 
        [Route("SayHello/{name}")] 
        
        public string SayHelloName (string name)
        {

           return ("Hello, " +name+ ".");
        }

    }
}