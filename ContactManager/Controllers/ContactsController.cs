using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    [Route("")]
    [ApiController]
    public class ContactsController : ControllerBase
    {


        [HttpGet("GetContactInfo{name}")]
        public ActionResult<string> Get(string name)
        {
            return Ok(name);
        }


    }
}
