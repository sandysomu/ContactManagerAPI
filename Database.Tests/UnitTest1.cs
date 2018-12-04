using Database.Models;
using Database.Services;
using System.Threading.Tasks;
using Xunit;

namespace Database.Tests
{
    public class UnitTest1
    {
        MongoDbService DbService = new MongoDbService("Contacts");

        [Fact]
        public async Task InsertContactTest()
        {
            await DbService.InsertContact(new ContactsInfo { FirstName = "Ashu", LastName = "Ola", Country = "Aus", MobileNumber = "123456" });
        }

        [Fact]
        public async Task ReadContactTest()
        {
           var test = await DbService.GetAllContacts();
        }
    }

}
