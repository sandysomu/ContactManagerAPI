using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Database.Models
{
    public class ContactsInfo
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonRequired]
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string MobileNumber { get; set; } = null;
        public string Country { get; set; }
    }
}
