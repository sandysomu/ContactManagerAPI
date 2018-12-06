using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagerAPI.Model;
using DynamoDb.Libs.DynamoDb;
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
        //private readonly IDynamoDbExamples _dynamoDbExamples;


        public ContactsController(IOptions<AppSettings> appSettings) // //public ContactsController(IOptions<AppSettings> appSettings, IDynamoDbExamples dynamoDbExamples)
        {
           // _dynamoDbExamples = dynamoDbExamples;
            _appSettings = appSettings.Value;
        }



        [HttpGet("GetContactInfo/{name}")]
        public ActionResult<string> Get(string name)
        {
         //   _dynamoDbExamples.CreateDynamoDbTable();
            return Ok(name + "   Good Job My Friend " );
        }



        // FirstName, LastName, MobileNumber, Address , emailId








    }
}