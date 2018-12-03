using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagerAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ContentManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {

        private readonly AppSettings _appSettings;

        public ContactsController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

     

        [HttpGet("GetContactInfo/{name}")]
        public ActionResult<string> Get(string name)
        {
            return Ok(name + "   Good Job My Friend " + _appSettings.ConnectionStrings.TBSConnectionString );
        }










    }
}