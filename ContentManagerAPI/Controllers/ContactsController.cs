using System;
using ContentManagerAPI.Model;
using ContentManagerAPI.Models;
using ContentManagerAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ContentManagerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsService _contactService;
        private readonly AppSettings _appSettings;

        public ContactsController(IOptions<AppSettings> appSettings, IContactsService contactService)
        {
            _contactService = contactService;
            _appSettings = appSettings.Value;
        }

        [HttpGet("GetContactInfo/{name}")]
        public ContactsInfo GetTransaction(string name)
        {
            return _contactService.GetContactsInfo(name);
        }

        [HttpPost("PostContactInfo")]
        public ActionResult<string> Get(ContactsInfo Info)
        {
            try
            {
              return Ok(_contactService.UpdateContactInfo(Info));
            }
            catch (Exception e)
            {
                return Ok(e.InnerException.Message);
            }


        }



    }
}