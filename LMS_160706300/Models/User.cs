using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LMS_160706300.Models
{
    public class User
    {
        [BsonId]
        public BsonObjectId UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int BorrowedBookCount { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserNestedFields Borrow { get; set; }
    }
}
