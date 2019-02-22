using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ContentManagerAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            string url = "http://localhost:8080/Contacts/GetContactInfo/saanu";
            
            //var client = new HttpClient();

            var client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };

            //  client.BaseAddress = new Uri(url);

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

            var myRootObject = await response.Content.ReadAsAsync<ContactInfo>();
        }
    }


    
}
