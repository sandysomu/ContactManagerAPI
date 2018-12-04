using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using Database.Models;

namespace Database.Services
{
    public class MongoDbService
    {
        private IMongoCollection<ContactsInfo> ContactsCollection { get; }

        public MongoDbService(string collectionName)
        {
            var mongoClient = new MongoClient("mongodb://MongoUser:Sandeep&980@mongodb01-cnfpz.mongodb.net/test?retryWrites=true");
            var mongoDatabase = mongoClient.GetDatabase(collectionName);

            ContactsCollection = mongoDatabase.GetCollection<ContactsInfo>(collectionName);
        }


        public async Task InsertContact(ContactsInfo info) => await ContactsCollection.InsertOneAsync(info);


        public async Task<List<ContactsInfo>> GetAllContacts()
        {
            var contacts = new List<ContactsInfo>();

            var allContacts = await ContactsCollection.FindAsync(new BsonDocument());
            await allContacts.ForEachAsync(con => contacts.Add(con));
            return contacts;
        }

    }
}
